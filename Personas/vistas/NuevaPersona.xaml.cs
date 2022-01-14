using Personas.viewModels;
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

namespace Personas.vistas
{
    /// <summary>
    /// Lógica de interacción para NuevaPersona.xaml
    /// </summary>
    public partial class NuevaPersona : UserControl
    {
        private readonly NuevaPersonaVM vm;
        public NuevaPersona()
        {
            vm = new NuevaPersonaVM();
            this.DataContext = vm;
            InitializeComponent();
        }
    }
}
