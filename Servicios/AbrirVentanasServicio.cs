using RepasoExamen.Ventanas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamen.Servicios
{
    class AbrirVentanasServicio
    {
        public bool? AbrirInfoServicio()
        {
            InformacionWindow nuevaVentana = new InformacionWindow();
            return nuevaVentana.ShowDialog();
        }
    }
}
