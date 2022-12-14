using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace semana3JP
{
    public partial class Registro : ContentPage
    {
        public Registro( String usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }
    }
}

