using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChukebloEditor.UI
{
    public partial class SearchWindow : Form
    {
        private TaskCompletionSource<string> WaitSearchWordsTaskCompletionSource;

        public SearchWindow()
        {
            InitializeComponent();
        }

        public Task<string> WaitSearchWords()
        {
            WaitSearchWordsTaskCompletionSource = new TaskCompletionSource<string>();
            return WaitSearchWordsTaskCompletionSource.Task;
        }

        public void Clear()
        {
            SearchWordsTextBox.Text = string.Empty;
            WaitSearchWordsTaskCompletionSource = null;
        }

        private void OkButton_Click(object sender, System.EventArgs e)
        {
            WaitSearchWordsTaskCompletionSource?.TrySetResult(SearchWordsTextBox.Text);
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            WaitSearchWordsTaskCompletionSource?.TrySetCanceled();
        }

        private void SearchWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            WaitSearchWordsTaskCompletionSource?.TrySetCanceled();
        }
    }
}
