using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace GuiaN10
{
    public partial class frm_barraprogreso : Form
    {
        private int contador;

        public frm_barraprogreso()
        {
            InitializeComponent();
            contador = 0;
            timer1.Start();
        }

        private void frm_barraprogreso_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (contador == 102)
                timer1.Stop();
                //lbl_porcentage.Text = Convert.ToString("% " + contador);
                contador++;
                lbl_porcentage.Visible = false;




                if (contador == 102)
                {

                    Thread.Sleep(1000);
                    frm_principal principal = new frm_principal();
                    principal.Show();
                    this.Hide();
                }

        }
    }
}
