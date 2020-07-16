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
    public partial class frm_ejercicio10_1 : Form
    {
        Persona persona = new Persona();
        String detalle = "{0,-20}{1,-20}{2,-20}{3,-16}";
        //String Nom, Ape, Ed, Se;

        public frm_ejercicio10_1()
        {
            InitializeComponent();
        }

        private void frm_ejercicio10_1_Load(object sender, EventArgs e)
        {
            txtNombre.Select();
            listaPersonas.Items.Add(String.Format(detalle, "Nombre ", "  Apellido ", "  Edad ", "  Sexo "));
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Repetidos();
            txtNombre.Select();
        }


        private void btn_contador_Click(object sender, EventArgs e)
        {
            SumargenerosFemenino();
            SumargeneroMasculino();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogo = MessageBox.Show("Desea eliminar al usuario seleccionado ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogo == DialogResult.Yes)
            {
                MessageBox.Show("Se ha eliminado a: " + listaPersonas.SelectedItem);
                listaPersonas.Items.Remove(listaPersonas.SelectedItem);
            }
            
            txtNombre.Select();
        }


        private void Ingresardatos()
        {

            int edad = 17;
            int calcular;
            persona.Edad = int.Parse(txt_edad.Text);
            calcular = persona.CalcularEdad(edad);

            if (calcular > 17)
            {

                persona.nom = txtNombre.Text;
                persona.ap = txtApellido.Text;



                if (rbF.Checked)
                {
                    persona.sex = rbF.Text;
                }
                else
                {
                    persona.sex = rbM.Text;
                }

                listaPersonas.Items.Add(String.Format(detalle, persona.nom, persona.ap, persona.Edad, persona.sex));
            }
            Borrarcuadrosdetexto();
        }


        private void Borrarcuadrosdetexto()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txt_edad.Clear();
            rbF.Checked = false;
            rbM.Checked = false;
        }

        private void txt_edad_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
       
         
        //Calcular Femeninos
        private void SumargenerosFemenino()
        {
            listaPersonas.SelectedItems.Clear();

            for (int i = listaPersonas.Items.Count - 1; i >= 0; i--) 
            {
                if (listaPersonas.Items[i].ToString().ToLower().Contains(rbF.Text.ToLower()))
                {
                    listaPersonas.SetSelected(i,true);
                    lbl_mujeres.Text = "Son: " + listaPersonas.SelectedItems.Count.ToString();
                }
                
            }   
            
        }
        //Calcular Masculinos 
        private void SumargeneroMasculino()
        {
            listaPersonas.SelectedItems.Clear();

            for (int j = listaPersonas.Items.Count - 1; j >= 0; j--)
            {
                if (listaPersonas.Items[j].ToString().ToLower().Contains(rbM.Text.ToLower()))
                {
                    listaPersonas.SetSelected(j, true);
                    lbl_barones.Text = "Son: " + listaPersonas.SelectedItems.Count.ToString();
                    //lbl_barones.Text = "Son: " + listaPersonas.SelectedItems.Count.ToString();
                }

            }   
        }

        private void Repetidos()
        {
            bool repetidos = false;

            foreach(var items in listaPersonas.Items)
            {
                if((items.ToString().Contains(txtNombre.Text)) && (items.ToString().Contains(txtApellido.Text)))
                {
                    repetidos = true;
                }
            }

            if (repetidos)
            {
                MessageBox.Show("Esta persona ya esta ingresado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Borrarcuadrosdetexto();
                txtNombre.Select();
            }
            else
            {
                Ingresardatos();
                txtNombre.Select();
            }

        }
        
    }
}
