using ChukebloEditor.BindingModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace ChukebloEditor.UI.MenuForms
{
    public partial class TasksEditorForm : Form
    {
        private TasksEditorBindingModel tasksEditorBindingModel = new TasksEditorBindingModel();
        private static readonly string TasksFolderPath = $"c:\\Users\\{Environment.UserName}\\.chukebloeditor\\tasks\\";

        public TasksEditorForm()
        {
            InitializeComponent();
            AddDataBindings();
        }

        private void AddDataBindings()
        {
            this.txtTitle.DataBindings.Add(PropertyNameConstants.Text,
                this.tasksEditorBindingModel, PropertyNameConstants.TasksEditor.Title);
            this.txtTag.DataBindings.Add(PropertyNameConstants.Text,
                this.tasksEditorBindingModel, PropertyNameConstants.TasksEditor.Tag);
            this.txtWiki.DataBindings.Add(PropertyNameConstants.Text,
                this.tasksEditorBindingModel, PropertyNameConstants.TasksEditor.Wiki);
            this.txtMemo.DataBindings.Add(PropertyNameConstants.Text,
                this.tasksEditorBindingModel, PropertyNameConstants.TasksEditor.Memo);
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            var jsonDictionary = new Dictionary<string, object>
            {
                { "title", this.tasksEditorBindingModel.Title },
                { "tag", this.tasksEditorBindingModel.Tag },
                { "wiki", this.tasksEditorBindingModel.Wiki },
                { "memo", this.tasksEditorBindingModel.Memo }
            };
            var json = JsonSerializer.Serialize(jsonDictionary);
            var filePath = $"{TasksFolderPath}{this.tasksEditorBindingModel.Title}.json";
            File.WriteAllText(filePath, json);
            this.Close();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(this.tasksEditorBindingModel.Title))
            {
                return false;
            }
            if (string.IsNullOrEmpty(this.tasksEditorBindingModel.Tag))
            {
                return false;
            }
            if (string.IsNullOrEmpty(this.tasksEditorBindingModel.Wiki))
            {
                return false;
            }
            if (string.IsNullOrEmpty(this.tasksEditorBindingModel.Memo))
            {
                return false;
            }
            return true;
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            ClearInput();
        }

        private void ClearInput()
        {
            this.tasksEditorBindingModel.Title = string.Empty;
            this.tasksEditorBindingModel.Tag = string.Empty;
            this.tasksEditorBindingModel.Wiki = string.Empty;
            this.tasksEditorBindingModel.Memo = string.Empty;
        }
    }
}
