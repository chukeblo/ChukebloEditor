using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ChukebloEditor.Command
{
    public class CommandInvoker
    {
        private static CommandInvoker instance = null;
        private bool isExcecuting = false;
        private Queue<ICommand> _commands;
        private CancellationTokenSource _cancellationTokenSource;

        private CommandInvoker()
        {
            _commands = new Queue<ICommand>();
            _cancellationTokenSource = null;
        }

        public static CommandInvoker Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CommandInvoker();
                }
                return instance;
            }
        }

        public void AddCommand(ICommand command)
        {
            _commands.Enqueue(command);
        }

        private void Execute()
        {
            isExcecuting = true;
            while (true)
            {
                if (_commands.Count == 0)
                {
                    break;
                }
                var command = _commands.Dequeue();
                command.Execute();
            }
            isExcecuting = false;
        }

        public void Stop()
        {
            _cancellationTokenSource.Cancel();
        }
    }
}