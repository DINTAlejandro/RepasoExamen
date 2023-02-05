using RepasoExamen.Modelos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamen.Servicios
{
    class CargarComponentesServicio
    {
        public ObservableCollection<Componente> GetSamples()
        {
            var lista = new ObservableCollection<Componente>();
            lista.Add(new Componente("AMD Ryzen 7 5800X", "Procesador", "/Recursos/AMD_Ryzen_7_5800X.jpg", 452));
            lista.Add(new Componente("Intel Core i7-11700K", "Procesador", "/Recursos/Intel_Core_i7_11700K.jpg", 365));
            lista.Add(new Componente("Gainward 471056224", "Tarjeta", "/Recursos/Gainward_471056224.jpg", 1719));
            lista.Add(new Componente("ASUS ROG Maximus XIII Extreme", "/Recursos/Placa base", "ASUS_ROG_Maximus_XIII_Extreme.jpg", 976));
            lista.Add(new Componente("ASRock X570 Creator", "Placa base", "/Recursos/ASRock_X570_Creator.jpg", 512));
            return lista;
        }
    }
}
