using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas
{
    class MainWindowVM : ObservableObject
    {
        public RelayCommand MostrarNuevaPersonaCommand { get; }

        public RelayCommand MostrarListaPersonasCommand { get; }

        private UserControl opcion;

        public UserControl Opcion
        {
            get { return opcion; }
            set { SetProperty(ref opcion, value); }
        }

       

        private ServicioNavegacion servicio;

        public MainWindowVM()
        {
            MostrarNuevaPersonaCommand = new RelayCommand(MostrarNuevaPersona);
            MostrarListaPersonasCommand = new RelayCommand(MostrarListaPersonas);
            servicio = new ServicioNavegacion();
        }

        private void MostrarNuevaPersona()
        {
            Opcion = servicio.MostrarNuevaPersona();
        }

        private void MostrarListaPersonas()
        {
            Opcion = servicio.MostrarListaPersonas();
        }
    }
}
