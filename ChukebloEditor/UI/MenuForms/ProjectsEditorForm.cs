using ChukebloEditor.BindingModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace ChukebloEditor.UI.MenuForms
{
    public partial class ProjectsEditorForm : Form
    {
        private ProjectsEditorBindingModel projectsEditorBindingModel = new ProjectsEditorBindingModel();
        private static readonly string ProjectsFolderPath = $"c:\\Users\\{Environment.UserName}\\.chukebloeditor\\Projects\\";

        public ProjectsEditorForm()
        {
            InitializeComponent();
            AddDataBindings();
        }

        private void AddDataBindings()
        {
            this.txtTitle.DataBindings.Add(PropertyNameConstants.Text,
                this.projectsEditorBindingModel, PropertyNameConstants.ProjectsEditor.Title);
            this.txtTag.DataBindings.Add(PropertyNameConstants.Text,
                this.projectsEditorBindingModel, PropertyNameConstants.ProjectsEditor.Tag);
            this.txtWiki.DataBindings.Add(PropertyNameConstants.Text,
                this.projectsEditorBindingModel, PropertyNameConstants.ProjectsEditor.Wiki);
            this.txtMemo.DataBindings.Add(PropertyNameConstants.Text,
                this.projectsEditorBindingModel, PropertyNameConstants.ProjectsEditor.Memo);
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            var jsonDictionary = new Dictionary<string, object>
            {
                { "title", this.projectsEditorBindingModel.Title },
                { "tag", this.projectsEditorBindingModel.Tag },
                { "wiki", this.projectsEditorBindingModel.Wiki },
                { "memo", this.projectsEditorBindingModel.Memo }
            };
            var json = JsonSerializer.Serialize(jsonDictionary);
            var filePath = $"{ProjectsFolderPath}{this.projectsEditorBindingModel.Title}.json";
            File.WriteAllText(filePath, json);
            this.Close();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(this.projectsEditorBindingModel.Title))
            {
                return false;
            }
            if (string.IsNullOrEmpty(this.projectsEditorBindingModel.Tag))
            {
                return false;
            }
            if (string.IsNullOrEmpty(this.projectsEditorBindingModel.Wiki))
            {
                return false;
            }
            if (string.IsNullOrEmpty(this.projectsEditorBindingModel.Memo))
            {
                return false;
            }
            return true;
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {

        }
    }
}
