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
    public partial class frm_ejemplo : Form
    {
        public frm_ejemplo()
        {
            InitializeComponent();
        }





        private void frm_ejemplo_Load(object sender, EventArgs e)
        {
            dgvSocios.AlternatingRowsDefaultCellStyle.BackColor = Color.PowderBlue;
            dgvSocios.RowsDefaultCellStyle.BackColor = Color.LightSkyBlue;
            // TODO: This line of code loads data into the 'agendaSeminarioDataSet.Socio' table. You can move, or remove it, as needed.
            this.socioTableAdapter.Fill(this.agendaSeminarioDataSet.Socio);
            txt_id.Text = ObtenernumeroID().ToString();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //Ejecutamos la consulta de Inserción creada
            //Los parámetros serán lo escrito en los textBox 
            this.socioTableAdapter.INSERTAR(Convert.ToInt32(txt_id.Text),txt_nombre.Text,txt_telefono.Text);
            //Actualizamos la grilla
            this.socioTableAdapter.Fill(this.agendaSeminarioDataSet.Socio);

            Borrartextos();
            txt_id.Text = ObtenernumeroID().ToString();
        }

       

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            this.socioTableAdapter.MODIFICAR(txt_nombre.Text, txt_telefono.Text, Convert.ToInt32(txt_id.Text));

            //actualizamos la grilla
            this.socioTableAdapter.Fill(this.agendaSeminarioDataSet.Socio);
            Borrartextos();
            txt_id.Text = ObtenernumeroID().ToString();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            //Ejecutamos la consulta de eliminación y enviamos como criterio 
            // de búsqueda el Id
            this.socioTableAdapter.ELIMINAR(Convert.ToInt32(txt_id.Text));

            //actualizamos la grilla
            this.socioTableAdapter.Fill(this.agendaSeminarioDataSet.Socio);

            Borrartextos();

            txt_id.Text = ObtenernumeroID().ToString();
        }

        private void dgvSocios_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index != -1) //controlamos que exista una fila seleccionada
            {

                txt_id.Text = dgvSocios.Rows[index].Cells[0].Value.ToString();
                txt_nombre.Text = dgvSocios.Rows[index].Cells[1].Value.ToString();
                txt_telefono.Text = dgvSocios.Rows[index].Cells[2].Value.ToString();

            }
        }

        private void Borrartextos()
        {
            txt_id.Text = "";
            txt_nombre.Text = "";
            txt_telefono.Text = "";
        }

        public int ObtenernumeroID()
        {
            int nuevoId = Convert.ToInt32(dgvSocios.Rows[dgvSocios.Rows.Count - 1].Cells[0].Value) + 1;

            return nuevoId;
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

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
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
