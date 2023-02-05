using RepasoExamen.Controles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace RepasoExamen.Servicios
{
    class CargarControlServicio
    {
        public UserControl CargarComponenteControl()
        {
            return new ComponenteControl();
        }
    }
}
