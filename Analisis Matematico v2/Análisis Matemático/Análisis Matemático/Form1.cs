using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Análisis_Matemático
{
    public partial class Ruffini : Form
    {
        public Ruffini()
        {
            InitializeComponent();
        }
        //metodo para validar si los valores son numericos
        private bool IsNumeric(string num)
        {
            try
            {
                double x = Convert.ToDouble(num);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Variable para el cambio del signo del numero del divisor de + a - y viceversa.
        double signo;

        //Funciones del boton OK
        private void BtnOK_Click(object sender, EventArgs e)
        {
            //si los valores ingresados no son numericos muestro mensaje con errorprovider
            if (!IsNumeric(textNelevado3.Text) && (!IsNumeric(textNelevado2.Text)) &&
                (!IsNumeric(textNelevado1.Text)) && (!IsNumeric(textNelevado0.Text)) &&
                (!IsNumeric(textDividendo.Text)))
            {
                errorProvider1.SetError(textNelevado3, "debe ingresar un numero");
                errorProvider1.SetError(textNelevado2, "debe ingresar un numero");
                errorProvider1.SetError(textNelevado1, "debe ingresar un numero");
                errorProvider1.SetError(textNelevado0, "debe ingresar un numero");
                errorProvider1.SetError(textDividendo, "debe ingresar un numero");

                MessageBox.Show("Debe Ingresar Valores Numericos");
            }
            //si no entonces realizo las funciones
            else
            {
                //Copia los datos ingresados en los TEXTBOX con las X en los textbox,
                //que se encuentran dentro del groupBox1.
                textN3.Text = textNelevado3.Text;
                textN2.Text = textNelevado2.Text;
                textN1.Text = textNelevado1.Text;
                textN0.Text = textNelevado0.Text;
                textNDivisor.Text = textDividendo.Text;

                //Funcion para poder cambien el signo del numero del divisor de + a - y viceversa.
                signo = double.Parse(textNDivisor.Text);//-25
                signo = signo - (signo * 2);// signo = -25 - (-25 * 2) -> -25 - (-50)
                textNDivisor.Text = signo.ToString();// signo = 25


                //Borra los datos ingresados, dejando vacio los textbox.
                textNelevado3.Clear();
                textNelevado2.Clear();
                textNelevado1.Clear();
                textNelevado0.Clear();
                textDividendo.Clear();

                //Copia el dato copiado del text dentro del groupBox1.
                textCN3.Text = textN3.Text;
            }
        }

        //Funciones del Boton Calcular.
        private void BTNCalcular_Click(object sender, EventArgs e)
        {
            //Declaracion de variables.
            double primernumero;
            double segundonumero;
            double tercernumero;
            double cuartonumero;


            double numeroDivisor;

            double resultadoSuma;
            double resultadoSuma1;
            double resultadoSuma2;

            double resultado;
            double resultado2;
            double resultado3;

            //Convertir los datos a numeros.
            primernumero = double.Parse(textCN3.Text);
            segundonumero = double.Parse(textN2.Text);
            tercernumero = double.Parse(textN1.Text);
            cuartonumero = double.Parse(textN0.Text);

            numeroDivisor = double.Parse(textNDivisor.Text);


            //Realizacion de las operaciones matemáticas.
           resultado = primernumero * numeroDivisor;


           textRes1.Text = resultado.ToString();

           resultadoSuma = segundonumero + (Convert.ToDouble(textRes1.Text));

           textRes11.Text = resultadoSuma.ToString();

           resultado2 = (Convert.ToDouble(textRes11.Text)) * numeroDivisor;
           textRes2.Text = resultado2.ToString();

           resultadoSuma1 = tercernumero + (Convert.ToDouble(textRes2.Text));
           textRes22.Text = resultadoSuma1.ToString();

           resultado3 = (Convert.ToDouble(textRes22.Text)) * numeroDivisor;
           textRes3.Text = resultado3.ToString();

           resultadoSuma2 = cuartonumero + (Convert.ToDouble(textRes3.Text));
           textRes33.Text = resultadoSuma2.ToString();

        }

        //Funcion del boton Resultados.
        private void BTNResultado_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textRes33.Text) == 0)
            {
                textRF1.Text = textCN3.Text;
                textRF2.Text = textRes11.Text;
                textRF3.Text = textRes22.Text;
            }
            //else 
            //{
            //    MessageBox.Show("resultado Incorrecto");
            //}
        }

        
        //Boton limpiar campos.
        private void BTNNuevo_Click(object sender, EventArgs e)
        {
            LimpiarTextbox limpiar = new LimpiarTextbox();

            limpiar.LimpiarText(this);
        }

        //Cerrar el programa.
        private void BTNSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
