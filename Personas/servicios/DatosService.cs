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
        private readonly ObservableCollection<string> listaNacionalidades;
        private readonly ObservableCollection<Persona> listaPersonas;
        public DatosService()
        {
            listaNacionalidades = RellenarListaNacionalidades();
            listaPersonas = RellenarListaPersonas();
        }

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

        public void AñadirNacionalidad(string nacionalidad) => listaNacionalidades.Add(nacionalidad);
        public void AñadirPersona(Persona persona) => listaPersonas.Add(persona);

        public ObservableCollection<string> GetNacionalidades() => listaNacionalidades;
        public ObservableCollection<Persona> GetPersonas() => listaPersonas;
    }
}
