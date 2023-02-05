using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using RepasoExamen.Mensajeria;
using RepasoExamen.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamen.VistasModelo
{
    class ComponenteControlVM : ObservableObject
    {
        //Propiedades
        private Componente componenteActual;

        public Componente ComponenteActual
        {
            get { return componenteActual; }
            set { SetProperty(ref componenteActual, value); }
        }
        public ComponenteControlVM()
        {
            WeakReferenceMessenger.Default.Register<ComponenteActualValueChangedMessage>(this, (r, m) =>
            {
                ComponenteActual = m.Value;
            });
        }
    }
}
