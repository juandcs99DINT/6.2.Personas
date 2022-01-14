using Personas.vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas.servicios
{
    class NavigationService
    {
        private readonly UserControl listadoPersonas;
        public NavigationService()
        {
            listadoPersonas = new ListadoPersonas();
        }

        public UserControl CambiarANuevaPersona() => new NuevaPersona();
        public UserControl CambiarAListado() => listadoPersonas;

        public void AbrirVentanaNacionalidad()
        {
            AñadirNacionalidad añadirNacionalidad = new AñadirNacionalidad();
            añadirNacionalidad.ShowDialog();
        }
    }
}
