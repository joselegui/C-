using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuiaN10
{
    class Persona
    {
        private string Nombre, Apellido, Sexo;
        public int Edad;


        public Persona()
        {

        }

        public string nom
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public string ap
        {
            get { return Apellido; }
            set { Apellido = value; }
        }

        public string sex
        {
            get { return Sexo; }
            set { Sexo = value; }
        }

        public int e
        {
            get { return Edad; }
            set { Edad = value; }
        }

        public int CalcularEdad(int ed) 
        {
            if (Edad <= ed)
            {
                System.Windows.Forms.MessageBox.Show("Deve ser mayor de edad, para registrarse");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Persona registrado satifactoriamente...");
            }
            return Edad;
        }

    }
}
