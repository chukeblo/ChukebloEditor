namespace ChukebloEditor.UI
{
    public class DialogSucceeded : DialogResult
    {
    }

    public class DialogSucceeded<TResult> : DialogResult<TResult>
    {
        public DialogSucceeded(TResult result) : base(result)
        {
        }
    }
}
