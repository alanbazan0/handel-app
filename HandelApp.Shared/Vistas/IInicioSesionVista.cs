using HandelApp.Modelos;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandelApp.Vistas
{
    public interface IInicioSesionVista
    {
        void IniciarSesion();
        void MostrarMenu(Usuario usuario);
        void MostrarMensaje(string mensaje);
        object Credenciales { get; }
    }
}
