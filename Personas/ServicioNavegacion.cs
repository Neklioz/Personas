using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas
{
    class ServicioNavegacion
    {
        internal UserControl MostrarNuevaPersona()
        {
            return new UserControlNuevaPersona();
        }

        internal UserControl MostrarListaPersonas()
        {
            return new UserControlListaPersonas();
        }
    }
}
