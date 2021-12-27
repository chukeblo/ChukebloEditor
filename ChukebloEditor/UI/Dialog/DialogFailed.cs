namespace ChukebloEditor.UI
{
    public class DialogFailed : DialogResult
    {
    }

    public class DialogFailed<TResult> : DialogResult<TResult>
    {
        public DialogFailed(TResult result) : base(result)
        {
        }
    }
}
