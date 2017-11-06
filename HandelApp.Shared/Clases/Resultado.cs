
namespace HandelApp.Clases
{
    public class Resultado<T>
    {
        public string MensajeError { get; set; }
        public T Valor { get; set; }
    }
}
