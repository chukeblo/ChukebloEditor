namespace ChukebloEditor.UI
{
    public abstract class DialogResult
    {
    }

    public abstract class DialogResult<TResult>
    {
        public TResult Result { get; }

        public DialogResult(TResult result)
        {
            Result = result;
        }
    }
}
