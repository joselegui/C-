namespace Caracteres
{
    partial class Form1
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txt_textos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAyuda = new System.Windows.Forms.Label();
            this.labelMinimizar = new System.Windows.Forms.Label();
            this.labelExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Location = new System.Drawing.Point(94, 103);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(147, 46);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txt_textos
            // 
            this.txt_textos.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_textos.Location = new System.Drawing.Point(35, 54);
            this.txt_textos.Margin = new System.Windows.Forms.Padding(2);
            this.txt_textos.Multiline = true;
            this.txt_textos.Name = "txt_textos";
            this.txt_textos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_textos.Size = new System.Drawing.Size(265, 45);
            this.txt_textos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingrese el texto que desee";
            // 
            // labelAyuda
            // 
            this.labelAyuda.AutoSize = true;
            this.labelAyuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAyuda.Location = new System.Drawing.Point(313, 139);
            this.labelAyuda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAyuda.Name = "labelAyuda";
            this.labelAyuda.Size = new System.Drawing.Size(19, 19);
            this.labelAyuda.TabIndex = 3;
            this.labelAyuda.Text = "?";
            this.labelAyuda.Click += new System.EventHandler(this.labelAyuda_Click);
            // 
            // labelMinimizar
            // 
            this.labelMinimizar.AutoSize = true;
            this.labelMinimizar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinimizar.Location = new System.Drawing.Point(290, 2);
            this.labelMinimizar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMinimizar.Name = "labelMinimizar";
            this.labelMinimizar.Size = new System.Drawing.Size(16, 19);
            this.labelMinimizar.TabIndex = 4;
            this.labelMinimizar.Text = "-";
            this.labelMinimizar.Click += new System.EventHandler(this.labelMinimizar_Click);
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExit.Location = new System.Drawing.Point(311, 2);
            this.labelExit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(20, 19);
            this.labelExit.TabIndex = 5;
            this.labelExit.Text = "X";
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(335, 159);
            this.Controls.Add(this.labelExit);
            this.Controls.Add(this.labelMinimizar);
            this.Controls.Add(this.labelAyuda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_textos);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caracteres";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txt_textos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAyuda;
        private System.Windows.Forms.Label labelMinimizar;
        private System.Windows.Forms.Label labelExit;
    }
}

