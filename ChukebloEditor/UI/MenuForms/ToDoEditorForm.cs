using ChukebloEditor.BindingModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace ChukebloEditor.UI.MenuForms
{
    public partial class ToDoEditorForm : Form
    {
        private ToDoEditorBindingModel toDoEditorBindingModel = new ToDoEditorBindingModel();
        private static readonly string ToDoFolderPath = $"c:\\Users\\{Environment.UserName}\\.chukebloeditor\\todo\\";
        public ToDoEditorForm()
        {
            InitializeComponent();
            AddDataBindings();
        }

        private void AddDataBindings()
        {
            this.txtTitle.DataBindings.Add(PropertyNameConstants.Text,
                toDoEditorBindingModel, PropertyNameConstants.ToDoEditor.Title);
            this.txtTag.DataBindings.Add(PropertyNameConstants.Text,
                toDoEditorBindingModel, PropertyNameConstants.ToDoEditor.Tag);
            this.txtWiki.DataBindings.Add(PropertyNameConstants.Text,
                toDoEditorBindingModel, PropertyNameConstants.ToDoEditor.Wiki);
            this.txtMemo.DataBindings.Add(PropertyNameConstants.Text,
                toDoEditorBindingModel, PropertyNameConstants.ToDoEditor.Memo);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }
            var jsonDictionary = new Dictionary<string, object>
            {
                { "title", this.toDoEditorBindingModel.Title },
                { "tag", this.toDoEditorBindingModel.Tag },
                { "wiki", this.toDoEditorBindingModel.Wiki },
                { "memo", this.toDoEditorBindingModel.Memo }
            };
            var json = JsonSerializer.Serialize(jsonDictionary);
            var filePath = $"{ToDoFolderPath}{this.toDoEditorBindingModel.Title}.json";
            File.WriteAllText(filePath, json);
            this.Close();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(this.toDoEditorBindingModel.Title))
            {
                return false;
            }
            if (string.IsNullOrEmpty(this.toDoEditorBindingModel.Tag))
            {
                return false;
            }
            if (string.IsNullOrEmpty(this.toDoEditorBindingModel.Wiki))
            {
                return false;
            }
            if (string.IsNullOrEmpty(this.toDoEditorBindingModel.Memo))
            {
                return false;
            }
            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInput();
        }

        private void ClearInput()
        {
            this.toDoEditorBindingModel.Title = string.Empty;
            this.toDoEditorBindingModel.Tag = string.Empty;
            this.toDoEditorBindingModel.Wiki = string.Empty;
            this.toDoEditorBindingModel.Memo = string.Empty;
        }
    }
}
