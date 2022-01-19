using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using Personas.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class Mensajes
    {
        public class NacionalidadAñadidaMessage : ValueChangedMessage<string>
        {
            public NacionalidadAñadidaMessage(string nacionalidad) : base(nacionalidad) { }
        }

        public class PersonaAñadidaMessage : ValueChangedMessage<Persona>
        {
            public PersonaAñadidaMessage(Persona persona) : base(persona) { }
        }

        public class PersonaConsultaMessage : RequestMessage<Persona> { }
    }
}
