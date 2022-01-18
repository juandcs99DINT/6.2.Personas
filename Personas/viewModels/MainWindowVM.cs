using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Personas.servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas.viewModels
{
    class MainWindowVM : ObservableObject
    {
        private readonly NavigationService navigationService;
        public MainWindowVM()
        {
            navigationService = new NavigationService();
            CambiarANuevaPCommand = new RelayCommand(CambiarANuevaPersona);
            CambiarAListadoCommand = new RelayCommand(CambiarAListado);
        }

        private UserControl userControlActual;
        public UserControl UserControlActual
        {
            get => userControlActual;
            set => SetProperty(ref userControlActual, value);
        }

        public RelayCommand CambiarANuevaPCommand { get; }
        public RelayCommand CambiarAListadoCommand { get; }
        public void CambiarANuevaPersona() => UserControlActual = navigationService.CambiarANuevaPersona();
        public void CambiarAListado() => UserControlActual = navigationService.CambiarAListado();
    }
}
