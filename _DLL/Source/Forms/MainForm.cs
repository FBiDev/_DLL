using System;
using System.Windows.Forms;

namespace _DLL
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var a = 0;
            var b = 3 / a;
        }

        private void btnWebView2_Click(object sender, EventArgs e)
        {
            var f = new WebView2Form();
            f.ShowDialog();
        }
    }
}