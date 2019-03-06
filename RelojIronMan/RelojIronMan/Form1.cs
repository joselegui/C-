using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RelojIronMan
{
    public partial class Form1 : Form
    {

        Point Posiciondelformulario;
        Boolean mouse;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("HH:mm");
            labelSegundos.Text = DateTime.Now.ToString("ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

            toolTip1.SetToolTip(this.butSalir, "Salir");
            toolTip1.SetToolTip(this.button1, "Mascara 1");
            toolTip1.SetToolTip(this.button2, "Mascara 2");
            toolTip1.SetToolTip(this.button3, "Mascara 3");
            toolTip1.SetToolTip(this.button4, "Mascara 4");
        }
        private void butSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           this.BackgroundImage = Properties.Resources.iron_man_png;     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.LziFSQN;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Iron_Man__1_;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.AoU_Iron_Man_Mk43_art;
        }

        private void Form1_MouseDown_1(object sender, MouseEventArgs e)
        {
            Posiciondelformulario = new Point(Cursor.Position.X - Location.X, Cursor.Position.Y - Location.Y);
            mouse = true;
        }

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mouse == true)
            {
                Location = new Point(Cursor.Position.X - Posiciondelformulario.X, Cursor.Position.Y - Posiciondelformulario.Y);
            }
        }

        private void Form1_MouseUp_1(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void labelHora_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
