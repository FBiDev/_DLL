using System;
using System.IO;
using System.Windows.Forms;

namespace _DLL
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Directory.Delete("_DLL.exe.WebView2", true);
        }

        private void btnWebView2_Click(object sender, EventArgs e)
        {
            var f = new WebView2Form();
            f.ShowDialog();
        }
    }
}