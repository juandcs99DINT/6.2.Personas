using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.viewModels
{
    class AñadirNacionalidadVM : ObservableObject
    {
        public AñadirNacionalidadVM() { }

        private string nacionalidadNueva;
        public string NacionalidadNueva
        {
            get => nacionalidadNueva;
            set => SetProperty(ref nacionalidadNueva, value);
        }
    }
}
