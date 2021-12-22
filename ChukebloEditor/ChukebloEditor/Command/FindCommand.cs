using ChukebloEditor.CommandReceiver;

namespace ChukebloEditor.Command
{
    class FindCommand : ICommand
    {
        private ICommandReceiver _receiver;

        public FindCommand(ICommandReceiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.ReceiveCommand();
        }
    }
}
