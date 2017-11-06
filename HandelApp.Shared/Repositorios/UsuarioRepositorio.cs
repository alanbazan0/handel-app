using HandelApp.Clases;
using HandelApp.Modelos;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;


namespace HandelApp.Repositorios
{
    public class UsuarioRepositorio :RepositorioBase
    {
        public UsuarioRepositorio()
        {
        }

        public async Task<Resultado<Usuario>> ConsultarAcceso(object credenciales)
        {
            Resultado<Usuario> datos = new Resultado<Usuario>();           
            Url = GetUrl("Usuarios.php");
            AgregarParametro("accion", "consultarAcceso");
            AgregarParametro("credenciales", JsonConvert.SerializeObject(credenciales));
            try
            {
                using (var cliente = new HttpClient())
                {
                    cliente.BaseAddress = new Uri(DireccionBase);
                    List<KeyValuePair<string, string>> parametros = GetParametros();
                    var contenido = new FormUrlEncodedContent(parametros);
                    var resultado = await cliente.PostAsync(Url, contenido);
                    string resultadoContenido = await resultado.Content.ReadAsStringAsync();
                    datos = JsonConvert.DeserializeObject<Resultado<Usuario>>(resultadoContenido);
    
                }
            }
            catch (Exception ex)
            {
                datos.MensajeError = ex.Message;
                Console.Out.WriteLine(ex.Message);
            }
            return datos;
        }
    }


}