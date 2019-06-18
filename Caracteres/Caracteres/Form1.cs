using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Caracteres
{
    public partial class Form1 : Form
    {

        DialogResult result;
        public string cadena;
        public int vocales = 0, contador = 0, palabras = 0, contador2 = 0;

        //Variables para mover el formulario.
        Point Posiciondelformulario;
        Boolean mouse;

        public Form1()
        {         
            InitializeComponent();
            txt_textos.Select();
        }
        //Desde aca se cierra la aplicacion.
        private void labelExit_Click(object sender, EventArgs e)
        {
            result =MessageBox.Show("¡Seguro que desea salir de la aplicación?", "¡Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
                this.Close();
        }
        //Desde aca se miniminiza la aplicacion
        private void labelMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Ace se esncuentra toda las funciones de la aplicacion...
        private void btnAceptar_Click(object sender, EventArgs e)
        {
                //Declaracion de variables
                cadena = txt_textos.Text;

                //Hace el recorrido del texto ingresado obteniendo la longitud.
                for (int i = 0; i < cadena.Length; i++)
                {
                    contador++;
                }

                for (int i = 0; i < cadena.Length; i++)
                {   //Condicion que evalua la cadna ingresada en busca de los caracteres A o a
                    if ((cadena[i] == 'a') || (cadena[i] == 'A'))
                    {
                        vocales++;
                    }
                }

                result = MessageBox.Show("La cantidad de letras 'a' o 'A' son: " + vocales + "\n¿Desea saber la cantidad de caracteres, que tiene lo escrito?", "Contador de letras A o a", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    cadena = cadena.Replace(" ", "");//Elimina los espacios vacios para que no los cuente como caracteres...
                    result = MessageBox.Show("La cantidad de caracteres son: " + cadena.Length + "\n¿Desea guardar lo escrito en formato *.txt?", "Contador de caracteres", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    //Condicion en donde me guarda en un archivo txt, lo escrito en el textbox.
                    if (result == DialogResult.Yes)
                    {
                        StreamWriter escribir = null;
                        escribir = File.CreateText("Contador de caracteres.txt");
                        escribir.WriteLine(txt_textos.Text);
                        escribir.Flush();
                        escribir.Close();
                        limpiartexto();
                        result = MessageBox.Show("El texto fue guardado con exito" + "\ncon el nombre de: Contador de caracteres.txt" + "\n¿Quiere saber cuantas palabras tiene el archivo?", "Guardar Archivo ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    }
                    //Condicion y variables para leer el archivo txt
                    if (result == DialogResult.Yes)
                    {   //variable para leer el archivo
                        string leerpalabras;
                        int aux = 0, contarpalabras = 0, resultado = 0;

                        TextReader leer;
                        //instancia para leer y buscar el archivo txt

                        leer = new StreamReader("Contador de caracteres.txt");
                        //leer.ReadToEnd();
                        leerpalabras = Convert.ToString(leer.ReadToEnd());

                        resultado = palabrascontadas(leerpalabras + ' ', aux, contarpalabras);


                        MessageBox.Show("El archivo contiene " + resultado.ToString() + " palabras", "Contador de palabras", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);//ReadToEnd = metodo para leer todo el archivo
                        leer.Close();
                    }
                    if (result == DialogResult.Yes){
                        MessageBox.Show("La aplicacion a finalizado con exito "
                            + "\n\n¡¡Hasta pronto :) !!", "Fin del programa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
        }

        //Metodo para la funciones de contar solo las palabras del archivo....
        private int palabrascontadas(string cadena, int auxiliar, int palabras)
        {
            if (auxiliar >= cadena.Length - 1)
            {
                return palabras + 1;
            }
            else {
                if (cadena[auxiliar] == ' ' && cadena[auxiliar + 1] != ' ')
                    palabras++;
                return palabrascontadas(cadena, auxiliar+1,palabras);
            }
        }

        //Metodo para limpiar el textbox
        public void limpiartexto() {
            txt_textos.Clear();
        }

        //Ayuda: explicación de lo que ace la aplicación
        private void labelAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En esta aplicación se genera varios pasos:"+
                "\n1: Cuantas veces se repite la letra A o a."+
                "\n2: Se cuentan los caracteres del TextBox."+
                "\n3: Se guarda lo escrito en un archivo txt."+
                "\n4: Se cuentan las palabras guardadas en el txt."+
                "\nSe pueden calcelar las funciones cuando Uds lo deseen..."+
                "\n\n¡¡ Buena suaerte ;) !!","AYUDA",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        // Evento KeyPress de la caja de texto, para validar solo caracteres.
        //private void Sololetras(object sender, KeyPressEventArgs e)
        //{
        //    if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back)
        //        && (e.KeyChar != (char)Keys.Enter))
        //    {
        //        MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        e.Handled = true;
        //        return;
        //    }
        //}

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Posiciondelformulario = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouse = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse == true)
            {
                Location = new Point(Cursor.Position.X - Posiciondelformulario.X, Cursor.Position.Y - Posiciondelformulario.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }
    }
}
