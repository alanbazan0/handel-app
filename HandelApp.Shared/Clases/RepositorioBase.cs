using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using HandelApp.Clases;

namespace HandelApp.Clases
{
    public class RepositorioBase
    {
        public RepositorioBase()
        {
            HTTPParametros = new List<ParametroHTTP>();
            DireccionBase = Constantes.DIRECCION_BASE;

        }

		public RepositorioBase(string direccionBase,string url)
		{
            Url = url;
            DireccionBase = direccionBase;
            HTTPParametros = new List<ParametroHTTP>();
		}
    

        public void AgregarParametro(string nombre, string valor)
        {
            HTTPParametros.Add(new ParametroHTTP(nombre, valor));        
        }

        protected List<KeyValuePair<string, string>> GetParametros()
        {
            List<KeyValuePair<string, string>> parametros = new List<KeyValuePair<string, string>>();
			for (int i = 0; i < HTTPParametros.Count; i++)
            {
                ParametroHTTP httpParametros = HTTPParametros[i];
                KeyValuePair<string, string> parametro = new KeyValuePair<string, string>(httpParametros.Nombre, httpParametros.Valor);
                parametros.Add(parametro);

            }
            return parametros;
        }

        public string GetUrl(string archivo)
        {
            return Constantes.CARPETA + "/" + archivo;
        }
	
		public string Url
		{
			get;
			set;
		}

		public List<ParametroHTTP> HTTPParametros
		{
			get;
			set;
		}

        public string DireccionBase
        {
            get;
            set;
        }
      
    }
}
