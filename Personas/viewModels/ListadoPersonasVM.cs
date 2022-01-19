using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
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
            ListaPersonas = datosService.GetPersonas();
            EsperarPersonaNueva();
            EnviarPersonaSeleccionada();
        }

        private ObservableCollection<Persona> listaPersonas;
        public ObservableCollection<Persona> ListaPersonas
        {
            get => listaPersonas;
            set => SetProperty(ref listaPersonas, value);
        }

        private Persona personaSeleccionada;
        public Persona PersonaSeleccionada
        {
            get => personaSeleccionada;
            set => SetProperty(ref personaSeleccionada, value);
        }

        public void EsperarPersonaNueva()
        {
            WeakReferenceMessenger.Default.Register<PersonaAñadidaMessage>(this, (r, m) =>
            {
                datosService.AñadirPersona(m.Value);
                ListaPersonas = datosService.GetPersonas();
            });
        }

        public void EnviarPersonaSeleccionada()
        {
            WeakReferenceMessenger.Default.Register<ListadoPersonasVM, PersonaConsultaMessage>
                (this, (r, m) =>
                {
                    m.Reply(r.PersonaSeleccionada);
                });
        }
    }
}
