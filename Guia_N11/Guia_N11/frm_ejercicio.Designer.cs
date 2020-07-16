namespace Guia_N11
{
    partial class frm_ejercicio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_materia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_nota3 = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nota2 = new System.Windows.Forms.TextBox();
            this.txt_nota1 = new System.Windows.Forms.TextBox();
            this.tabla_datos = new Guna.UI.WinForms.GunaDataGridView();
            this.idAlumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMateriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guiaN11DataSet = new Guia_N11.GuiaN11DataSet();
            this.txt_promedio = new System.Windows.Forms.TextBox();
            this.txt_resultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.alumnoTableAdapter = new Guia_N11.GuiaN11DataSetTableAdapters.AlumnoTableAdapter();
            this.btn_eliminar = new Guna.UI.WinForms.GunaGradientButton();
            this.btn_modificar = new Guna.UI.WinForms.GunaGradientButton();
            this.btn_agregar = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guiaN11DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(274, 3);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(268, 37);
            this.gunaLabel1.TabIndex = 22;
            this.gunaLabel1.Text = "Registro de alumnos";
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gunaGroupBox2.BorderSize = 3;
            this.gunaGroupBox2.Controls.Add(this.label1);
            this.gunaGroupBox2.Controls.Add(this.txt_materia);
            this.gunaGroupBox2.Controls.Add(this.label10);
            this.gunaGroupBox2.Controls.Add(this.label9);
            this.gunaGroupBox2.Controls.Add(this.label8);
            this.gunaGroupBox2.Controls.Add(this.label7);
            this.gunaGroupBox2.Controls.Add(this.label6);
            this.gunaGroupBox2.Controls.Add(this.label5);
            this.gunaGroupBox2.Controls.Add(this.txt_id);
            this.gunaGroupBox2.Controls.Add(this.txt_nombre);
            this.gunaGroupBox2.Controls.Add(this.txt_nota3);
            this.gunaGroupBox2.Controls.Add(this.txt_apellido);
            this.gunaGroupBox2.Controls.Add(this.txt_nota2);
            this.gunaGroupBox2.Controls.Add(this.txt_nota1);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gunaGroupBox2.Location = new System.Drawing.Point(11, 54);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(743, 133);
            this.gunaGroupBox2.TabIndex = 18;
            this.gunaGroupBox2.Text = "Datos Alumno";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(300, 5);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Materia:";
            // 
            // txt_materia
            // 
            this.txt_materia.Location = new System.Drawing.Point(92, 85);
            this.txt_materia.Name = "txt_materia";
            this.txt_materia.ShortcutsEnabled = false;
            this.txt_materia.Size = new System.Drawing.Size(157, 26);
            this.txt_materia.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(561, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Nota 3:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(410, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nota 2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(264, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Nota 1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(399, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Apellido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID Alumno:";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(112, 36);
            this.txt_id.Name = "txt_id";
            this.txt_id.ReadOnly = true;
            this.txt_id.Size = new System.Drawing.Size(39, 26);
            this.txt_id.TabIndex = 6;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(237, 36);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.ShortcutsEnabled = false;
            this.txt_nombre.Size = new System.Drawing.Size(157, 26);
            this.txt_nombre.TabIndex = 7;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // txt_nota3
            // 
            this.txt_nota3.Location = new System.Drawing.Point(634, 85);
            this.txt_nota3.Name = "txt_nota3";
            this.txt_nota3.ShortcutsEnabled = false;
            this.txt_nota3.Size = new System.Drawing.Size(46, 26);
            this.txt_nota3.TabIndex = 11;
            this.txt_nota3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_nota3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nota3_KeyPress);
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(483, 36);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.ShortcutsEnabled = false;
            this.txt_apellido.Size = new System.Drawing.Size(157, 26);
            this.txt_apellido.TabIndex = 8;
            this.txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido_KeyPress);
            // 
            // txt_nota2
            // 
            this.txt_nota2.Location = new System.Drawing.Point(483, 85);
            this.txt_nota2.Name = "txt_nota2";
            this.txt_nota2.ShortcutsEnabled = false;
            this.txt_nota2.Size = new System.Drawing.Size(46, 26);
            this.txt_nota2.TabIndex = 10;
            this.txt_nota2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_nota2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nota2_KeyPress);
            // 
            // txt_nota1
            // 
            this.txt_nota1.Location = new System.Drawing.Point(337, 85);
            this.txt_nota1.Name = "txt_nota1";
            this.txt_nota1.ShortcutsEnabled = false;
            this.txt_nota1.Size = new System.Drawing.Size(46, 26);
            this.txt_nota1.TabIndex = 9;
            this.txt_nota1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_nota1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nota1_KeyPress);
            // 
            // tabla_datos
            // 
            this.tabla_datos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.tabla_datos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla_datos.AutoGenerateColumns = false;
            this.tabla_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tabla_datos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tabla_datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla_datos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tabla_datos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabla_datos.ColumnHeadersHeight = 30;
            this.tabla_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlumnoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.nombreMateriaDataGridViewTextBoxColumn,
            this.nota1DataGridViewTextBoxColumn,
            this.nota2DataGridViewTextBoxColumn,
            this.nota3DataGridViewTextBoxColumn});
            this.tabla_datos.DataSource = this.alumnoBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla_datos.DefaultCellStyle = dataGridViewCellStyle3;
            this.tabla_datos.EnableHeadersVisualStyles = false;
            this.tabla_datos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tabla_datos.Location = new System.Drawing.Point(3, 241);
            this.tabla_datos.Name = "tabla_datos";
            this.tabla_datos.ReadOnly = true;
            this.tabla_datos.RowHeadersVisible = false;
            this.tabla_datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_datos.Size = new System.Drawing.Size(600, 281);
            this.tabla_datos.TabIndex = 23;
            this.tabla_datos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.tabla_datos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tabla_datos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tabla_datos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tabla_datos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tabla_datos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tabla_datos.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.tabla_datos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tabla_datos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tabla_datos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tabla_datos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tabla_datos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tabla_datos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tabla_datos.ThemeStyle.HeaderStyle.Height = 30;
            this.tabla_datos.ThemeStyle.ReadOnly = true;
            this.tabla_datos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.tabla_datos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tabla_datos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tabla_datos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tabla_datos.ThemeStyle.RowsStyle.Height = 22;
            this.tabla_datos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tabla_datos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.tabla_datos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_datos_CellContentClick);
            // 
            // idAlumnoDataGridViewTextBoxColumn
            // 
            this.idAlumnoDataGridViewTextBoxColumn.DataPropertyName = "Id_Alumno";
            this.idAlumnoDataGridViewTextBoxColumn.HeaderText = "Id_Alumno";
            this.idAlumnoDataGridViewTextBoxColumn.Name = "idAlumnoDataGridViewTextBoxColumn";
            this.idAlumnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAlumnoDataGridViewTextBoxColumn.Width = 98;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 82;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apellidoDataGridViewTextBoxColumn.Width = 81;
            // 
            // nombreMateriaDataGridViewTextBoxColumn
            // 
            this.nombreMateriaDataGridViewTextBoxColumn.DataPropertyName = "nombreMateria";
            this.nombreMateriaDataGridViewTextBoxColumn.HeaderText = "nombreMateria";
            this.nombreMateriaDataGridViewTextBoxColumn.Name = "nombreMateriaDataGridViewTextBoxColumn";
            this.nombreMateriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreMateriaDataGridViewTextBoxColumn.Width = 127;
            // 
            // nota1DataGridViewTextBoxColumn
            // 
            this.nota1DataGridViewTextBoxColumn.DataPropertyName = "Nota1";
            this.nota1DataGridViewTextBoxColumn.HeaderText = "Nota1";
            this.nota1DataGridViewTextBoxColumn.Name = "nota1DataGridViewTextBoxColumn";
            this.nota1DataGridViewTextBoxColumn.ReadOnly = true;
            this.nota1DataGridViewTextBoxColumn.Width = 70;
            // 
            // nota2DataGridViewTextBoxColumn
            // 
            this.nota2DataGridViewTextBoxColumn.DataPropertyName = "Nota2";
            this.nota2DataGridViewTextBoxColumn.HeaderText = "Nota2";
            this.nota2DataGridViewTextBoxColumn.Name = "nota2DataGridViewTextBoxColumn";
            this.nota2DataGridViewTextBoxColumn.ReadOnly = true;
            this.nota2DataGridViewTextBoxColumn.Width = 70;
            // 
            // nota3DataGridViewTextBoxColumn
            // 
            this.nota3DataGridViewTextBoxColumn.DataPropertyName = "Nota3";
            this.nota3DataGridViewTextBoxColumn.HeaderText = "Nota3";
            this.nota3DataGridViewTextBoxColumn.Name = "nota3DataGridViewTextBoxColumn";
            this.nota3DataGridViewTextBoxColumn.ReadOnly = true;
            this.nota3DataGridViewTextBoxColumn.Width = 70;
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataMember = "Alumno";
            this.alumnoBindingSource.DataSource = this.guiaN11DataSet;
            // 
            // guiaN11DataSet
            // 
            this.guiaN11DataSet.DataSetName = "GuiaN11DataSet";
            this.guiaN11DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_promedio
            // 
            this.txt_promedio.Font = new System.Drawing.Font("Franklin Gothic Demi", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_promedio.Location = new System.Drawing.Point(654, 320);
            this.txt_promedio.Name = "txt_promedio";
            this.txt_promedio.ReadOnly = true;
            this.txt_promedio.Size = new System.Drawing.Size(55, 38);
            this.txt_promedio.TabIndex = 24;
            this.txt_promedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_resultado
            // 
            this.txt_resultado.Font = new System.Drawing.Font("Franklin Gothic Demi", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_resultado.Location = new System.Drawing.Point(609, 406);
            this.txt_resultado.Name = "txt_resultado";
            this.txt_resultado.ReadOnly = true;
            this.txt_resultado.Size = new System.Drawing.Size(147, 31);
            this.txt_resultado.TabIndex = 25;
            this.txt_resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(632, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Promedio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(609, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Resultado final";
            // 
            // alumnoTableAdapter
            // 
            this.alumnoTableAdapter.ClearBeforeFill = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.AnimationHoverSpeed = 0.07F;
            this.btn_eliminar.AnimationSpeed = 0.03F;
            this.btn_eliminar.BaseColor1 = System.Drawing.Color.MediumBlue;
            this.btn_eliminar.BaseColor2 = System.Drawing.Color.DimGray;
            this.btn_eliminar.BorderColor = System.Drawing.Color.Black;
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_eliminar.FocusedColor = System.Drawing.Color.Empty;
            this.btn_eliminar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Image = global::Guia_N11.Properties.Resources._49612___delete_male;
            this.btn_eliminar.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_eliminar.Location = new System.Drawing.Point(500, 193);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_eliminar.OnHoverBaseColor2 = System.Drawing.Color.Gray;
            this.btn_eliminar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_eliminar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_eliminar.OnHoverImage = null;
            this.btn_eliminar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_eliminar.Size = new System.Drawing.Size(160, 42);
            this.btn_eliminar.TabIndex = 21;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_modificar
            // 
            this.btn_modificar.AnimationHoverSpeed = 0.07F;
            this.btn_modificar.AnimationSpeed = 0.03F;
            this.btn_modificar.BaseColor1 = System.Drawing.Color.MediumBlue;
            this.btn_modificar.BaseColor2 = System.Drawing.Color.DimGray;
            this.btn_modificar.BorderColor = System.Drawing.Color.Black;
            this.btn_modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modificar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_modificar.FocusedColor = System.Drawing.Color.Empty;
            this.btn_modificar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.ForeColor = System.Drawing.Color.White;
            this.btn_modificar.Image = global::Guia_N11.Properties.Resources._49585___human_male_user;
            this.btn_modificar.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_modificar.Location = new System.Drawing.Point(305, 193);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_modificar.OnHoverBaseColor2 = System.Drawing.Color.Gray;
            this.btn_modificar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_modificar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_modificar.OnHoverImage = null;
            this.btn_modificar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_modificar.Size = new System.Drawing.Size(160, 42);
            this.btn_modificar.TabIndex = 20;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.AnimationHoverSpeed = 0.07F;
            this.btn_agregar.AnimationSpeed = 0.03F;
            this.btn_agregar.BaseColor1 = System.Drawing.Color.MediumBlue;
            this.btn_agregar.BaseColor2 = System.Drawing.Color.DimGray;
            this.btn_agregar.BorderColor = System.Drawing.Color.Black;
            this.btn_agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_agregar.FocusedColor = System.Drawing.Color.Empty;
            this.btn_agregar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Image = global::Guia_N11.Properties.Resources._49575___accept_male_user;
            this.btn_agregar.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_agregar.Location = new System.Drawing.Point(105, 193);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_agregar.OnHoverBaseColor2 = System.Drawing.Color.Gray;
            this.btn_agregar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_agregar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_agregar.OnHoverImage = null;
            this.btn_agregar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_agregar.Size = new System.Drawing.Size(160, 42);
            this.btn_agregar.TabIndex = 19;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // frm_ejercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(764, 534);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_resultado);
            this.Controls.Add(this.txt_promedio);
            this.Controls.Add(this.tabla_datos);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.gunaGroupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_ejercicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ejercicio";
            this.Load += new System.EventHandler(this.frm_ejercicio_Load);
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guiaN11DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaGradientButton btn_eliminar;
        private Guna.UI.WinForms.GunaGradientButton btn_modificar;
        private Guna.UI.WinForms.GunaGradientButton btn_agregar;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_nota3;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nota2;
        private System.Windows.Forms.TextBox txt_nota1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_materia;
        private Guna.UI.WinForms.GunaDataGridView tabla_datos;
        private GuiaN11DataSet guiaN11DataSet;
        private System.Windows.Forms.BindingSource alumnoBindingSource;
        private GuiaN11DataSetTableAdapters.AlumnoTableAdapter alumnoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota3DataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txt_promedio;
        private System.Windows.Forms.TextBox txt_resultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}