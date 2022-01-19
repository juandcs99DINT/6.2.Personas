﻿using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using Personas.modelos;
using Personas.servicios;
using System.Collections.ObjectModel;
using static Personas.Mensajes;

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
            NuevaPersona = new Persona();
            ListaNacionalidades = datosService.GetNacionalidades();
            RegistrarNacionalidadNueva();
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
        public void RegistrarNacionalidadNueva()
        {
            WeakReferenceMessenger.Default.Register<NacionalidadAñadidaMessage>(this, (r, m) =>
            {
                datosService.AñadirNacionalidad(m.Value);
                ListaNacionalidades = datosService.GetNacionalidades();
            });
        }
        public void AceptarFormulario() => WeakReferenceMessenger.Default.Send(new PersonaAñadidaMessage(NuevaPersona));
    }
}