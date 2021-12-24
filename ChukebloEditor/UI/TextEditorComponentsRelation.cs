using ChukebloEditor.BindingModel;
using System.Windows.Forms;

namespace ChukebloEditor.UI
{
    public class TextEditorComponentsRelation
    {
        public Button Button { get; }
        public TextForm TextForm { get; }
        public TextBoxBindingModel TextBoxBindingModel { get; }

        public TextEditorComponentsRelation(Button button, TextForm textForm, TextBoxBindingModel textBoxBindingModel)
        {
            Button = button;
            TextForm = textForm;
            TextBoxBindingModel = textBoxBindingModel;
        }
    }
}
