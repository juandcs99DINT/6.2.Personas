using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.viewModels
{
    class AñadirNacionalidadVM : ObservableObject
    {
        public AñadirNacionalidadVM()
        {
            AceptarCommand = new RelayCommand(Aceptar);
        }

        public RelayCommand AceptarCommand { get; }

        private string nacionalidadNueva;
        public string NacionalidadNueva
        {
            get => nacionalidadNueva;
            set => SetProperty(ref nacionalidadNueva, value);
        }

        public void Aceptar() => WeakReferenceMessenger.Default.Send(new NacionalidadAñadidaMessage(NacionalidadNueva));
        

    }
}
