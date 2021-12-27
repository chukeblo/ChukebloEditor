using ChukebloEditor.Command;

namespace ChukebloEditor.CommandReceiver
{
    public class OpenCommandReceiver : ICommandReceiver
    {
        public FileIOParam openParam { get; }

        public OpenCommandReceiver(object param)
        {
            this.openParam = param as FileIOParam;
        }

        public void ReceiveCommand()
        {
            throw new System.NotImplementedException();
        }
    }
}
