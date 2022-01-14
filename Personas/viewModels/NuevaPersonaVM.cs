using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Personas.servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.viewModels
{
    class NuevaPersonaVM : ObservableObject
    {
        private readonly DatosService datosService;
        private readonly NavigationService navigationService;
        public NuevaPersonaVM()
        {
            navigationService = new NavigationService();
            AñadirNacionalidadCommand = new RelayCommand(AbrirVentanaAñadirNacionalidad);
            datosService = new DatosService();
            ListaNacionalidades = datosService.RellenarListaNacionalidades();
        }

        public RelayCommand AñadirNacionalidadCommand { get; }

        private ObservableCollection<string> listaNacionalidades;
        public ObservableCollection<string> ListaNacionalidades
        {
            get => listaNacionalidades;
            set => SetProperty(ref listaNacionalidades, value);
        }
        public void AbrirVentanaAñadirNacionalidad() => navigationService.AbrirVentanaNacionalidad();
    }
}