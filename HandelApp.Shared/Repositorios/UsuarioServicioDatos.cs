using HandelApp.Clases;
using HandelApp.DataAccess;
using HandelApp.Modelos;
using System.Threading.Tasks;

namespace HandelApp.Presenters
{
    public class UsuarioRepositorio
    {
        public UsuarioRepositorio()
        {
        }

        public async Task<Usuario> Consultar(string id, string contrasena)
        {
            //Repositorio<Usuario> servicioDatos = new Repositorio<Usuario>(Constantes.DIRECCION_BASE, "/BastiaanSoftwareCenter/php/repositorios/Usuarios.php");
            //servicioDatos.AgregarParametro("accion", "consultarPorIdContrasena");
            //servicioDatos.AgregarParametro("id", id);
            //servicioDatos.AgregarParametro("contrasena", contrasena);
            ////servicioDatos.Metodo = MetodoHTTP.POST;
            //Usuario usuario = await servicioDatos.Ejecutar();
            //return usuario;
            return null;

        }
    }
}