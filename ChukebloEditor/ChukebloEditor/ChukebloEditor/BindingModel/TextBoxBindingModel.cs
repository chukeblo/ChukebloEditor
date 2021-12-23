namespace ChukebloEditor.BindingModel
{
    public class TextBoxBindingModel : BindingModelBase
    {
        private string text = string.Empty;
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
    }
}
