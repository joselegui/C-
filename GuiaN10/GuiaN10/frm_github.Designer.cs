namespace GuiaN10
{
    partial class frm_github
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
            this.lbl_github = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_github
            // 
            this.lbl_github.AutoSize = true;
            this.lbl_github.BackColor = System.Drawing.Color.Transparent;
            this.lbl_github.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_github.LinkColor = System.Drawing.Color.Black;
            this.lbl_github.Location = new System.Drawing.Point(152, 134);
            this.lbl_github.Name = "lbl_github";
            this.lbl_github.Size = new System.Drawing.Size(94, 31);
            this.lbl_github.TabIndex = 1;
            this.lbl_github.TabStop = true;
            this.lbl_github.Text = "github";
            this.lbl_github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_github_LinkClicked);
            // 
            // frm_github
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GuiaN10.Properties.Resources.GitHub;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(398, 174);
            this.Controls.Add(this.lbl_github);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_github";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_github";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lbl_github;
    }
}