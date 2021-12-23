using ChukebloEditor.CommandReceiver;

namespace ChukebloEditor.Command
{
    public class SaveCommand : ICommand
    {
        
        private ICommandReceiver _receiver;


        public SaveCommand(ICommandReceiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.ReceiveCommand();
        }
    }
}
