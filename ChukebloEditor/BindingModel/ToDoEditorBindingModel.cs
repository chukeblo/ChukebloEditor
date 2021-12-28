namespace ChukebloEditor.BindingModel
{
    public class ToDoEditorBindingModel : BindingModelBase
    {
        private string title = string.Empty;
        private string tag = string.Empty;
        private string wiki = string.Empty;
        private string memo = string.Empty;

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
                OnPropertyChanged(PropertyNameConstants.ToDoEditor.Title);
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
                OnPropertyChanged(PropertyNameConstants.ToDoEditor.Tag);
            }
        }

        public string Wiki
        {
            get
            {
                return wiki;
            }
            set
            {
                wiki = value;
                OnPropertyChanged(PropertyNameConstants.ToDoEditor.Wiki);
            }
        }

        public string Memo
        {
            get
            {
                return memo;
            }
            set
            {
                memo = value;
                OnPropertyChanged(PropertyNameConstants.ToDoEditor.Memo);
            }
        }
    }
}
