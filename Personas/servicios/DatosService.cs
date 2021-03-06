using Personas.modelos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.servicios
{
    class DatosService
    {
        public DatosService() { }

        public ObservableCollection<Persona> RellenarListaPersonas()
        {
            return new ObservableCollection<Persona>()
            {
                new Persona("Pietro", 30, "Italiana"),
                new Persona("Julia", 25, "Española"),
                new Persona("Sophie", 35, "Francesa")
            };
        }
        public ObservableCollection<string> RellenarListaNacionalidades()
        {
            return new ObservableCollection<string>()
            {
               "Italiana", "Española", "Francesa"
            };
        }
    }
}
