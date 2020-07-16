namespace Ejercicio5_2
{
    partial class frm_principal
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
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_Minimizar = new System.Windows.Forms.Button();
            this.btn_Help = new Guna.UI.WinForms.GunaGradientButton();
            this.lbl_Siguiente = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cerrar.FlatAppearance.BorderSize = 2;
            this.btn_Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Cerrar.Location = new System.Drawing.Point(874, 0);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(28, 28);
            this.btn_Cerrar.TabIndex = 0;
            this.btn_Cerrar.Text = "X";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Minimizar
            // 
            this.btn_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Minimizar.FlatAppearance.BorderSize = 2;
            this.btn_Minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimizar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Minimizar.Location = new System.Drawing.Point(840, 0);
            this.btn_Minimizar.Name = "btn_Minimizar";
            this.btn_Minimizar.Size = new System.Drawing.Size(28, 28);
            this.btn_Minimizar.TabIndex = 1;
            this.btn_Minimizar.Text = "-";
            this.btn_Minimizar.UseVisualStyleBackColor = false;
            this.btn_Minimizar.Click += new System.EventHandler(this.btn_Minimizar_Click);
            // 
            // btn_Help
            // 
            this.btn_Help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Help.AnimationHoverSpeed = 0.07F;
            this.btn_Help.AnimationSpeed = 0.03F;
            this.btn_Help.BaseColor1 = System.Drawing.Color.SeaGreen;
            this.btn_Help.BaseColor2 = System.Drawing.Color.MediumSeaGreen;
            this.btn_Help.BorderColor = System.Drawing.Color.Black;
            this.btn_Help.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Help.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Help.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Help.ForeColor = System.Drawing.Color.White;
            this.btn_Help.Image = null;
            this.btn_Help.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Help.Location = new System.Drawing.Point(854, 452);
            this.btn_Help.Name = "btn_Help";
            this.btn_Help.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_Help.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_Help.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Help.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Help.OnHoverImage = null;
            this.btn_Help.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Help.Size = new System.Drawing.Size(48, 40);
            this.btn_Help.TabIndex = 6;
            this.btn_Help.Text = "?";
            this.btn_Help.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Help.Click += new System.EventHandler(this.btn_Help_Click);
            // 
            // lbl_Siguiente
            // 
            this.lbl_Siguiente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Siguiente.AutoSize = true;
            this.lbl_Siguiente.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Siguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Siguiente.Font = new System.Drawing.Font("Arial", 39.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Siguiente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbl_Siguiente.Location = new System.Drawing.Point(267, 258);
            this.lbl_Siguiente.Name = "lbl_Siguiente";
            this.lbl_Siguiente.Size = new System.Drawing.Size(639, 60);
            this.lbl_Siguiente.TabIndex = 7;
            this.lbl_Siguiente.Text = "Verduleria  ISFD y TN°93";
            this.lbl_Siguiente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Siguiente.Click += new System.EventHandler(this.lbl_Siguiente_Click);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Ejercicio5_2.Properties.Resources.GULLON_07_ARTICLE_frutas_verduras_verano_web;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(906, 495);
            this.Controls.Add(this.lbl_Siguiente);
            this.Controls.Add(this.btn_Help);
            this.Controls.Add(this.btn_Minimizar);
            this.Controls.Add(this.btn_Cerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_Minimizar;
        private Guna.UI.WinForms.GunaGradientButton btn_Help;
        private Guna.UI.WinForms.GunaLabel lbl_Siguiente;
    }
}

