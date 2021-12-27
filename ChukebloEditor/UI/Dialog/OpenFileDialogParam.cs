namespace ChukebloEditor.UI
{
    public class OpenFileDialogParam : DialogParamBase
    {
        public string InitialDirectory { get; }
        public string Filter { get; }

        public OpenFileDialogParam(string title, string initialDirectory, string filter)
            : base(title)
        {
            InitialDirectory = initialDirectory;
            Filter = filter;
        }
    }
}
