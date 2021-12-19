using ChukebloEditor.CommandReceiver;
using System;

namespace ChukebloEditor.Command
{
    public static class CommandFactory
    {
        public static ICommand GenerateCommand(CommandType type, object parameter)
        {
            switch (type)
            {
                case CommandType.Save:
                    var receiver = ReceiverFactory.GenerateReceiver(ReceiverType.Save, parameter);
                    return new SaveCommand(receiver);
                default:
                    throw new InvalidOperationException("not supported command type");
            }
        }
    }
}
