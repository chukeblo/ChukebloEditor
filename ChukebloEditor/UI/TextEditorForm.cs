using ChukebloEditor.BindingModel;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChukebloEditor.UI
{
    public partial class TextEditorForm : Form
    {
        private List<TextEditorComponentsRelation> relations = new List<TextEditorComponentsRelation>();

        public TextEditorForm()
        {
            InitializeComponent();
            InitializePanels();
        }

        private void InitializePanels()
        {
            var button = new Button();
            InitializeFileTabArea(button);
            var textBoxBindingModel = new TextBoxBindingModel();
            var textForm = new TextForm(textBoxBindingModel);
            InitializeTextInputArea(textForm);
            relations.Add(new TextEditorComponentsRelation(button, textForm, textBoxBindingModel));
        }

        private void InitializeFileTabArea(Button button)
        {
            ActivateNewFileTabButton(button);
        }

        private void InitializeTextInputArea(TextForm textForm)
        {
            ActivateNewTextForm(textForm);
        }

        private void ActivateNewFileTabButton(Button button)
        {

        }

        private void ActivateNewTextForm(TextForm newTextForm)
        {
            newTextForm.TopLevel = false;
            newTextForm.FormBorderStyle = FormBorderStyle.None;
            newTextForm.Dock = DockStyle.Fill;
            newTextForm.Enabled = true;
            pnlTextBoxArea.Controls.Add(newTextForm);
            pnlTextBoxArea.Tag = newTextForm;
            newTextForm.Show();
        }
    }
}
