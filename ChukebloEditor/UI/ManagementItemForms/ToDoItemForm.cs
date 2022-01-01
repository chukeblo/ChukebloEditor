using ChukebloEditor.ManagementItemData;
using System.Windows.Forms;

namespace ChukebloEditor.UI.ManagementItemForms
{
    public partial class ToDoItemForm : Form
    {
        public CloseStatus status = CloseStatus.None;
        public string Title { get; }
        private static readonly int MaxTextLength = 25;

        public ToDoItemForm(ToDoItemData data)
        {
            InitializeComponent();
            Title = data.Title;
            InitializeTextData(data);
        }

        private void InitializeTextData(ToDoItemData data)
        {
            this.txtTitle.Text = TrimTextData(data.Title);
            this.txtTag.Text = TrimTextData(data.Tag);
            this.txtMemo.Text = TrimTextData(data.Memo);
        }

        private string TrimTextData(string rawData)
        {
            if (rawData.Length <= MaxTextLength)
            {
                return rawData;
            }

            return $"{rawData.Substring(0, MaxTextLength - 3)}...";
        }

        private void chkbxFinished_CheckedChanged(object sender, System.EventArgs e)
        {
            status = CloseStatus.Finished;
            this.Close();
        }

        private void pctTrashbox_Click(object sender, System.EventArgs e)
        {
            status = CloseStatus.Deleted;
            this.Close();
        }

        private void pnlToDoItemWindowRange_Click(object sender, System.EventArgs e)
        {
            status = CloseStatus.Clicked;
            this.Close();
        }
    }
}
