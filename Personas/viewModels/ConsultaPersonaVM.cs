using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using Personas.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.viewModels
{
    class ConsultaPersonaVM : ObservableRecipient
    {
        public ConsultaPersonaVM()
        {
            PersonaConsulta = WeakReferenceMessenger.Default.Send<PersonaConsultaMessage>();
        }

        private Persona personaConsulta;
        public Persona PersonaConsulta
        {
            get => personaConsulta;
            set => SetProperty(ref personaConsulta, value);
        }
    }
}
