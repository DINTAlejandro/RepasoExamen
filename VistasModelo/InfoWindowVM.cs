using Microsoft.Toolkit.Mvvm.ComponentModel;
using RepasoExamen.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamen.VistasModelo
{
    class InfoWindowVM : ObservableObject
    {
        private string titulo;
        public string Titulo 
        {
            get { return titulo; }
            set { SetProperty(ref titulo, value); }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { SetProperty(ref nombre,value); }
        }

        public InfoWindowVM()
        {
            Nombre = Properties.Settings.Default.autor;
            Titulo = Properties.Settings.Default.titulo;
        }
    }
}
