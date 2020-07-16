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
    public partial class frm_help : Form
    {
        public frm_help()
        {
            InitializeComponent();
        }

        private void frm_help_Load(object sender, EventArgs e)
        {
            lbl_texto.Text = "Verción 2.0 del ejercicio 5.2 de la" +
                "\nGuin N°5, de Seminario de Programación"+
                "\nde los profesores Toledo y Landini..."
                +"\n\nPrograma realizado por José Leguizamón.";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
