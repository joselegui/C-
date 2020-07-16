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
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void pic_docentes_Click(object sender, EventArgs e)
        {
            Deslizar.Start();
            pic_docentes.Hide();
        }

        private void Deslizar_Tick(object sender, EventArgs e)
        {
            pic_personas.Left -=7;
            pic_estudiantes.Left -= 7;

            if(pic_personas.Left <= 45)
            {
                Deslizar.Stop();
                DeslizarPanel.Start();
            }
        }

        private void DeslizarPanel_Tick(object sender, EventArgs e)
        {
            panelExit.Top -= 2;
            panelInformacion.Top -= 2;

            if (panelInformacion.Top <= 336)
            {
                DeslizarPanel.Stop();
                desPanelhora.Start();
            }
        }

        private void desPanelhora_Tick(object sender, EventArgs e)
        {
            panelHora.Top -= 3;

            if(panelHora.Top <= 280)
            {
                desPanelhora.Stop();
            }
        }

        private void pic_personas_Click(object sender, EventArgs e)
        {
            frm_ejemplo ejemplo = new frm_ejemplo();
            ejemplo.ShowDialog();
        }

        private void pic_estudiantes_Click(object sender, EventArgs e)
        {
            frm_ejercicio ejercicio = new frm_ejercicio();
            ejercicio.ShowDialog();
        }

        private void lbl_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_informacion_Click(object sender, EventArgs e)
        {
            frm_mensaje mensaje = new frm_mensaje();
            mensaje.ShowDialog();
        }

        private void Hora_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void frm_principal_Load(object sender, EventArgs e)
        {

        }



        
    }
}
