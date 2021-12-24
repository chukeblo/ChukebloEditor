using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ChukebloEditor.Command
{
    public class CommandInvoker
    {
        private static CommandInvoker instance = null;
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

        public void Run()
        {
            Execute();
        }

        public Task<bool> Execute()
        {
            var taskCompletionSource = new TaskCompletionSource<bool>();
            _cancellationTokenSource = new CancellationTokenSource();
            var cancellationToken = _cancellationTokenSource.Token;

            var task = Task.Run(() =>
            {
                while (true)
                {
                    if (cancellationToken.IsCancellationRequested)
                    {
                        break;
                    }
                    if (_commands.Count == 0)
                    {
                        continue;
                    }
                    var command = _commands.Dequeue();
                    command.Execute();
                }
            }, cancellationToken);

            return taskCompletionSource.Task;
        }

        public void Stop()
        {
            _cancellationTokenSource.Cancel();
        }
    }
}