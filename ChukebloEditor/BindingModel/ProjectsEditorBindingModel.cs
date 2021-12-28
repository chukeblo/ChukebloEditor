namespace ChukebloEditor.BindingModel
{
    public class ProjectsEditorBindingModel : BindingModelBase
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
                OnPropertyChanged(PropertyNameConstants.ProjectsEditor.Title);
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
                OnPropertyChanged(PropertyNameConstants.ProjectsEditor.Tag);
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
                OnPropertyChanged(PropertyNameConstants.ProjectsEditor.Wiki);
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
                OnPropertyChanged(PropertyNameConstants.ProjectsEditor.Memo);
            }
        }
    }
}
