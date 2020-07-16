using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuiaN10
{
    class Veterinaria
    {
        private string NombreMascota, NombreyApellido, Sexo, Especie,Observacion;
        public double Ntelefono;


        public Veterinaria()
        {

        }

        public string nomMascota
        {
            get { return NombreMascota; }
            set { NombreMascota = value; }
        }

        public string nomYape
        {
            get { return NombreyApellido; }
            set { NombreyApellido = value; }
        }

        public string sex
        {
            get { return Sexo; }
            set { Sexo = value; }
        }

        public string esp
        {
            get { return Especie; }
            set { Especie = value; }
        }

        public string ob
        {
            get { return Observacion; }
            set { Observacion = value; }
        }

        public double tel
        {
            get { return Ntelefono; }
            set { Ntelefono = value; }
        }
     
    }
}
