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

        /// <summary>
        /// OKボタン押下イベントのリスナーメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OkButton_Click(object sender, System.EventArgs e)
        {
            WaitSearchWordsTaskCompletionSource?.TrySetResult(SearchWordsTextBox.Text);
        }

        /// <summary>
        /// Cancelボタン押下イベントのリスナーメソッド
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            WaitSearchWordsTaskCompletionSource?.TrySetCanceled();
        }

        /// <summary>
        /// いずれかのボタンが押下されるorフォームが閉じられるまで
        /// 非同期でユーザー入力を待ち受けるメソッド
        /// </summary>
        /// <returns>ユーザー入力された検索文字列</returns>
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

        private void SearchWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            WaitSearchWordsTaskCompletionSource?.TrySetCanceled();
        }
    }
}
