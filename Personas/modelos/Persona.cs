using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.modelos
{
    public class Persona : ObservableObject
    {
        private string nombre;
        public string Nombre
        {
            get => nombre;
            set => SetProperty(ref nombre, value);
        }

        private int? edad;
        public int? Edad
        {
            get => edad;
            set => SetProperty(ref edad, value);
        }

        private string nacionalidad;
        public string Nacionalidad
        {
            get => nacionalidad;
            set => SetProperty(ref nacionalidad, value);
        }

        public Persona() { }
        public Persona(string nombre, int? edad, string nacionalidad)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.nacionalidad = nacionalidad;
        }
    }
}
