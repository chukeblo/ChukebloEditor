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
            textBox.DataBindings.Add(PropertyNameConstants.Text,
                textBoxBindingModel, PropertyNameConstants.Text);
            this.textBoxBindingModel = textBoxBindingModel;
        }
    }
}
