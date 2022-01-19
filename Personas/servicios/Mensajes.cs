﻿using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using Personas.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    class NacionalidadAñadidaMessage : ValueChangedMessage<string>
    {
        public NacionalidadAñadidaMessage(string nacionalidad) : base(nacionalidad) { }
    }
    class PersonaAñadidaMessage : ValueChangedMessage<Persona>
    {
        public PersonaAñadidaMessage(Persona persona) : base(persona) { }
    }
    class PersonaConsultaMessage : RequestMessage<Persona> { }

}