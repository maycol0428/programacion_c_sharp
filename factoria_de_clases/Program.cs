using System;

namespace factoria_de_clases
{
    class Program
    {
        static EnviarCorreo _enviarCorreo;
        static void Main(string[] args)
        {
            
            _enviarCorreo = new EnviarCorreo(FactoriaEnviarCorreo.Factoria(nameof(EnviarCorreoConSendEmail)));

            _enviarCorreo.EnvirarCorreo();
            Console.Read();

            
        }

    }

    //quitamos la responsabilidad de las instancias a nuestra clase Main
    public static class FactoriaEnviarCorreo{
    
        public static IEnviarCorreo Factoria(string tipoCorreo)
        {
            if (tipoCorreo == nameof(EnviarCorreoConSendEmail))
            {
                return new EnviarCorreoConSendEmail();
            }
            else if(tipoCorreo == nameof(EnviarCorreoConPluginPrueba))
            {
                return new EnviarCorreoConPluginPrueba();
            }
            else
            {
                throw new ApplicationException();
            }
        }
    }

    //esta es la clase inyectadora
    public class EnviarCorreo
    {
        private readonly IEnviarCorreo _enviarCorreo;
        //por defecto usara Send Email
        public EnviarCorreo()
        {
            _enviarCorreo = new EnviarCorreoConSendEmail();
        }
        //usara la clase que le pasemos por el contrucctor sobre cargado
        public EnviarCorreo(IEnviarCorreo enviarCorreo)
        {
            _enviarCorreo = enviarCorreo;
        }

        public void EnvirarCorreo()
        {
            _enviarCorreo.EnvirarCorreo();
        }
    }
    public interface IEnviarCorreo
    {
        public void EnvirarCorreo();
    }
    public class EnviarCorreoConSendEmail : IEnviarCorreo
    {
        public void EnvirarCorreo()
        {
            Console.WriteLine($"Enviando correo con : {nameof(EnviarCorreoConSendEmail)}");
        }
    }

    public class EnviarCorreoConPluginPrueba : IEnviarCorreo
    {
        public void EnvirarCorreo()
        {
            Console.WriteLine($"Enviando correo con : {nameof(EnviarCorreoConPluginPrueba)}");
        }
    }
}