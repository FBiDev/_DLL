namespace _DLL
{
    partial class WebView2Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wbvMain = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.pnlWebView = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.wbvMain)).BeginInit();
            this.pnlWebView.SuspendLayout();
            this.SuspendLayout();
            // 
            // wbvMain
            // 
            this.wbvMain.CreationProperties = null;
            this.wbvMain.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wbvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbvMain.Location = new System.Drawing.Point(5, 5);
            this.wbvMain.Name = "wbvMain";
            this.wbvMain.Size = new System.Drawing.Size(585, 423);
            this.wbvMain.TabIndex = 0;
            this.wbvMain.ZoomFactor = 1D;
            // 
            // pnlWebView
            // 
            this.pnlWebView.AutoScroll = true;
            this.pnlWebView.Controls.Add(this.wbvMain);
            this.pnlWebView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWebView.Location = new System.Drawing.Point(0, 0);
            this.pnlWebView.Name = "pnlWebView";
            this.pnlWebView.Padding = new System.Windows.Forms.Padding(5);
            this.pnlWebView.Size = new System.Drawing.Size(595, 433);
            this.pnlWebView.TabIndex = 1;
            // 
            // WebView2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 433);
            this.Controls.Add(this.pnlWebView);
            this.Name = "WebView2Form";
            this.Text = "WebView2";
            ((System.ComponentModel.ISupportInitialize)(this.wbvMain)).EndInit();
            this.pnlWebView.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 wbvMain;
        private System.Windows.Forms.Panel pnlWebView;
    }
}