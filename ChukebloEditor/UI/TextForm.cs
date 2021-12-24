using ChukebloEditor.BindingModel;
using System.Windows.Forms;

namespace ChukebloEditor.UI
{
    public partial class TextForm : Form
    {
        private TextBoxBindingModel textBoxBindingModel;

        public TextForm(TextBoxBindingModel textBoxBindingModel)
        {
            InitializeComponent();
            this.textBoxBindingModel = textBoxBindingModel;
            BindDataToTextBox();
        }

        private void BindDataToTextBox()
        {
            this.textBox.DataBindings.Add(PropertyNameConstants.Text,
                this.textBoxBindingModel, PropertyNameConstants.Text);
            this.textBox.DataBindings.Add(PropertyNameConstants.SelectionStart,
                this.textBoxBindingModel, PropertyNameConstants.SelectionStart);
            this.textBox.DataBindings.Add(PropertyNameConstants.SelectionLength,
                this.textBoxBindingModel, PropertyNameConstants.SelectionLength);
            this.textBox.DataBindings.Add(PropertyNameConstants.SelectedText,
                this.textBoxBindingModel, PropertyNameConstants.SelectedText);
            this.textBox.DataBindings.Add(PropertyNameConstants.SelectionBackColor,
                this.textBoxBindingModel, PropertyNameConstants.SelectionBackColor);

        }
    }
}
