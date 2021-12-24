namespace ChukebloEditor.Command
{
    public class FileIOParam
    {
        public string FileName { get; }
        public string Text { get; }

        public FileIOParam(string fileName, string text)
        {
            FileName = fileName;
            Text = text;
        }
    }
}
