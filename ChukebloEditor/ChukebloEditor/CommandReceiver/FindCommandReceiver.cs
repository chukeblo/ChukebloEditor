using ChukebloEditor.Command;
using System;
using System.Collections.Generic;

namespace ChukebloEditor.CommandReceiver
{
    /// <summary>
    /// FindCommandを実行するクラス
    /// UIコントロールを行うためにFormクラスを継承
    /// </summary>
    public class FindCommandReceiver : ICommandReceiver
    {
        private SearchParam _searchParam;

        public FindCommandReceiver(object param)
        {
            _searchParam = param as SearchParam;
        }

        public void ReceiveCommand()
        {
            var list = new List<int>();
            int currentIndex = 0;
            var finalIndex = _searchParam.Text.Length - _searchParam.SearchWords.Length;
            while (currentIndex <= finalIndex)
            {
                currentIndex = _searchParam.Text.IndexOf(_searchParam.SearchWords, currentIndex);
                if (currentIndex == -1)
                {
                    break;
                }
                list.Add(currentIndex++);
            }
            var findCompletedEventArgs = new FindCompletedEventArgs(list, _searchParam.SearchWords.Length);
            _searchParam.Invoke(this, findCompletedEventArgs);
        }
    }
}
