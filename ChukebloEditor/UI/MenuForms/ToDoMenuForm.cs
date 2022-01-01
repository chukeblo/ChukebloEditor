using ChukebloEditor.ManagementItemData;
using ChukebloEditor.UI.ManagementItemForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

namespace ChukebloEditor.UI.MenuForms
{
    public partial class ToDoMenuForm : Form
    {
        private Form editorForm = null;
        private static readonly string ToDoFolderPath = $"c:\\Users\\{Environment.UserName}\\.chukebloeditor\\ToDo\\";
        private static readonly string JsonFileFilter = ".json";

        public ToDoMenuForm()
        {
            InitializeComponent();
            DisplayToDoItems();
        }

        private void DisplayToDoItems()
        {
            var files = from dir in Directory.GetFiles(ToDoFolderPath)
                        where dir.EndsWith(JsonFileFilter)
                        select dir;
            foreach (var file in files)
            {
                var json = File.ReadAllText(file);
                var data = JsonSerializer.Deserialize<ToDoItemData>(json);
                GenerateToDoItemForm(data);
            }
        }

        private void GenerateToDoItemForm(ToDoItemData data)
        {
            var itemForm = new ToDoItemForm(data);
            itemForm.TopLevel = false;
            itemForm.Dock = DockStyle.Left;
            this.pnlUnfinishedToDoItems.Controls.Add(itemForm);
            itemForm.BringToFront();
            itemForm.Show();
            itemForm.FormClosed += ItemForm_FormClosed;
        }

        private void ItemForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            var itemForm = sender as ToDoItemForm;
            switch (itemForm.status)
            {
                case CloseStatus.None:
                    break;
                case CloseStatus.Clicked:
                    this.OpenToDoEditorForm(itemForm.Title);
                    break;
                case CloseStatus.Finished:
                    this.FinalizeToDoItemStatus(itemForm.Title);
                    break;
                case CloseStatus.Deleted:
                    this.DeleteToDoItemData(itemForm.Title);
                    break;
                default:
                    throw new InvalidOperationException("not supported close status");
            }
            if (this.pnlUnfinishedToDoItems.Controls.Contains(itemForm))
            {
                this.pnlUnfinishedToDoItems.Controls.Remove(itemForm);
            }
        }

        private string GenerateFilePathFrom(string title)
        {
            return $"{ToDoFolderPath}{title}{JsonFileFilter}";
        }

        private void OpenToDoEditorForm(string title)
        {
            var json = File.ReadAllText(GenerateFilePathFrom(title));
            var data = JsonSerializer.Deserialize<ToDoItemData>(json);
            GenerateToDoEditorFormFrom(data);
        }

        private void FinalizeToDoItemStatus(string title)
        {
            var path = GenerateFilePathFrom(title);
            var json = File.ReadAllText(path);
            var data = JsonSerializer.Deserialize<ToDoItemData>(json);
            data.FinalizeToDoItemData();
            var revisedJson = JsonSerializer.Serialize<ToDoItemData>(data);
            File.WriteAllText(path, revisedJson);
        }

        private void DeleteToDoItemData(string title)
        {
            var target = new FileInfo(GenerateFilePathFrom(title));
            if (target.Exists)
            {
                target.Delete();
            }
        }

        private void GenerateToDoEditorFormFrom(ToDoItemData data)
        {
            this.pnlToDoFormWindowRange.Hide();
            this.editorForm = new ToDoEditorForm(data);
            this.editorForm.TopLevel = false;
            this.editorForm.Dock = DockStyle.Fill;
            this.editorForm.FormBorderStyle = FormBorderStyle.None;
            this.Controls.Add(this.editorForm);
            this.editorForm.BringToFront();
            this.editorForm.Show();
            this.editorForm.FormClosed += EditorForm_FormClosed;
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            GenerateToDoEditorFormFrom(null);
        }

        private void EditorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Controls.Remove(this.editorForm);
            this.editorForm = null;
            this.pnlToDoFormWindowRange.BringToFront();
            this.pnlToDoFormWindowRange.Show();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {

        }
    }
}
