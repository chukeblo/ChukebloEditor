namespace ChukebloEditor.ManagementItemData
{
    public abstract class ManagementItemDataBase
    {
        public string Title { get; }
        public string Tag { get; }

        public ManagementItemDataBase(string title, string tag)
        {
            Title = title;
            Tag = tag;
        }
    }
}
