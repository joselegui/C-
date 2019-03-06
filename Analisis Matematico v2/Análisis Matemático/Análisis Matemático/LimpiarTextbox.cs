using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Análisis_Matemático
{
    class LimpiarTextbox
    {
        public void LimpiarText(Control control)
        {
            foreach (var texto in control.Controls)
            {
                if (texto is TextBox)
                    ((TextBox)texto).Clear();

            }
        }
    }
}
