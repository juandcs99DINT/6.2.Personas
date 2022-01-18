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
using System.Windows.Shapes;

namespace Personas.vistas
{
    /// <summary>
    /// Lógica de interacción para AñadirNacionalidad.xaml
    /// </summary>
    public partial class AñadirNacionalidad : Window
    {
        private readonly AñadirNacionalidadVM vm;
        public AñadirNacionalidad()
        {
            vm = new AñadirNacionalidadVM();
            this.DataContext = vm;
            InitializeComponent();
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e) => DialogResult = true;
    }
}
