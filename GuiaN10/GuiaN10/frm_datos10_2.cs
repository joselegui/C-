using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuiaN10
{
    public partial class frm_datos10_2 : Form
    {
        Veterinaria veterinaria = new Veterinaria();

        public frm_datos10_2()
        {
            InitializeComponent();
            
            btn_editar.Enabled = false;
        }

        private void frm_datos10_2_Load(object sender, EventArgs e)
        {
            txt_nomMascota.Select();
        }

        //Declaracion de variables
        int n;
        string sexo;

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            datosrepetidos();
            txt_nomMascota.Select();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Editardatos();
            btn_editar.Enabled = false;
            txt_nomMascota.Select();
        }


        private void combo_raza_MouseClick(object sender, MouseEventArgs e)
        {
            Razas();
        }

        private void rdb_Hembra_CheckedChanged_1(object sender, EventArgs e)
        {
            sexo = "Hembra";

            if (rdb_Hembra.Checked == true)
            {
                rdb_Hembra.BackColor = Color.SlateBlue;
            }
            else
                rdb_Hembra.BackColor = Color.Transparent;
        }

        private void rdb_macho_CheckedChanged_1(object sender, EventArgs e)
        {
            sexo = "Macho";

            if (rdb_macho.Checked == true)
            {
                rdb_macho.BackColor = Color.SlateBlue;
            }
            else
                rdb_macho.BackColor = Color.Transparent;
        }

        public void Razas()
        {
            combo_raza.Items.Add("Gato");
            combo_raza.Items.Add("Perro");
            combo_raza.Items.Add("Hámsters");
            combo_raza.Items.Add("Pájaros");
            combo_raza.Items.Add("Conejo");
            combo_raza.Items.Add("Tortuga");
            combo_raza.Items.Add("Hurón");
            combo_raza.Items.Add("Peces");
            combo_raza.Items.Add("Reptil");
            //combo_raza.Items.Add("Primero");
            //combo_raza.Items.Add("Primero");
            //combo_raza.Items.Add("Primero");
        }

        public void Reset()
        {
            txt_nomMascota.Text = "";
            txt_nomYape.Text = "";
            txt_ntelefono.Text = "";
            txt_observacion.Text = "";
            combo_raza.Items.Clear();
            rdb_Hembra.Checked = false;
            rdb_macho.Checked = false;

        }

        public void Ingresardatos()
        {
            
            if ((txt_nomMascota.Text.Trim() != "") && (combo_raza.Text != "") &&
               (txt_nomYape.Text.Trim() != "") && (txt_ntelefono.Text.Trim() != "") && (txt_observacion.Text.Trim() != ""))
            {
                tabla_datos.ClearSelection();

                clase();

                n = tabla_datos.Rows.Add();
                //Asignamos el valor del textBox a la celda que 
                //corresponda de esa fila
                tabla_datos.Rows[n].Cells[0].Value = txt_nomMascota.Text;
                tabla_datos.Rows[n].Cells[1].Value = combo_raza.SelectedItem;
                tabla_datos.Rows[n].Cells[2].Value = sexo;
                tabla_datos.Rows[n].Cells[3].Value = txt_nomYape.Text;
                tabla_datos.Rows[n].Cells[4].Value = txt_ntelefono.Text;
                tabla_datos.Rows[n].Cells[5].Value = txt_observacion.Text;

                Reset();
                MessageBox.Show("Datos guardados correctamente.");
            }
            else
            {
                Reset();
                MessageBox.Show("Debe completar todos los campos", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Editardatos()
        {
            tabla_datos.Rows[n].Cells[0].Value = txt_nomMascota.Text;
            //tabla_datos.Rows[n].Cells[1].Value = combo_raza.SelectedItem;
            tabla_datos.Rows[n].Cells[2].Value = sexo;
            tabla_datos.Rows[n].Cells[3].Value = txt_nomYape.Text;
            tabla_datos.Rows[n].Cells[4].Value = txt_ntelefono.Text;
            tabla_datos.Rows[n].Cells[5].Value = txt_observacion.Text;

            Reset();
            btn_ingresar.Enabled = true;
        }

        private void tabla_datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_ingresar.Enabled = false;
            btn_editar.Enabled = true;
            try
            {
                txt_nomMascota.Text = tabla_datos.CurrentRow.Cells[0].Value.ToString();
                //combo_raza.SelectedItem = tabla_datos.CurrentRow.Cells[1].Value.ToString();
                sexo = tabla_datos.CurrentRow.Cells[2].Value.ToString();
                txt_nomYape.Text = tabla_datos.CurrentRow.Cells[3].Value.ToString();
                txt_ntelefono.Text = tabla_datos.CurrentRow.Cells[4].Value.ToString();
                txt_observacion.Text = tabla_datos.CurrentRow.Cells[5].Value.ToString();
            }
            catch { }
        }

        private void txt_ntelefono_KeyPress(object sender, KeyPressEventArgs e)
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
                    //el resto de teclas pulsadas se desactivan
                    e.Handled = true;
                }
        }

        private void txt_nomMascota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_nomYape_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_observacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        public void clase()
        {
           Veterinaria veterinaria = new Veterinaria() 
            {
                nomMascota = txt_nomMascota.Text,
                esp = combo_raza.Text,
                sex = Sexo.ToString(),
                nomYape = txt_nomYape.Text,
                Ntelefono = Convert.ToDouble(txt_ntelefono.Text),
                ob = txt_observacion.Text,
            };
        }


        public void datosrepetidos()
        {
            DialogResult verifica;

            bool exist = tabla_datos.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells["Nom_Mascotas"].Value) == txt_nomMascota.Text);
            bool exist2 = tabla_datos.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells["NomApe_Dueño"].Value) == txt_nomYape.Text);
            bool exist3 = tabla_datos.Rows.Cast<DataGridViewRow>().Any(row => Convert.ToString(row.Cells["Especie"].Value) == combo_raza.Text);

            if ((!exist) && (!exist2) && (!exist3))
            {
                Ingresardatos();
            }
            else if ((exist) && (exist2) && (exist3))
            {
                verifica = MessageBox.Show("Nombre de mascota y/o Dueño"+
                    "\nya existe..."+"\n\n¿Desea ingresarlo?","Advertencia",MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk);
                if (verifica == DialogResult.Yes)
                {
                    Ingresardatos();
                }
                else
                    Reset();

            }
            else
                Reset();
        }


    }
}
