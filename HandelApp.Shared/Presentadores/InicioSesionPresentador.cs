using System;
using System.Collections.Generic;
using System.Text;
using HandelApp.Vistas;
using HandelApp.Modelos;
using HandelApp.Repositorios;
using HandelApp.Clases;

namespace HandelApp.Presentadores
{
    public class InicioSesionPresentador
    {
        private IInicioSesionVista vista;
        private Usuario usuario=null;
        public InicioSesionPresentador(IInicioSesionVista vista)
        {
            this.vista = vista;
        }

        public async void IniciarSesion()
        {
            UsuarioRepositorio repositorio = new UsuarioRepositorio();
            Resultado<Usuario> resultado = await repositorio.ConsultarAcceso(vista.Credenciales);
            if(resultado.MensajeError==string.Empty)
            {
                usuario = resultado.Valor;
                if (usuario != null)
                {
                    vista.MostrarMenu(usuario);
                    vista.MostrarMensaje("Bienvenido.");
                }
                else
                    vista.MostrarMensaje("La combinación de usuario y contraseña es incorrecta.");
            }
            else
                vista.MostrarMensaje(resultado.MensajeError);


        }
    }
}
