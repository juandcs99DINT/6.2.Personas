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
    public partial class ListadoPersonas : UserControl
    {
        private readonly ListadoPersonasVM vm;
        public ListadoPersonas()
        {
            vm = new ListadoPersonasVM();
            this.DataContext = vm;
            InitializeComponent();
        }
    }
}
