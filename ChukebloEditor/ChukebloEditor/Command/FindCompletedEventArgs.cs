using System;
using System.Collections.Generic;

namespace ChukebloEditor.Command
{
    public class FindCompletedEventArgs : EventArgs
    {
        public List<int> IndexList { get; set; }
        public int SearchWordsLength { get; set; }

        public FindCompletedEventArgs(List<int> indexList, int searchWordsLength)
        {
            IndexList = indexList;
            SearchWordsLength = searchWordsLength;
        }
    }
}
