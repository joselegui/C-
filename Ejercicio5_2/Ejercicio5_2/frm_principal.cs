using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ejercicio5_2
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {
            lbl_Siguiente.Location = new Point(420, 390);
        }


        private void lbl_Siguiente_Click(object sender, EventArgs e)
        {
            frm_Productos productos = new frm_Productos();
            productos.Show();
            this.Hide();
        }


        private void btn_Help_Click(object sender, EventArgs e)
        {
            Form formBackground = new Form();

            try
            {
                using (frm_help info = new frm_help())
                {
                    formBackground.StartPosition = FormStartPosition.CenterScreen;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .50;
                    formBackground.BackColor = Color.Black;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();
                    formBackground.WindowState = FormWindowState.Maximized;
                    info.Owner = formBackground;
                    info.ShowDialog();

                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }
        }

    }
}
