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
    public partial class frm_Productos : Form
    {
        public frm_Productos()
        {
            InitializeComponent();
        }

        //Declaracion de variables
        double calcular, total;
        String productos = "{0,-25}{1,-20}{2,-20}{3,-40}";
        String nombre_producto;


        private void frm_Productos_Load(object sender, EventArgs e)
        {
            lbl_valor.Enabled = false;
            lbl_Porcentaje.Enabled = false;
            lbl_Redondeo.Enabled = false;
            lbl_Total.Enabled = false;
            listaprrodustos.Items.Add(String.Format(productos, "Producto","Precio", "IVA 30%", "Redondeo"));//Agrega los nombres de las columnas en el listbox
            listaprrodustos.Items.Add(String.Format("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯"));
        }

        // Inicio de las funciones de los botones
        private void lbl_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Manzana_Click(object sender, EventArgs e)
        {
            lbl_valor.Enabled = true;
            lbl_valor.Text = "30,50";
            nombre_producto = "Manzana";
            Calcular_porcentaje();
            Redondeo();
            Copiar_Datos();
            Sumar_total();
        }

        private void Banana_Click(object sender, EventArgs e)
        {
            lbl_valor.Enabled = true;
            lbl_valor.Text = "85,00";
            nombre_producto = "Banana";
            Calcular_porcentaje();
            Redondeo();
            Copiar_Datos();
            Sumar_total();
        }

        private void Naranja_Click(object sender, EventArgs e)
        {
            lbl_valor.Enabled = true;
            lbl_valor.Text = "45,20";
            nombre_producto = "Naranja";
            Calcular_porcentaje();
            Redondeo();
            Copiar_Datos();
            Sumar_total();
        }

        private void Frutilla_Click(object sender, EventArgs e)
        {
            lbl_valor.Enabled = true;
            lbl_valor.Text = "71,20";
            nombre_producto = "Frutilla";
            Calcular_porcentaje();
            Redondeo();
            Copiar_Datos();
            Sumar_total();
        }

        private void Durazno_Click(object sender, EventArgs e)
        {
            lbl_valor.Enabled = true;
            lbl_valor.Text = "55,30";
            nombre_producto = "Durazno";
            Calcular_porcentaje();
            Redondeo();
            Copiar_Datos();
            Sumar_total();
        }

        private void Tomate_Click(object sender, EventArgs e)
        {
            lbl_valor.Enabled = true;
            lbl_valor.Text = "35,60";
            nombre_producto = "Tomate";
            Calcular_porcentaje();
            Redondeo();
            Copiar_Datos();
            Sumar_total();
        }

        private void Lechuga_repollada_Click(object sender, EventArgs e)
        {
            lbl_valor.Enabled = true;
            lbl_valor.Text = "50,60";
            nombre_producto = "Lechuga";
            Calcular_porcentaje();
            Redondeo();
            Copiar_Datos();
            Sumar_total();
        }

        private void Cebolla_morada_Click(object sender, EventArgs e)
        {
            lbl_valor.Enabled = true;
            lbl_valor.Text = "65,80";
            nombre_producto = "Cebolla";
            Calcular_porcentaje();
            Redondeo();
            Copiar_Datos();
            Sumar_total();
        }

        private void Acelga_Click(object sender, EventArgs e)
        {
            lbl_valor.Enabled = true;
            lbl_valor.Text = "25,50";
            nombre_producto = "Acelga";
            Calcular_porcentaje();
            Redondeo();
            Copiar_Datos();
            Sumar_total();
        }

        private void MorronR_Click(object sender, EventArgs e)
        {
            lbl_valor.Enabled = true;
            lbl_valor.Text = "32,30";
            nombre_producto = "Morron";
            Calcular_porcentaje();
            Redondeo();
            Copiar_Datos();
            Sumar_total();
        }

        private void Cherri_Click(object sender, EventArgs e)
        {
            lbl_valor.Enabled = true;
            lbl_valor.Text = "36,70";
            nombre_producto = "Cherri";
            Calcular_porcentaje();
            Redondeo();
            Copiar_Datos();
            Sumar_total();
        }

        private void UvaN_Click(object sender, EventArgs e)
        {
            lbl_valor.Enabled = true;
            lbl_valor.Text = "70,20";
            nombre_producto = "Uva";
            Calcular_porcentaje();
            Redondeo();
            Copiar_Datos();
            Sumar_total();
        }
        //Fin de las funciones de los botones

        //Metodo para calcular el porcentaje
        public void Calcular_porcentaje()
        {
            lbl_Porcentaje.Enabled = true;
            calcular = Convert.ToDouble(lbl_valor.Text);
            calcular += calcular * 0.30;

            lbl_Porcentaje.Text = Convert.ToString(calcular);

            
        }

        //Metodo para redondear para arriva
        public void Redondeo()
        {
            lbl_Redondeo.Enabled = true;
            this.lbl_Redondeo.Text = Math.Ceiling(calcular).ToString();
            //Math.Ceiling () es un método de clase matemática. 
            //Este método se utiliza para encontrar el número entero más pequeño , 
            //que es mayor o igual que el argumento pasado. 
            //El método Celing opera ambas funcionalidades en decimal y doble. 
            //Este método se puede sobrecargar al pasarle diferentes argumentos.  
        }

        //Metodo para copiar todos los datos a la lista
        public void Copiar_Datos() 
        {
            listaprrodustos.Items.Add(nombre_producto + "\t                " + lbl_valor.Text + "\t       " + 
                lbl_Porcentaje.Text + "\t\t" + lbl_Redondeo.Text + "");
        }

        //Metoto para sumar el redondeo
        public void Sumar_total()
        {
            lbl_Total.Enabled = true;
            total += Convert.ToDouble(lbl_Redondeo.Text);
            lbl_Total.Text = "$ "+Convert.ToDouble(total).ToString();
        }

        //Boton para borrar todos los campos
        private void btn_reset_Click(object sender, EventArgs e)
        {
            lbl_valor.Text = "";
            lbl_Porcentaje.Text = "";
            lbl_Redondeo.Text = "";
            lbl_Total.Text = "";
            listaprrodustos.Items.Clear();
            total = 0;
        }
    }
}
