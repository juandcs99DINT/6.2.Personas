using Microsoft.Toolkit.Mvvm.ComponentModel;
using Personas.modelos;
using Personas.servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.viewModels
{
    class ListadoPersonasVM : ObservableObject
    {
        public DatosService datosService;
        public ListadoPersonasVM()
        {
            datosService = new DatosService();
            ListaPersonas = datosService.RellenarListaPersonas();
        }

        private ObservableCollection<Persona> listaPersonas;
        public ObservableCollection<Persona> ListaPersonas
        {
            get => listaPersonas;
            set => SetProperty(ref listaPersonas, value);
        }
    }
}
