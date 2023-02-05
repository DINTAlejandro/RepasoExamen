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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RepasoExamen.Controles
{
    /// <summary>
    /// Lógica de interacción para ComponenteControl.xaml
    /// </summary>
    public partial class ComponenteControl : UserControl
    {
        private ComponenteControlVM vm;
        public ComponenteControl()
        {
            InitializeComponent();
            vm = new ComponenteControlVM();
            this.DataContext = vm;
        }
    }
}
