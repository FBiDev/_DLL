namespace _DLL
{
    partial class MainForm
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
            this.btnWebView2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWebView2
            // 
            this.btnWebView2.Location = new System.Drawing.Point(13, 13);
            this.btnWebView2.Name = "btnWebView2";
            this.btnWebView2.Size = new System.Drawing.Size(75, 47);
            this.btnWebView2.TabIndex = 0;
            this.btnWebView2.Text = "WebView2";
            this.btnWebView2.UseVisualStyleBackColor = true;
            this.btnWebView2.Click += new System.EventHandler(this.btnWebView2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnWebView2);
            this.Name = "Form1";
            this.Text = "_DLL";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWebView2;
    }
}

