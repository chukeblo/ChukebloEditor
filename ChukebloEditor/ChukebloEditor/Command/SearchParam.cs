using System;

namespace ChukebloEditor.Command
{
    public class SearchParam
    {
        public string Text { get; }
        public string SearchWords { get; }
        public event EventHandler<FindCompletedEventArgs> OnFindCompleted;

        public SearchParam(string text, string searchWords)
        {
            Text = text;
            SearchWords = searchWords;
        }

        public void Invoke(object sender, FindCompletedEventArgs e)
        {
            this.OnFindCompleted.Invoke(sender, e);
        }
    }
}
