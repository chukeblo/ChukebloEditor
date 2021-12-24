using ChukebloEditor.Command;
using System.IO;

namespace ChukebloEditor.CommandReceiver
{
    public class SaveCommandReceiver : ICommandReceiver
    {
        private FileIOParam _saveFileParam;

        public SaveCommandReceiver(object parameter)
        {
            _saveFileParam = parameter as FileIOParam;
        }

        public void ReceiveCommand()
        {
            File.WriteAllText(_saveFileParam.FileName, _saveFileParam.Text);
        }
    }
}