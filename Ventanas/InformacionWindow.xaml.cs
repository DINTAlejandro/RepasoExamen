using RepasoExamen.VistasModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RepasoExamen.Ventanas
{
    /// <summary>
    /// Lógica de interacción para InformacionWindow.xaml
    /// </summary>
    public partial class InformacionWindow : Window
    {
        private InfoWindowVM vm;
        public InformacionWindow()
        {
            InitializeComponent();
            vm = new InfoWindowVM();
            this.DataContext = vm;
        }
    }
}
