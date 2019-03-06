using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace RestauranteLegui
{
    public partial class Form1 : Form
    {

        List<Panel> Cartas = new List<Panel>();//Diferentes Pantallas.
        int cambiar;//Contenedor de las pantallas.
        SoundPlayer player;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Crear la información sobre herramientas y asociarse con el contenedor de formularios.
            ToolTip tool = new ToolTip();

            // establecer los retrasos para la información sobre herramientas
            tool.AutoPopDelay = 5000;
            tool.InitialDelay = 1000;
            tool.ReshowDelay = 500;
            // forzar el texto de información sobre herramientas que se mostrará si el formulario está activo. 
            tool.ShowAlways = true;
            // establecer el texto de información sobre herramientas para los botones y texbox.
            tool.SetToolTip(this.agregar, "Agregar productos.");
            tool.SetToolTip(this.borrar, "Reinicia todos los datos.");
            tool.SetToolTip(this.BtnApagado,"Cierra el programa.");
            tool.SetToolTip(this.BtnBorraTex,"Borra campos de Precio y Cantidad.");
            tool.SetToolTip(this.total, "Total del DataGridView.");
            tool.SetToolTip(this.EliminarDato, "Borra fila seleccionada.");
            tool.SetToolTip(this.Hamburguesas, "Hamburgusas.");
            tool.SetToolTip(this.Platos, "Platos.");
            tool.SetToolTip(this.Pizzas, "Pizzas.");
            tool.SetToolTip(this.Bebidas, "Bebidas.");
            tool.SetToolTip(this.Ensaladas, "Ensaladas.");
            tool.SetToolTip(this.Postres, "Postres.");
            tool.SetToolTip(this.Desayunos, "Desayunos.");
            tool.SetToolTip(this.Home, "Menu-Binvenidos");
            tool.SetToolTip(this.Regresar, "Hoja anterior.");
            tool.SetToolTip(this.Siguiente, "Siguiente hoja.");

            //tool.SetToolTip(this.checkBox1, "My checkBox1");


            //Lista de paneles.
            Cartas.Add(CartaMenu);
            Cartas.Add(CartaMenu2);
            Cartas.Add(CartaMenu3);
            Cartas.Add(CartaMenu4);
            Cartas.Add(CartaMenu5);
            Cartas.Add(CartaMenu6);
            Cartas.Add(CartaMenu7);
            Cartas.Add(CartaMenu8);
            
            Cartas[cambiar].BringToFront();

            //Tranparenta al segundo pictureBox colocado.
            pictureBox1.Controls.Add(BtnBorraTex);
            pictureBox1.Controls.Add(BtnApagado);
            pictureBox1.Controls.Add(labelHora);
            pictureBox1.Controls.Add(label36);
            pictureBox1.Controls.Add(picturePagoEfectivo);
            pictureBox1.Controls.Add(picturePagoTarjeta);
            pictureBox1.Controls.Add(BTNImprimir);

            //Hora.
            timer1.Enabled = true;
        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            if (cambiar < Cartas.Count - 1)
            {
                Cartas[++cambiar].BringToFront();
                player = new SoundPlayer(@"C:\SonidosWav\button.wav");
                //player.Play();
            }
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            if (cambiar > 0)
                Cartas[--cambiar].BringToFront();
            //player = new SoundPlayer(@"C:\SonidosWav\button.wav");
            //player.Play();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            CartaMenu.BringToFront();
            //player = new SoundPlayer(@"C:\SonidosWav\button.wav");
            //player.Play();
        }

        private void Hamburguesas_Click(object sender, EventArgs e)
        {
            CartaMenu2.BringToFront();
            //player = new SoundPlayer(@"C:\SonidosWav\button.wav");
            //player.Play();
        }

        private void Pizzas_Click(object sender, EventArgs e)
        {
            CartaMenu3.BringToFront();
            //player = new SoundPlayer(@"C:\SonidosWav\button.wav");
            //player.Play();
        }

        private void Platos_Click(object sender, EventArgs e)
        {
            CartaMenu4.BringToFront();
            //player = new SoundPlayer(@"C:\SonidosWav\button.wav");
            //player.Play();
        }

        private void Bebidas_Click(object sender, EventArgs e)
        {
            CartaMenu5.BringToFront();
            //player = new SoundPlayer(@"C:\SonidosWav\button.wav");
            //player.Play();
        }

        private void Postres_Click(object sender, EventArgs e)
        {
            CartaMenu6.BringToFront();
            //player = new SoundPlayer(@"C:\SonidosWav\button.wav");
            //player.Play();
        }

        private void Ensaladas_Click(object sender, EventArgs e)
        {
            CartaMenu7.BringToFront();
            //player = new SoundPlayer(@"C:\SonidosWav\button.wav");
            //player.Play();
        }
        private void Desayunos_Click(object sender, EventArgs e)
        {
            CartaMenu8.BringToFront();
            //player = new SoundPlayer(@"C:\SonidosWav\button.wav");
            //player.Play();
        }

        //Elimina fila seleccionada del pedido
        private void EliminarDato_Click(object sender, EventArgs e)
        {
            int fila;

            fila = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.RemoveAt(fila);
        }
        
        //Se agregan los datos ingresados en los campos seleccionados.
        //En los texBox y en el dataGridView1.
        private void agregar_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(textCantidad.Text);
            double n2 = Convert.ToDouble(textPrecio.Text);

            int canFilas = dataGridView1.Rows.Count - 1;//Va agregando filas automaticamente.
            dataGridView1.Rows.Add();

            dataGridView1[0, canFilas].Value = textCantidad.Text;
            dataGridView1[1, canFilas].Value = textPrecio.Text;
            dataGridView1[2, canFilas].Value = n1 * n2;// Multiplaca el contenido de la fila 1 con la fila 2 y los guarda en la fila 3.

        }
        //Suma todo el contenido de la columna 3 y los muestra en el textTotal.
        private void total_Click(object sender, EventArgs e)
        {
            double suma = 0;

            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                suma += Convert.ToDouble(dataGridView1.Rows[i].Cells["Totalcolumna"].Value);

            }
            textTotal.Text = Convert.ToString(suma);
        }
        //BTN de pago en tarjeta
        private void picturePagoTarjeta_Click(object sender, EventArgs e)
        {

            textResultadoFinal.Text = textTotal.Text;//Secopia el resultado anterior para poder hacer el calculo.
            //Variables a utilizar.
            double cuotas1 = 2;
            double cuotas2 = 4;
            double cuotas3 = 12;
            double res = 0;

            //Funciones de los checkBox
            if (checkBox1.Checked == true)
            {
                res = Convert.ToDouble(textResultadoFinal.Text) / cuotas1;
                textResultadoFinal.Text = Convert.ToString(res);
            }

            if (checkBox2.Checked == true)
            {
                res = Convert.ToDouble(textResultadoFinal.Text) / cuotas2;
                textResultadoFinal.Text = Convert.ToString(res);
            }

            if (checkBox3.Checked == true)
            {
                res = Convert.ToDouble(textResultadoFinal.Text) / cuotas3;
                textResultadoFinal.Text = Convert.ToString(res);
            }
        }

        private void picturePagoTarjeta_MouseHover(object sender, EventArgs e)
        {
            picturePagoTarjeta.BackgroundImage = Properties.Resources.Pago_Tarjeta4;
        }

        private void picturePagoTarjeta_MouseLeave(object sender, EventArgs e)
        {
            picturePagoTarjeta.BackgroundImage = Properties.Resources.Pago_Tarjeta2;
        }

        //BTN Para el pago en Efectivo.
        private void picturePagoEfectivo_Click(object sender, EventArgs e)
        {
            textResultadoFinal.Text = textTotal.Text;//Secopia el resultado anterior para poder hacer el calculo.

            //Variables a utilizar.
            double descuento = 0;
            double resultado = 0;
            double num1;

            num1 = Convert.ToDouble(textResultadoFinal.Text);

            if (num1 > 50 && num1 < 150)
            {
                descuento = (num1 * 10) / 100;
                resultado = Convert.ToDouble(textResultadoFinal.Text) - descuento;
                textResultadoFinal.Text = Convert.ToString(resultado);
                MessageBox.Show("Sele ha echo un 10% de descuento por pago en efectivo", "Calculo de descuento");
                
            }

            if (num1 > 150)
            {
                descuento = (num1 * 20) / 100;
                resultado = Convert.ToDouble(textResultadoFinal.Text) - descuento;
                textResultadoFinal.Text = Convert.ToString(resultado);
                MessageBox.Show("Sele ha echo un 20% de descuento por pago en efectivo", "Calculo de descuento");
            }
        }

        private void picturePagoEfectivo_MouseHover(object sender, EventArgs e)
        {
            picturePagoEfectivo.BackgroundImage = Properties.Resources.Caja1;
        }

        private void picturePagoEfectivo_MouseLeave(object sender, EventArgs e)
        {
            picturePagoEfectivo.BackgroundImage = Properties.Resources.Caja2;
        }


        //Borra todos los campos del dataGridView1 y los textBox.
        private void borrar_Click(object sender, EventArgs e)
        {
            textCantidad.Clear();
            textPrecio.Clear();
            textTotal.Clear();
            textResultadoFinal.Clear();

            dataGridView1.Rows.Clear();
        }
        //Borra solo los textBoxt.
        private void BtnBorraTex_Click(object sender, EventArgs e)
        {
            textCantidad.Clear();
            textPrecio.Clear();
        }

        private void BtnBorraTex_MouseHover(object sender, EventArgs e)
        {
            BtnBorraTex.BackgroundImage = Properties.Resources.Trash2;
        }

        private void BtnBorraTex_MouseLeave(object sender, EventArgs e)
        {
            BtnBorraTex.BackgroundImage = Properties.Resources.Trash1;
        }

        //BTN Imprimir
        private void BTNImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El tota a pagar es $" + textResultadoFinal.Text + " Gracias por su COMPRA", "Imprimiendo Ticket");
        }

        private void BTNImprimir_MouseHover(object sender, EventArgs e)
        {
            BTNImprimir.BackgroundImage = Properties.Resources.tickets1;
        }

        private void BTNImprimir_MouseLeave(object sender, EventArgs e)
        {
            BTNImprimir.BackgroundImage = Properties.Resources.tickets;
        }

        //Boton para cerrar el programa. 
        private void BtnApagado_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnApagado_MouseHover(object sender, EventArgs e)
        {
            BtnApagado.BackgroundImage = Properties.Resources.botonApagado2;
        }

        private void BtnApagado_MouseLeave(object sender, EventArgs e)
        {
            BtnApagado.BackgroundImage = Properties.Resources.botonApagado1;
        }

        //Hora.
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString();
        }

        //Inicia funciones de BOTONES.
        private void H1_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "45";
        }

        private void H2_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "55";
        }

        private void H3_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "30";
        }

        private void H4_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "55";
        }

        private void H5_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "68";
        }

        private void P1_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "70";
        }

        private void P2_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "60";
        }

        private void P3_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "55";
        }

        private void P4_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "45";
        }

        private void P5_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "75";
        }

        private void Plato1_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "45";
        }

        private void Plato2_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "20";
        }

        private void Plato3_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "43";
        }

        private void Plato4_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "35";
        }

        private void Plato5_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "50";
        }

        private void B1_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "45";
        }

        private void B2_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "45";
        }

        private void B3_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "35";
        }

        private void B4_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "35";
        }

        private void B5_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "35";
        }

        private void Pos1_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "45";
        }

        private void Pos2_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "30";
        }

        private void Pos3_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "18";
        }

        private void Pos4_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "25";
        }

        private void Pos5_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "35";
        }

        private void E1_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "45";
        }

        private void E2_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "32";
        }

        private void E3_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "18";
        }

        private void E4_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "30";
        }

        private void E5_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "60";
        }

        private void D1_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "50";
        }

        private void D2_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "45";
        }

        private void D3_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "460";
        }

        private void D4_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "30";
        }

        private void D5_Click(object sender, EventArgs e)
        {
            textPrecio.Text = textPrecio.Text + "25";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textCantidad.Text = textCantidad.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textCantidad.Text = textCantidad.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textCantidad.Text = textCantidad.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textCantidad.Text = textCantidad.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textCantidad.Text = textCantidad.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textCantidad.Text = textCantidad.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textCantidad.Text = textCantidad.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textCantidad.Text = textCantidad.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textCantidad.Text = textCantidad.Text + "9";
        }

 

       //Finaliza Funciones de BOTONES

    }
}
