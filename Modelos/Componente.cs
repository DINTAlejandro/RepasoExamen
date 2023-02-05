using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamen.Modelos
{
    public class Componente
    {
        public string Nombre { get; set; }

        public string Tipo { get; set; }

        public string Foto { get; set; }

        public int Precio { get; set; }

        public Componente(string nombre, string tipo, string foto, int precio)
        {
            this.Nombre = nombre;
            this.Tipo = tipo;
            this.Foto = foto;
            this.Precio = precio;
        }
    }
}
