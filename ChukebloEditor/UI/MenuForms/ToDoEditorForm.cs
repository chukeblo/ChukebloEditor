using ChukebloEditor.BindingModel;
using ChukebloEditor.ManagementItemData;
using System;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace ChukebloEditor.UI.MenuForms
{
    public partial class ToDoEditorForm : Form
    {
        private ToDoEditorBindingModel toDoEditorBindingModel = new ToDoEditorBindingModel();
        private static readonly string ToDoFolderPath = $"c:\\Users\\{Environment.UserName}\\.chukebloeditor\\todo\\";
        public ToDoEditorForm(ToDoItemData data)
        {
            InitializeComponent();
            AddDataBindings();
            InitializeTextData(data);
        }

        private void InitializeTextData(ToDoItemData data)
        {
            if (data == null)
            {
                return;
            }
            this.toDoEditorBindingModel.Title = data.Title;
            this.toDoEditorBindingModel.Tag = data.Title;
            this.toDoEditorBindingModel.Wiki = data.Wiki;
            this.toDoEditorBindingModel.Memo = data.Memo;
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
            var toDoItemData = new ToDoItemData(
                this.toDoEditorBindingModel.Title,
                this.toDoEditorBindingModel.Tag,
                this.toDoEditorBindingModel.Wiki,
                this.toDoEditorBindingModel.Memo);
            var json = JsonSerializer.Serialize(toDoItemData);
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
