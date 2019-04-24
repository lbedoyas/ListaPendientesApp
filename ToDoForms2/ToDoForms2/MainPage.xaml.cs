using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ToDoForms2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(usuarioEntry.Text) || string.IsNullOrEmpty(passwordEntry.Text))
            {
                resultadoLabel.Text = "Debe escribir usuario y contraseña";
            }
            else
            {
                resultadoLabel.Text = "Inicio de Session exitoso";
                await Navigation.PushAsync(new ListaTareas());
            }
        }
    }
}
