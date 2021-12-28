namespace ChukebloEditor.UI
{
    public static class DialogConstants
    {
        public static class InitialDirectory
        {
            public static readonly string CDrive = "c:\\";
            public static readonly string WorkSpaceFolder = "c:\\.ChukebloTaskManager\\";
        }

        public static class Title
        {
            public static readonly string CreateNewFile = "新規ファイル作成";
            public static readonly string OpenFile = "開く";
            public static readonly string SaveAsNewFile = "新規ファイル保存";
            public static readonly string SaveFile = "保存";
        }

        public static class Filter
        {
            public static readonly string Text = "text files (*.txt)|*.txt";
            public static readonly string MarkDown = "markdown files (*.md)|*.md";
            public static readonly string Json = "json files (*.json)|*.json";
        }
    }
}
