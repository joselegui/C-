namespace GuiaN10
{
    partial class frm_ejercicio10_1
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbF = new System.Windows.Forms.RadioButton();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.listaPersonas = new System.Windows.Forms.ListBox();
            this.btn_contador = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_mujeres = new System.Windows.Forms.Label();
            this.lbl_barones = new System.Windows.Forms.Label();
            this.txt_edad = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(373, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(262, 25);
            this.label4.TabIndex = 61;
            this.label4.Text = "Ingresando lista de personas";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Location = new System.Drawing.Point(860, 180);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 43);
            this.btnAgregar.TabIndex = 60;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rbF);
            this.groupBox1.Controls.Add(this.rbM);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(872, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(123, 89);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rbF
            // 
            this.rbF.AutoSize = true;
            this.rbF.Location = new System.Drawing.Point(6, 25);
            this.rbF.Name = "rbF";
            this.rbF.Size = new System.Drawing.Size(71, 17);
            this.rbF.TabIndex = 7;
            this.rbF.Text = "Femenino";
            this.rbF.UseVisualStyleBackColor = true;
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Location = new System.Drawing.Point(6, 58);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(73, 17);
            this.rbM.TabIndex = 8;
            this.rbM.Text = "Masculino";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(559, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Edad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(559, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(559, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(559, 153);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(261, 26);
            this.txtApellido.TabIndex = 55;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(559, 98);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(261, 26);
            this.txtNombre.TabIndex = 54;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listaPersonas
            // 
            this.listaPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaPersonas.FormattingEnabled = true;
            this.listaPersonas.ItemHeight = 16;
            this.listaPersonas.Location = new System.Drawing.Point(12, 58);
            this.listaPersonas.Name = "listaPersonas";
            this.listaPersonas.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listaPersonas.Size = new System.Drawing.Size(515, 212);
            this.listaPersonas.TabIndex = 53;
            // 
            // btn_contador
            // 
            this.btn_contador.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_contador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_contador.Location = new System.Drawing.Point(860, 229);
            this.btn_contador.Name = "btn_contador";
            this.btn_contador.Size = new System.Drawing.Size(135, 43);
            this.btn_contador.TabIndex = 63;
            this.btn_contador.Text = "&Contar genero";
            this.btn_contador.UseVisualStyleBackColor = true;
            this.btn_contador.Click += new System.EventHandler(this.btn_contador_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.Location = new System.Drawing.Point(860, 278);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(135, 43);
            this.btn_eliminar.TabIndex = 64;
            this.btn_eliminar.Text = "&Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 24);
            this.label5.TabIndex = 65;
            this.label5.Text = "Cantidad de Mujeres: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 24);
            this.label6.TabIndex = 66;
            this.label6.Text = "Cantidad de Varones:";
            // 
            // lbl_mujeres
            // 
            this.lbl_mujeres.AutoSize = true;
            this.lbl_mujeres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mujeres.ForeColor = System.Drawing.Color.White;
            this.lbl_mujeres.Location = new System.Drawing.Point(233, 353);
            this.lbl_mujeres.Name = "lbl_mujeres";
            this.lbl_mujeres.Size = new System.Drawing.Size(21, 24);
            this.lbl_mujeres.TabIndex = 67;
            this.lbl_mujeres.Text = "0";
            // 
            // lbl_barones
            // 
            this.lbl_barones.AutoSize = true;
            this.lbl_barones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_barones.ForeColor = System.Drawing.Color.White;
            this.lbl_barones.Location = new System.Drawing.Point(233, 383);
            this.lbl_barones.Name = "lbl_barones";
            this.lbl_barones.Size = new System.Drawing.Size(21, 24);
            this.lbl_barones.TabIndex = 68;
            this.lbl_barones.Text = "0";
            // 
            // txt_edad
            // 
            this.txt_edad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_edad.Location = new System.Drawing.Point(562, 200);
            this.txt_edad.Name = "txt_edad";
            this.txt_edad.Size = new System.Drawing.Size(56, 26);
            this.txt_edad.TabIndex = 71;
            this.txt_edad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frm_ejercicio10_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1008, 477);
            this.Controls.Add(this.txt_edad);
            this.Controls.Add(this.lbl_barones);
            this.Controls.Add(this.lbl_mujeres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_contador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.listaPersonas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ejercicio10_1";
            this.Text = "frm_ejercicio10_1";
            this.Load += new System.EventHandler(this.frm_ejercicio10_1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbF;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ListBox listaPersonas;
        private System.Windows.Forms.Button btn_contador;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_mujeres;
        private System.Windows.Forms.Label lbl_barones;
        private System.Windows.Forms.TextBox txt_edad;
    }
}