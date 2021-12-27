using ChukebloEditor.CommandReceiver;

namespace ChukebloEditor.Command
{
    class OpenCommand : ICommand
    {
        private ICommandReceiver receiver;

        public OpenCommand(ICommandReceiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            receiver.ReceiveCommand();
        }
    }
}
