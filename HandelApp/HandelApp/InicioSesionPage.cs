using System;

using Xamarin.Forms;

namespace HandelApp
{
    public class InicioSesionPage : ContentPage
    {
        public InicioSesionPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

