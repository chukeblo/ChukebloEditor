using ChukebloEditor.BindingModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace ChukebloEditor.UI
{
    public partial class WikiEditorForm : Form
    {
        private WikiEditorBindingModel wikiEditorBindingModel;
        public WikiEditorForm()
        {
            InitializeComponent();
            AddDataBindings();
        }

        public void AddDataBindings()
        {
            wikiEditorBindingModel = new WikiEditorBindingModel();
            this.txtTitle.DataBindings.Add(PropertyNameConstants.Text,
                this.wikiEditorBindingModel, PropertyNameConstants.WikiEditor.Title);
            this.txtTag.DataBindings.Add(PropertyNameConstants.Text,
                this.wikiEditorBindingModel, PropertyNameConstants.WikiEditor.Tag);
            this.txtBody.DataBindings.Add(PropertyNameConstants.Text,
                this.wikiEditorBindingModel, PropertyNameConstants.WikiEditor.Body);
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (!ValidateUserInput())
            {
                return;
            }
            var dialog = new SaveFileDialog();
            dialog.InitialDirectory = DialogConstants.InitialDirectory.CDrive;
            dialog.Title = DialogConstants.Title.SaveFile;
            dialog.Filter = DialogConstants.Filter.Text;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var textList = new List<string>
                {
                    this.wikiEditorBindingModel.Title,
                    this.wikiEditorBindingModel.Tag,
                    this.wikiEditorBindingModel.Body
                };
                var text = string.Join(Environment.NewLine, textList);
                var jsonDictionary = new Dictionary<string, object>
                {
                    { "title", this.wikiEditorBindingModel.Title },
                    { "tag", this.wikiEditorBindingModel.Tag },
                    { "body", this.wikiEditorBindingModel.Body }
                };
                var json = JsonSerializer.Serialize(jsonDictionary);
                File.WriteAllText(dialog.FileName, json);
                var deserializedJsonDictionary = JsonSerializer.Deserialize<Dictionary<string, object>>(
                    File.ReadAllText(dialog.FileName));
                ClearInputText();
                this.wikiEditorBindingModel.Title = deserializedJsonDictionary["title"].ToString();
                this.wikiEditorBindingModel.Tag = deserializedJsonDictionary["tag"].ToString();
                this.wikiEditorBindingModel.Body = deserializedJsonDictionary["body"].ToString();
            }
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            ClearInputText();
        }

        private bool ValidateUserInput()
        {
            if (string.IsNullOrEmpty(this.wikiEditorBindingModel.Title))
            {
                return false;
            }
            if (string.IsNullOrEmpty(this.wikiEditorBindingModel.Tag))
            {
                return false;
            }
            if (string.IsNullOrEmpty(this.wikiEditorBindingModel.Body))
            {
                return false;
            }
            return true;
        }

        private void ClearInputText()
        {
            this.wikiEditorBindingModel.Title = string.Empty;
            this.wikiEditorBindingModel.Tag = string.Empty;
            this.wikiEditorBindingModel.Body = string.Empty;
        }
    }
}
