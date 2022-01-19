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
    public partial class ConsultaPersona : UserControl
    {
        private readonly ConsultaPersonaVM vm;
        public ConsultaPersona()
        {
            vm = new ConsultaPersonaVM();
            this.DataContext = vm;
            InitializeComponent();
        }
    }
}
