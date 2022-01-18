using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
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
    class NuevaPersonaVM : ObservableObject
    {
        private readonly DatosService datosService;
        private readonly NavigationService navigationService;
        public NuevaPersonaVM()
        {
            AñadirNacionalidadCommand = new RelayCommand(AbrirVentanaAñadirNacionalidad);
            AceptarFormularioCommand = new RelayCommand(AceptarFormulario);
            navigationService = new NavigationService();
            datosService = new DatosService();
            ListaNacionalidades = datosService.RellenarListaNacionalidades();
        }

        public RelayCommand AñadirNacionalidadCommand { get; }
        public RelayCommand AceptarFormularioCommand { get; }

        private ObservableCollection<string> listaNacionalidades;
        public ObservableCollection<string> ListaNacionalidades
        {
            get => listaNacionalidades;
            set => SetProperty(ref listaNacionalidades, value);
        }

        private Persona nuevaPersona;
        public Persona NuevaPersona
        {
            get => nuevaPersona;
            set => SetProperty(ref nuevaPersona, value);
        }

        public void AbrirVentanaAñadirNacionalidad() => navigationService.AbrirVentanaNacionalidad();
        public void AceptarFormulario() { }
    }
}