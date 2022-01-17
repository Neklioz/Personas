using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Personas
{
    /// <summary>
    /// Lógica de interacción para UserControlNuevaPersona.xaml
    /// </summary>
    public partial class UserControlNuevaPersona : UserControl
    {

        private UserControlNuevaPersonaVM vm;

        public UserControlNuevaPersona()
        {
            InitializeComponent();
            vm = new UserControlNuevaPersonaVM();
            this.DataContext = vm;
        }
    }
}
