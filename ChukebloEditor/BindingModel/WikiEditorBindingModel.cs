namespace ChukebloEditor.BindingModel
{
    public class WikiEditorBindingModel : BindingModelBase
    {
        private string title = string.Empty;
        private string tag = string.Empty;
        private string body = string.Empty;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                OnPropertyChanged(PropertyNameConstants.WikiEditor.Title);
            }
        }

        public string Tag
        {
            get
            {
                return tag;
            }
            set
            {
                tag = value;
                OnPropertyChanged(PropertyNameConstants.WikiEditor.Tag);
            }
        }

        public string Body
        {
            get
            {
                return body;
            }
            set
            {
                body = value;
                OnPropertyChanged(PropertyNameConstants.WikiEditor.Body);
            }
        }
    }
}
