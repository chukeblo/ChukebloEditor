namespace ChukebloEditor.ManagementItemData
{
    public class ToDoItemData : ManagementItemDataBase
    {
        public string Wiki { get; }
        public string Memo { get; }
        public bool Finished { get; private set; }

        public ToDoItemData(string title, string tag, string wiki, string memo, bool finished = false)
            : base(title, tag)
        {
            Wiki = wiki;
            Memo = memo;
            Finished = finished;
        }

        public void FinalizeToDoItemData()
        {
            Finished = true;
        }
    }
}
