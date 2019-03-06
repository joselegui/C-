namespace Boleta_de_pago
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.texRenta = new System.Windows.Forms.TextBox();
            this.texFonavi = new System.Windows.Forms.TextBox();
            this.texAFP = new System.Windows.Forms.TextBox();
            this.checkAFP = new System.Windows.Forms.CheckBox();
            this.checkFonavi = new System.Windows.Forms.CheckBox();
            this.checkRenta = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioNocturno = new System.Windows.Forms.RadioButton();
            this.radioDiurno = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.texSueldoB = new System.Windows.Forms.TextBox();
            this.texHoraExtra = new System.Windows.Forms.TextBox();
            this.texPagoHExtra = new System.Windows.Forms.TextBox();
            this.aceptar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.texSueldoNeto = new System.Windows.Forms.TextBox();
            this.limpiar = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.texRenta);
            this.groupBox1.Controls.Add(this.texFonavi);
            this.groupBox1.Controls.Add(this.texAFP);
            this.groupBox1.Controls.Add(this.checkAFP);
            this.groupBox1.Controls.Add(this.checkFonavi);
            this.groupBox1.Controls.Add(this.checkRenta);
            this.groupBox1.Location = new System.Drawing.Point(13, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 149);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Descuentos";
            // 
            // texRenta
            // 
            this.texRenta.Location = new System.Drawing.Point(85, 32);
            this.texRenta.Name = "texRenta";
            this.texRenta.Size = new System.Drawing.Size(100, 22);
            this.texRenta.TabIndex = 10;
            this.texRenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // texFonavi
            // 
            this.texFonavi.Location = new System.Drawing.Point(85, 66);
            this.texFonavi.Name = "texFonavi";
            this.texFonavi.Size = new System.Drawing.Size(100, 22);
            this.texFonavi.TabIndex = 11;
            this.texFonavi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // texAFP
            // 
            this.texAFP.Location = new System.Drawing.Point(85, 104);
            this.texAFP.Name = "texAFP";
            this.texAFP.Size = new System.Drawing.Size(100, 22);
            this.texAFP.TabIndex = 12;
            this.texAFP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkAFP
            // 
            this.checkAFP.AutoSize = true;
            this.checkAFP.Location = new System.Drawing.Point(4, 104);
            this.checkAFP.Name = "checkAFP";
            this.checkAFP.Size = new System.Drawing.Size(56, 20);
            this.checkAFP.TabIndex = 2;
            this.checkAFP.Text = "AFP";
            this.checkAFP.UseVisualStyleBackColor = true;
            // 
            // checkFonavi
            // 
            this.checkFonavi.AutoSize = true;
            this.checkFonavi.Location = new System.Drawing.Point(4, 68);
            this.checkFonavi.Name = "checkFonavi";
            this.checkFonavi.Size = new System.Drawing.Size(74, 20);
            this.checkFonavi.TabIndex = 1;
            this.checkFonavi.Text = "Fonavi";
            this.checkFonavi.UseVisualStyleBackColor = true;
            // 
            // checkRenta
            // 
            this.checkRenta.AutoSize = true;
            this.checkRenta.Location = new System.Drawing.Point(5, 32);
            this.checkRenta.Name = "checkRenta";
            this.checkRenta.Size = new System.Drawing.Size(68, 20);
            this.checkRenta.TabIndex = 0;
            this.checkRenta.Text = "Renta";
            this.checkRenta.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioNocturno);
            this.groupBox2.Controls.Add(this.radioDiurno);
            this.groupBox2.Location = new System.Drawing.Point(295, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 131);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Turno";
            // 
            // radioNocturno
            // 
            this.radioNocturno.AutoSize = true;
            this.radioNocturno.Location = new System.Drawing.Point(31, 81);
            this.radioNocturno.Name = "radioNocturno";
            this.radioNocturno.Size = new System.Drawing.Size(88, 20);
            this.radioNocturno.TabIndex = 1;
            this.radioNocturno.TabStop = true;
            this.radioNocturno.Text = "Nocturno";
            this.radioNocturno.UseVisualStyleBackColor = true;
            // 
            // radioDiurno
            // 
            this.radioDiurno.AutoSize = true;
            this.radioDiurno.Location = new System.Drawing.Point(31, 35);
            this.radioDiurno.Name = "radioDiurno";
            this.radioDiurno.Size = new System.Drawing.Size(71, 20);
            this.radioDiurno.TabIndex = 0;
            this.radioDiurno.TabStop = true;
            this.radioDiurno.Text = "Diurno";
            this.radioDiurno.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Trabajador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sueldo Basico $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Horas Extras:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pago por horas extras $";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(106, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(375, 26);
            this.textBox1.TabIndex = 6;
            // 
            // texSueldoB
            // 
            this.texSueldoB.Location = new System.Drawing.Point(189, 81);
            this.texSueldoB.Name = "texSueldoB";
            this.texSueldoB.Size = new System.Drawing.Size(100, 22);
            this.texSueldoB.TabIndex = 7;
            this.texSueldoB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // texHoraExtra
            // 
            this.texHoraExtra.Location = new System.Drawing.Point(189, 140);
            this.texHoraExtra.Name = "texHoraExtra";
            this.texHoraExtra.Size = new System.Drawing.Size(100, 22);
            this.texHoraExtra.TabIndex = 8;
            this.texHoraExtra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // texPagoHExtra
            // 
            this.texPagoHExtra.Location = new System.Drawing.Point(189, 197);
            this.texPagoHExtra.Name = "texPagoHExtra";
            this.texPagoHExtra.Size = new System.Drawing.Size(100, 22);
            this.texPagoHExtra.TabIndex = 9;
            this.texPagoHExtra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(295, 233);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(118, 46);
            this.aceptar.TabIndex = 10;
            this.aceptar.Text = "&Aceptar";
            this.aceptar.UseVisualStyleBackColor = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sueldo neto $";
            // 
            // texSueldoNeto
            // 
            this.texSueldoNeto.Location = new System.Drawing.Point(119, 416);
            this.texSueldoNeto.Name = "texSueldoNeto";
            this.texSueldoNeto.Size = new System.Drawing.Size(100, 22);
            this.texSueldoNeto.TabIndex = 13;
            this.texSueldoNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(295, 290);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(118, 46);
            this.limpiar.TabIndex = 14;
            this.limpiar.Text = "&Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(295, 351);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(118, 46);
            this.salir.TabIndex = 15;
            this.salir.Text = "&Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(492, 491);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.limpiar);
            this.Controls.Add(this.texSueldoNeto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.texPagoHExtra);
            this.Controls.Add(this.texHoraExtra);
            this.Controls.Add(this.texSueldoB);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boleta de pago";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox texSueldoB;
        private System.Windows.Forms.TextBox texHoraExtra;
        private System.Windows.Forms.TextBox texPagoHExtra;
        private System.Windows.Forms.RadioButton radioNocturno;
        private System.Windows.Forms.RadioButton radioDiurno;
        private System.Windows.Forms.CheckBox checkAFP;
        private System.Windows.Forms.CheckBox checkFonavi;
        private System.Windows.Forms.CheckBox checkRenta;
        private System.Windows.Forms.TextBox texRenta;
        private System.Windows.Forms.TextBox texFonavi;
        private System.Windows.Forms.TextBox texAFP;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox texSueldoNeto;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button salir;
    }
}

