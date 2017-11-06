using System;
using System.Collections.Generic;

using Xamarin.Forms;
using HandelApp.Presentadores;
using HandelApp.Vistas;
using HandelApp.Modelos;

namespace HandelApp
{
    public partial class InicioSesionPage : ContentPage, IInicioSesionVista
    {
        InicioSesionPresentador presentador;

       
        public object Credenciales 
        {
            get
            {
                var credenciales = new
                {
                    id = idEntry.Text,
                    contrasena = contrasenaEntry.Text
                };
                return credenciales;
            }
        }

        public InicioSesionPage()
        {
            InitializeComponent();
            presentador = new InicioSesionPresentador(this);
        }
       
        void OnIniciarSesionButtonClicked(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        public void IniciarSesion()
        {
            mensajeLabel.Text = "";
            presentador.IniciarSesion();
        }

        public void MostrarMenu(Usuario usuario)
        {
            
        }

        public void MostrarMensaje(string mensaje)
        {
            mensajeLabel.Text = mensaje;
        }

   
    }
}
