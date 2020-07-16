namespace GuiaN10
{
    partial class frm_datos10_2
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabla_datos = new Guna.UI.WinForms.GunaDataGridView();
            this.Nom_Mascotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomApe_Dueño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_nombresexo = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.combo_raza = new Guna.UI.WinForms.GunaComboBox();
            this.txt_nomMascota = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_observacion = new System.Windows.Forms.TextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.txt_ntelefono = new System.Windows.Forms.TextBox();
            this.txt_nomYape = new System.Windows.Forms.TextBox();
            this.btn_editar = new Guna.UI.WinForms.GunaGradientButton();
            this.btn_ingresar = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.rdb_Hembra = new System.Windows.Forms.RadioButton();
            this.rdb_macho = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_datos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla_datos
            // 
            this.tabla_datos.AllowUserToAddRows = false;
            this.tabla_datos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            this.tabla_datos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle23;
            this.tabla_datos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tabla_datos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tabla_datos.BackgroundColor = System.Drawing.Color.White;
            this.tabla_datos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabla_datos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tabla_datos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_datos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.tabla_datos.ColumnHeadersHeight = 21;
            this.tabla_datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom_Mascotas,
            this.Especie,
            this.Sexo,
            this.NomApe_Dueño,
            this.Telefono,
            this.Observaciones});
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle31.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla_datos.DefaultCellStyle = dataGridViewCellStyle31;
            this.tabla_datos.EnableHeadersVisualStyles = false;
            this.tabla_datos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tabla_datos.Location = new System.Drawing.Point(12, 207);
            this.tabla_datos.Name = "tabla_datos";
            this.tabla_datos.ReadOnly = true;
            dataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_datos.RowHeadersDefaultCellStyle = dataGridViewCellStyle32;
            this.tabla_datos.RowHeadersVisible = false;
            dataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.tabla_datos.RowsDefaultCellStyle = dataGridViewCellStyle33;
            this.tabla_datos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tabla_datos.Size = new System.Drawing.Size(643, 258);
            this.tabla_datos.TabIndex = 0;
            this.tabla_datos.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.tabla_datos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.tabla_datos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.tabla_datos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.tabla_datos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.tabla_datos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.tabla_datos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.tabla_datos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.tabla_datos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tabla_datos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tabla_datos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tabla_datos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.tabla_datos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.tabla_datos.ThemeStyle.HeaderStyle.Height = 21;
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
            // Nom_Mascotas
            // 
            this.Nom_Mascotas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Nom_Mascotas.DefaultCellStyle = dataGridViewCellStyle25;
            this.Nom_Mascotas.HeaderText = "Nom_Mascotas";
            this.Nom_Mascotas.Name = "Nom_Mascotas";
            this.Nom_Mascotas.ReadOnly = true;
            // 
            // Especie
            // 
            this.Especie.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Especie.DefaultCellStyle = dataGridViewCellStyle26;
            this.Especie.HeaderText = "Especie";
            this.Especie.Name = "Especie";
            this.Especie.ReadOnly = true;
            // 
            // Sexo
            // 
            this.Sexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Sexo.DefaultCellStyle = dataGridViewCellStyle27;
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            this.Sexo.ReadOnly = true;
            this.Sexo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NomApe_Dueño
            // 
            this.NomApe_Dueño.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.NomApe_Dueño.DefaultCellStyle = dataGridViewCellStyle28;
            this.NomApe_Dueño.HeaderText = "NomApe_Dueño";
            this.NomApe_Dueño.Name = "NomApe_Dueño";
            this.NomApe_Dueño.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Telefono.DefaultCellStyle = dataGridViewCellStyle29;
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Observaciones
            // 
            this.Observaciones.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Observaciones.DefaultCellStyle = dataGridViewCellStyle30;
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_macho);
            this.groupBox1.Controls.Add(this.rdb_Hembra);
            this.groupBox1.Controls.Add(this.lbl_nombresexo);
            this.groupBox1.Controls.Add(this.gunaLabel2);
            this.groupBox1.Controls.Add(this.gunaLabel1);
            this.groupBox1.Controls.Add(this.combo_raza);
            this.groupBox1.Controls.Add(this.txt_nomMascota);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(671, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 132);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Mascotas";
            // 
            // lbl_nombresexo
            // 
            this.lbl_nombresexo.AutoSize = true;
            this.lbl_nombresexo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombresexo.Location = new System.Drawing.Point(221, 66);
            this.lbl_nombresexo.Name = "lbl_nombresexo";
            this.lbl_nombresexo.Size = new System.Drawing.Size(35, 15);
            this.lbl_nombresexo.TabIndex = 19;
            this.lbl_nombresexo.Text = "Sexo";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(6, 79);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(48, 15);
            this.gunaLabel2.TabIndex = 18;
            this.gunaLabel2.Text = "Especie";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(6, 19);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(131, 15);
            this.gunaLabel1.TabIndex = 17;
            this.gunaLabel1.Text = "Nombre de la mascota";
            // 
            // combo_raza
            // 
            this.combo_raza.BackColor = System.Drawing.Color.Transparent;
            this.combo_raza.BaseColor = System.Drawing.Color.White;
            this.combo_raza.BorderColor = System.Drawing.Color.Silver;
            this.combo_raza.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.combo_raza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_raza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.combo_raza.FocusedColor = System.Drawing.Color.Empty;
            this.combo_raza.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.combo_raza.ForeColor = System.Drawing.Color.Black;
            this.combo_raza.FormattingEnabled = true;
            this.combo_raza.Location = new System.Drawing.Point(6, 97);
            this.combo_raza.Name = "combo_raza";
            this.combo_raza.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.combo_raza.OnHoverItemForeColor = System.Drawing.Color.White;
            this.combo_raza.Size = new System.Drawing.Size(121, 26);
            this.combo_raza.TabIndex = 1;
            this.combo_raza.MouseClick += new System.Windows.Forms.MouseEventHandler(this.combo_raza_MouseClick);
            // 
            // txt_nomMascota
            // 
            this.txt_nomMascota.Location = new System.Drawing.Point(6, 37);
            this.txt_nomMascota.Name = "txt_nomMascota";
            this.txt_nomMascota.Size = new System.Drawing.Size(312, 26);
            this.txt_nomMascota.TabIndex = 0;
            this.txt_nomMascota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nomMascota_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_observacion);
            this.groupBox2.Controls.Add(this.gunaLabel6);
            this.groupBox2.Controls.Add(this.gunaLabel5);
            this.groupBox2.Controls.Add(this.gunaLabel4);
            this.groupBox2.Controls.Add(this.txt_ntelefono);
            this.groupBox2.Controls.Add(this.txt_nomYape);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(671, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 261);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Dueños";
            // 
            // txt_observacion
            // 
            this.txt_observacion.Location = new System.Drawing.Point(6, 179);
            this.txt_observacion.Name = "txt_observacion";
            this.txt_observacion.Size = new System.Drawing.Size(312, 26);
            this.txt_observacion.TabIndex = 24;
            this.txt_observacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_observacion_KeyPress);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(6, 161);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(88, 15);
            this.gunaLabel6.TabIndex = 23;
            this.gunaLabel6.Text = "Observaciones";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(5, 101);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(89, 15);
            this.gunaLabel5.TabIndex = 22;
            this.gunaLabel5.Text = "N° de telefono";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(6, 44);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(158, 15);
            this.gunaLabel4.TabIndex = 20;
            this.gunaLabel4.Text = "Nombre y Apellido (Dueño)";
            // 
            // txt_ntelefono
            // 
            this.txt_ntelefono.Location = new System.Drawing.Point(6, 119);
            this.txt_ntelefono.Name = "txt_ntelefono";
            this.txt_ntelefono.Size = new System.Drawing.Size(312, 26);
            this.txt_ntelefono.TabIndex = 21;
            this.txt_ntelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ntelefono_KeyPress);
            // 
            // txt_nomYape
            // 
            this.txt_nomYape.Location = new System.Drawing.Point(6, 64);
            this.txt_nomYape.Name = "txt_nomYape";
            this.txt_nomYape.Size = new System.Drawing.Size(312, 26);
            this.txt_nomYape.TabIndex = 20;
            this.txt_nomYape.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nomYape_KeyPress);
            // 
            // btn_editar
            // 
            this.btn_editar.AnimationHoverSpeed = 0.07F;
            this.btn_editar.AnimationSpeed = 0.03F;
            this.btn_editar.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btn_editar.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btn_editar.BorderColor = System.Drawing.Color.Black;
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_editar.FocusedColor = System.Drawing.Color.Empty;
            this.btn_editar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Image = global::GuiaN10.Properties.Resources.descarga__5_;
            this.btn_editar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_editar.Location = new System.Drawing.Point(841, 419);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_editar.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_editar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_editar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_editar.OnHoverImage = null;
            this.btn_editar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_editar.Size = new System.Drawing.Size(155, 42);
            this.btn_editar.TabIndex = 17;
            this.btn_editar.Text = "Editar Datos";
            this.btn_editar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.AnimationHoverSpeed = 0.07F;
            this.btn_ingresar.AnimationSpeed = 0.03F;
            this.btn_ingresar.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btn_ingresar.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btn_ingresar.BorderColor = System.Drawing.Color.Black;
            this.btn_ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ingresar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_ingresar.FocusedColor = System.Drawing.Color.Empty;
            this.btn_ingresar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.ForeColor = System.Drawing.Color.White;
            this.btn_ingresar.Image = global::GuiaN10.Properties.Resources.descarga__3_;
            this.btn_ingresar.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_ingresar.Location = new System.Drawing.Point(671, 419);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btn_ingresar.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btn_ingresar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_ingresar.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_ingresar.OnHoverImage = null;
            this.btn_ingresar.OnPressedColor = System.Drawing.Color.Black;
            this.btn_ingresar.Size = new System.Drawing.Size(155, 42);
            this.btn_ingresar.TabIndex = 16;
            this.btn_ingresar.Text = "Ingresar Datos";
            this.btn_ingresar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::GuiaN10.Properties.Resources.vete;
            this.gunaPictureBox1.Location = new System.Drawing.Point(118, 33);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Radius = 20;
            this.gunaPictureBox1.Size = new System.Drawing.Size(524, 150);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 15;
            this.gunaPictureBox1.TabStop = false;
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = global::GuiaN10.Properties.Resources._11001906_858429314223848_5069884358427700821_n;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(1, -1);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(80, 78);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 12;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // rdb_Hembra
            // 
            this.rdb_Hembra.AutoSize = true;
            this.rdb_Hembra.BackgroundImage = global::GuiaN10.Properties.Resources.descarga1;
            this.rdb_Hembra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rdb_Hembra.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdb_Hembra.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_Hembra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdb_Hembra.Location = new System.Drawing.Point(185, 90);
            this.rdb_Hembra.Name = "rdb_Hembra";
            this.rdb_Hembra.Size = new System.Drawing.Size(46, 33);
            this.rdb_Hembra.TabIndex = 25;
            this.rdb_Hembra.TabStop = true;
            this.rdb_Hembra.Text = "   ";
            this.rdb_Hembra.UseVisualStyleBackColor = true;
            this.rdb_Hembra.CheckedChanged += new System.EventHandler(this.rdb_Hembra_CheckedChanged_1);
            // 
            // rdb_macho
            // 
            this.rdb_macho.AutoSize = true;
            this.rdb_macho.BackgroundImage = global::GuiaN10.Properties.Resources.descarga__1_;
            this.rdb_macho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rdb_macho.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rdb_macho.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_macho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rdb_macho.Location = new System.Drawing.Point(262, 90);
            this.rdb_macho.Name = "rdb_macho";
            this.rdb_macho.Size = new System.Drawing.Size(46, 33);
            this.rdb_macho.TabIndex = 26;
            this.rdb_macho.TabStop = true;
            this.rdb_macho.Text = "   ";
            this.rdb_macho.UseVisualStyleBackColor = true;
            this.rdb_macho.CheckedChanged += new System.EventHandler(this.rdb_macho_CheckedChanged_1);
            // 
            // frm_datos10_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1008, 477);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gunaCirclePictureBox1);
            this.Controls.Add(this.tabla_datos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_datos10_2";
            this.Text = "frm_datos10_2";
            this.Load += new System.EventHandler(this.frm_datos10_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla_datos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView tabla_datos;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_Mascotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomApe_Dueño;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaComboBox combo_raza;
        private System.Windows.Forms.TextBox txt_nomMascota;
        private Guna.UI.WinForms.GunaGradientButton btn_ingresar;
        private Guna.UI.WinForms.GunaLabel lbl_nombresexo;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private System.Windows.Forms.TextBox txt_ntelefono;
        private System.Windows.Forms.TextBox txt_nomYape;
        private System.Windows.Forms.TextBox txt_observacion;
        private Guna.UI.WinForms.GunaGradientButton btn_editar;
        private System.Windows.Forms.RadioButton rdb_macho;
        private System.Windows.Forms.RadioButton rdb_Hembra;
    }
}