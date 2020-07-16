namespace Guia_N11
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHora = new System.Windows.Forms.Panel();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.panelExit = new System.Windows.Forms.Panel();
            this.lbl_exit = new System.Windows.Forms.Label();
            this.panelInformacion = new System.Windows.Forms.Panel();
            this.lbl_informacion = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.Timer(this.components);
            this.Deslizar = new System.Windows.Forms.Timer(this.components);
            this.DeslizarPanel = new System.Windows.Forms.Timer(this.components);
            this.desPanelhora = new System.Windows.Forms.Timer(this.components);
            this.pic_estudiantes = new System.Windows.Forms.PictureBox();
            this.pic_personas = new System.Windows.Forms.PictureBox();
            this.pic_docentes = new System.Windows.Forms.PictureBox();
            this.panelHora.SuspendLayout();
            this.panelExit.SuspendLayout();
            this.panelInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_estudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_personas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_docentes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenidos";
            // 
            // panelHora
            // 
            this.panelHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(106)))));
            this.panelHora.Controls.Add(this.lbl_hora);
            this.panelHora.Location = new System.Drawing.Point(-1, 414);
            this.panelHora.Name = "panelHora";
            this.panelHora.Size = new System.Drawing.Size(350, 143);
            this.panelHora.TabIndex = 4;
            // 
            // lbl_hora
            // 
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Californian FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.Color.White;
            this.lbl_hora.Location = new System.Drawing.Point(212, 8);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(126, 37);
            this.lbl_hora.TabIndex = 5;
            this.lbl_hora.Text = "00:00 hs";
            // 
            // panelExit
            // 
            this.panelExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(212)))), ((int)(((byte)(200)))));
            this.panelExit.Controls.Add(this.lbl_exit);
            this.panelExit.Location = new System.Drawing.Point(0, 410);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(171, 97);
            this.panelExit.TabIndex = 5;
            // 
            // lbl_exit
            // 
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_exit.Font = new System.Drawing.Font("Californian FB", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exit.ForeColor = System.Drawing.Color.White;
            this.lbl_exit.Location = new System.Drawing.Point(42, 28);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(90, 37);
            this.lbl_exit.TabIndex = 7;
            this.lbl_exit.Text = "EXIT";
            this.lbl_exit.Click += new System.EventHandler(this.lbl_exit_Click);
            // 
            // panelInformacion
            // 
            this.panelInformacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(105)))), ((int)(((byte)(205)))));
            this.panelInformacion.Controls.Add(this.lbl_informacion);
            this.panelInformacion.Location = new System.Drawing.Point(171, 410);
            this.panelInformacion.Name = "panelInformacion";
            this.panelInformacion.Size = new System.Drawing.Size(178, 97);
            this.panelInformacion.TabIndex = 6;
            // 
            // lbl_informacion
            // 
            this.lbl_informacion.AutoSize = true;
            this.lbl_informacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_informacion.Font = new System.Drawing.Font("Californian FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_informacion.ForeColor = System.Drawing.Color.White;
            this.lbl_informacion.Location = new System.Drawing.Point(26, 36);
            this.lbl_informacion.Name = "lbl_informacion";
            this.lbl_informacion.Size = new System.Drawing.Size(127, 27);
            this.lbl_informacion.TabIndex = 7;
            this.lbl_informacion.Text = "Información";
            this.lbl_informacion.Click += new System.EventHandler(this.lbl_informacion_Click);
            // 
            // Hora
            // 
            this.Hora.Enabled = true;
            this.Hora.Tick += new System.EventHandler(this.Hora_Tick);
            // 
            // Deslizar
            // 
            this.Deslizar.Interval = 10;
            this.Deslizar.Tick += new System.EventHandler(this.Deslizar_Tick);
            // 
            // DeslizarPanel
            // 
            this.DeslizarPanel.Interval = 10;
            this.DeslizarPanel.Tick += new System.EventHandler(this.DeslizarPanel_Tick);
            // 
            // desPanelhora
            // 
            this.desPanelhora.Interval = 10;
            this.desPanelhora.Tick += new System.EventHandler(this.desPanelhora_Tick);
            // 
            // pic_estudiantes
            // 
            this.pic_estudiantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_estudiantes.Image = global::Guia_N11.Properties.Resources.Estudiante;
            this.pic_estudiantes.Location = new System.Drawing.Point(488, 74);
            this.pic_estudiantes.Name = "pic_estudiantes";
            this.pic_estudiantes.Size = new System.Drawing.Size(128, 122);
            this.pic_estudiantes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_estudiantes.TabIndex = 3;
            this.pic_estudiantes.TabStop = false;
            this.pic_estudiantes.Click += new System.EventHandler(this.pic_estudiantes_Click);
            // 
            // pic_personas
            // 
            this.pic_personas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pic_personas.Image = global::Guia_N11.Properties.Resources.Personas;
            this.pic_personas.Location = new System.Drawing.Point(346, 74);
            this.pic_personas.Name = "pic_personas";
            this.pic_personas.Size = new System.Drawing.Size(128, 122);
            this.pic_personas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_personas.TabIndex = 2;
            this.pic_personas.TabStop = false;
            this.pic_personas.Click += new System.EventHandler(this.pic_personas_Click);
            // 
            // pic_docentes
            // 
            this.pic_docentes.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pic_docentes.Image = global::Guia_N11.Properties.Resources.Docentes;
            this.pic_docentes.Location = new System.Drawing.Point(109, 74);
            this.pic_docentes.Name = "pic_docentes";
            this.pic_docentes.Size = new System.Drawing.Size(128, 122);
            this.pic_docentes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_docentes.TabIndex = 1;
            this.pic_docentes.TabStop = false;
            this.pic_docentes.Click += new System.EventHandler(this.pic_docentes_Click);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(347, 426);
            this.Controls.Add(this.pic_estudiantes);
            this.Controls.Add(this.panelExit);
            this.Controls.Add(this.panelInformacion);
            this.Controls.Add(this.pic_personas);
            this.Controls.Add(this.pic_docentes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelHora);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.panelHora.ResumeLayout(false);
            this.panelHora.PerformLayout();
            this.panelExit.ResumeLayout(false);
            this.panelExit.PerformLayout();
            this.panelInformacion.ResumeLayout(false);
            this.panelInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_estudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_personas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_docentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_docentes;
        private System.Windows.Forms.PictureBox pic_personas;
        private System.Windows.Forms.PictureBox pic_estudiantes;
        private System.Windows.Forms.Panel panelHora;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Panel panelInformacion;
        private System.Windows.Forms.Label lbl_informacion;
        private System.Windows.Forms.Panel panelExit;
        private System.Windows.Forms.Label lbl_exit;
        private System.Windows.Forms.Timer Hora;
        private System.Windows.Forms.Timer Deslizar;
        private System.Windows.Forms.Timer DeslizarPanel;
        private System.Windows.Forms.Timer desPanelhora;
    }
}

