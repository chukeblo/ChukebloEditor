using ChukebloEditor.CommandReceiver;
using System;

namespace ChukebloEditor.Command
{
    public static class CommandFactory
    {
        public static ICommand GenerateCommand(CommandType type, object parameter)
        {
            ICommandReceiver receiver;
            switch (type)
            {
                case CommandType.Save:
                    receiver = ReceiverFactory.GenerateReceiver(ReceiverType.Save, parameter);
                    return new SaveCommand(receiver);
                case CommandType.Find:
                    receiver = ReceiverFactory.GenerateReceiver(ReceiverType.Find, parameter);
                    return new FindCommand(receiver);
                default:
                    throw new InvalidOperationException("not supported command type");
            }
        }
    }
}
