using System.Drawing;

namespace ChukebloEditor.BindingModel
{
    public class TextBoxBindingModel : BindingModelBase
    {
        private string text = string.Empty;
        private int selectionStart = 0;
        private int selectionLength = 0;
        private string selectedText = string.Empty;
        private Color selectionBackColor = Color.Transparent;
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                OnPropertyChanged(PropertyNameConstants.Text);
            }
        }
        public int SelectionStart
        {
            get
            {
                return selectionStart;
            }
            set
            {
                selectionStart = value;
                OnPropertyChanged(PropertyNameConstants.SelectionStart);
            }
        }
        public int SelectionLength
        {
            get
            {
                return selectionLength;
            }
            set
            {
                selectionLength = value;
                OnPropertyChanged(PropertyNameConstants.SelectionLength);
            }
        }
        public string SelectedText
        {
            get
            {
                return selectedText;
            }
            set
            {
                selectedText = value;
                OnPropertyChanged(PropertyNameConstants.SelectedText);
            }
        }
        public Color SelectionBackColor
        {
            get
            {
                return selectionBackColor;
            }
            set
            {
                selectionBackColor = value;
                OnPropertyChanged(PropertyNameConstants.SelectionBackColor);
            }
        }
    }
}

