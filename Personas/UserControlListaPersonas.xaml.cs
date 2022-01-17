﻿using System;
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
    /// Lógica de interacción para UserControlListaPersonas.xaml
    /// </summary>
    public partial class UserControlListaPersonas : UserControl
    {

        private UserControlListaPersonasVM vm;

        public UserControlListaPersonas()
        {
            InitializeComponent();
            vm = new UserControlListaPersonasVM();
            this.DataContext = vm;
        }
    }
}
