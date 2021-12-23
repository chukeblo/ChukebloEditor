using ChukebloEditor.UI;
using System;
using System.Windows.Forms;

namespace ChukebloEditor
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MPMainWindow());
        }
    }
}
