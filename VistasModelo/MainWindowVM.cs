using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using RepasoExamen.Mensajeria;
using RepasoExamen.Modelos;
using RepasoExamen.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace RepasoExamen.VistasModelo
{
    class MainWindowVM : ObservableRecipient
    {
        //Comandos
        public RelayCommand ConsultarCommand { get; }

        //Propiedades


        private Componente componenteActual;

        public Componente ComponenteActual
        {
            get { return componenteActual; }
            set { SetProperty(ref componenteActual, value); }
        }

        private UserControl vistaActual;

        public UserControl VistaActual
        {
            get { return vistaActual; }
            set { SetProperty(ref vistaActual, value); }
        }

        private ObservableCollection<Componente> componentes;

        public ObservableCollection<Componente> Componentes
        {
            get { return componentes; }
            set { SetProperty(ref componentes, value); }
        }

        //Servicios
        private CargarControlServicio cargarControlServicio;
        private CargarComponentesServicio servicioCargarComonentes;

        public MainWindowVM()
        {
            //Servicios
            servicioCargarComonentes = new CargarComponentesServicio();
            cargarControlServicio = new CargarControlServicio();
            //Propiedades
            ComponenteActual = null;
            Componentes = servicioCargarComonentes.GetSamples();
            VistaActual = cargarControlServicio.CargarComponenteControl();

            //Comandos
            ConsultarCommand = new RelayCommand(Consultar);

            
        }

        private void Consultar()
        {
            WeakReferenceMessenger.Default.Send(new ComponenteActualValueChangedMessage(ComponenteActual));
        }

    }
}
