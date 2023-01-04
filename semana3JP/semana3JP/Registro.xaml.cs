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

        void btnCalcular_Clicked(System.Object sender, System.EventArgs e)
        {

            double precio = Convert.ToDouble(txtPrecio.Text);
            int cantiad = Convert.ToInt32(txtCantidad.Text);
            double valor = precio * cantiad;

            DisplayAlert("valor total del producto", valor.ToString(), "Cancelar");
        }
    }
}

