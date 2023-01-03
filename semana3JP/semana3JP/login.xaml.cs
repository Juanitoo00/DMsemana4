using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace semana3JP
{
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        void btnIniciar_Clicked(System.Object sender, System.EventArgs e)
        {
            string usuario = "estudiante2022";
            string contrasena = "uisrael2022";
            if (usuario == Usuario.Text && contrasena == Password.Text)
            {

                Navigation.PushAsync(new Registro(usuario));
            }
            else
            {
                DisplayAlert("Aletra", "USUARIO/CONTRASEÑA INCORRECTA","cerrar");
            }

        }

        void btnRegistro_Clicked(System.Object sender, System.EventArgs e)
        {
            string usuario = "";
            Navigation.PushAsync(new Registro(usuario));
        }
    }
}

