using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Boleta_de_pago
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            Double SueldoBasico; 
            Double HorasExtras, Integer, PagoHoraExtra; 
            Double Renta, Fonavi, AFP; 
            Double Ingresos;
            Double Egresos;
            Double SueldoNeto;

            SueldoBasico = Convert.ToDouble(texSueldoB.Text);
            HorasExtras = Convert.ToDouble(texHoraExtra.Text);
            PagoHoraExtra = Convert.ToDouble(texPagoHExtra.Text);

            if (radioDiurno.Checked == false) 
            {
                PagoHoraExtra = 10;
            }
            if(radioNocturno.Checked == false)
            {
                PagoHoraExtra = 15;
            }
            if (checkRenta.Checked == true)
            {
                Renta = SueldoBasico * 0.1;
            }
            else 
            {
                Renta = 0;
            }


            if (checkFonavi.Checked == true)
            {
                Fonavi = SueldoBasico * 0.7;
            }
            else 
            {
                Fonavi = 0;
            }


            if (checkAFP.Checked == true)
            {
                AFP = SueldoBasico * 0.03;
            }
            else 
            {
                AFP = 0;
            }




            Ingresos = SueldoBasico + HorasExtras * PagoHoraExtra;
            Egresos = Renta + Fonavi + AFP;
            SueldoNeto = Ingresos - Egresos;
            texPagoHExtra.Text = Convert.ToString(PagoHoraExtra);
            texRenta.Text = Convert.ToString(Renta);
            texFonavi.Text = Convert.ToString(Fonavi);
            texAFP.Text = Convert.ToString(AFP);
            texSueldoNeto.Text = Convert.ToString(SueldoNeto);

        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            texPagoHExtra.Clear();
            texRenta.Clear();
            texFonavi.Clear();
            texAFP.Clear();
            texSueldoNeto.Clear();
            texSueldoB.Clear();
            texHoraExtra.Clear();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
