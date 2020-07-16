using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GuiaN10.Properties;

namespace GuiaN10
{
    public partial class frm_principal : Form
    {
        private bool deslizar;

        public frm_principal()
        {
            InitializeComponent();
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            lbl_fecha.Text = DateTime.Now.ToString("dd' de 'MMMMM' del 'yyyy");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btn_ghit_Click_1(object sender, EventArgs e)
        {
            frm_github git = new frm_github();
            git.ShowDialog();
        }

        private void btn_lin_Click_1(object sender, EventArgs e)
        {
            frm_linkedin lin = new frm_linkedin();
            lin.ShowDialog();
        }

        private void btn_ejercicio10_1_Click(object sender, EventArgs e)
        {
            AbrirFromHija(new frm_ejercicio10_1());
        }
        //Metodo para abrir los formularios y contenerlos en el panel principar
        //manteniendo el tamaño de este.
        private void AbrirFromHija(object fromHija)
        {
            if (this.panel_contenedor.Controls.Count > 0)
            {
                this.panel_contenedor.Controls.RemoveAt(0);
            }
            Form frm_secundarios = fromHija as Form;
            frm_secundarios.TopLevel = false;
            frm_secundarios.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(frm_secundarios);
            this.panel_contenedor.Tag = frm_secundarios;
            frm_secundarios.Show();
        }

        private void btn_ejercicio10_2_Click(object sender, EventArgs e)
        {
            AbrirFromHija(new frm_ejercicio10_2());
            contextMenuStrip1.Show(btn_ejercicio10_2, 0, btn_ejercicio10_2.Height);
        }

        private void ingresarLosDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFromHija(new frm_datos10_2());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
