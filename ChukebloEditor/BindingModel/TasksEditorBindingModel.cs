namespace ChukebloEditor.BindingModel
{
    public class TasksEditorBindingModel : BindingModelBase
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
                OnPropertyChanged(PropertyNameConstants.TasksEditor.Title);
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
                OnPropertyChanged(PropertyNameConstants.TasksEditor.Tag);
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
                OnPropertyChanged(PropertyNameConstants.TasksEditor.Wiki);
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
                OnPropertyChanged(PropertyNameConstants.TasksEditor.Memo);
            }
        }
    }
}
