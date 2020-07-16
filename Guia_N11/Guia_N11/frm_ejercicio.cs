using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Guia_N11
{
    public partial class frm_ejercicio : Form
    {
        public frm_ejercicio()
        {
            InitializeComponent();
            txt_nombre.Select();
            
        }

        private void frm_ejercicio_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'guiaN11DataSet.Alumno' table. You can move, or remove it, as needed.
            this.alumnoTableAdapter.Fill(this.guiaN11DataSet.Alumno);
            
            txt_id.Text = ObtenernumeroID().ToString();
            
            
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //Ejecutamos la consulta de Inserción creada
            //Los parámetros serán lo escrito en los textBox 
            this.alumnoTableAdapter.INNSRTAR(Convert.ToInt32(txt_id.Text), txt_nombre.Text,txt_apellido.Text,txt_materia.Text,
                Convert.ToInt32(txt_nota1.Text), Convert.ToInt32(txt_nota2.Text), Convert.ToInt32(txt_nota3.Text));
            //Actualizamos la grilla
            this.alumnoTableAdapter.Fill(this.guiaN11DataSet.Alumno);
            Promedio();
            Borrartextos();
            txt_id.Text = ObtenernumeroID().ToString();
        }



        private void btn_modificar_Click(object sender, EventArgs e)
        {

            this.alumnoTableAdapter.MODIFICAR(txt_nombre.Text,txt_apellido.Text,txt_materia.Text,
                Convert.ToInt32(txt_nota1.Text), Convert.ToInt32(txt_nota2.Text), Convert.ToInt32(txt_nota3.Text), Convert.ToInt32(txt_id.Text));

            this.alumnoTableAdapter.Fill(this.guiaN11DataSet.Alumno);

            Promedio();

            Borrartextos();

            txt_id.Text = ObtenernumeroID().ToString();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            this.alumnoTableAdapter.ELIMINAR(Convert.ToInt32(txt_id.Text));
            this.alumnoTableAdapter.Fill(this.guiaN11DataSet.Alumno);

            Borrartextos();
            txt_promedio.Text = "";
            txt_resultado.Text = "";
            txt_id.Text = ObtenernumeroID().ToString();
        }

        private void tabla_datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index != -1) //controlamos que exista una fila seleccionada
            {

                txt_id.Text = tabla_datos.Rows[index].Cells[0].Value.ToString();
                txt_nombre.Text = tabla_datos.Rows[index].Cells[1].Value.ToString();
                txt_apellido.Text = tabla_datos.Rows[index].Cells[2].Value.ToString();
                txt_materia.Text = tabla_datos.Rows[index].Cells[3].Value.ToString();
                txt_nota1.Text = tabla_datos.Rows[index].Cells[4].Value.ToString();
                txt_nota2.Text = tabla_datos.Rows[index].Cells[5].Value.ToString();
                txt_nota3.Text = tabla_datos.Rows[index].Cells[6].Value.ToString();

            }
            Promedio();
           
        }

        public int ObtenernumeroID()
        {
            int nuevoId = Convert.ToInt32(tabla_datos.Rows[tabla_datos.Rows.Count - 1].Cells[0].Value) + 1;

            return nuevoId;
        }

        //Metodo para calcular promedio
        int nota1, nota2, nota3;
        int suma;
        double promedio = 0;
        public void Promedio()
        {
            nota1 = Convert.ToInt32(txt_nota1.Text);
            nota2 = Convert.ToInt32(txt_nota2.Text);
            nota3 = Convert.ToInt32(txt_nota3.Text);

            suma = nota1 + nota2 + nota3;

            promedio = suma / 3;

            txt_promedio.Text = Convert.ToString(promedio);

            if (promedio >= 7)
            {
                txt_resultado.Text = "Aprobado";
            }
            else
            txt_resultado.Text = "Desaprobado";
        }

        private void Borrartextos()
        {
            txt_id.Text = "";
            txt_nombre.Text = "";
            txt_apellido.Text = "";
            txt_materia.Text = "";
            txt_nota1.Text = "";
            txt_nota2.Text = "";
            txt_nota3.Text = "";
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_nota1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                {
                    e.Handled = false;
                }
                else
                {
                    MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;
                }
        }

        private void txt_nota2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                {
                    e.Handled = false;
                }
                else
                {
                    MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;
                }
        }

        private void txt_nota3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para obligar a que sólo se introduzcan números
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso
                {
                    e.Handled = false;
                }
                else
                {
                    MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;
                }
        }
    }
}
