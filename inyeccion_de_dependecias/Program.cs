using System;

namespace inyeccion_de_dependecias
{
    class Program
    {
        static void Main(string[] args)
        {
            EnviarCorreoConSendEmail sendEmail = new EnviarCorreoConSendEmail();
            EnviarCorreoConPlugin correoConPlugin = new EnviarCorreoConPlugin();
            //desacoplamos nuestra aplicacion, y ahorramos codigo
            EnviarCorreo enviarCorreo = new EnviarCorreo(correoConPlugin);
            enviarCorreo.EnvirarCorreo();


            Console.Read();
        }
    }
    //esta es la clase inyectadora
    class EnviarCorreo
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
    interface IEnviarCorreo
    {
        public void EnvirarCorreo();
    }
    class EnviarCorreoConSendEmail : IEnviarCorreo
    {
        public void EnvirarCorreo()
        {
            Console.WriteLine($"Enviando correo con : {nameof(EnviarCorreoConSendEmail)}");
        }
    }

    class EnviarCorreoConPlugin : IEnviarCorreo
    {
        public void EnvirarCorreo()
        {
            Console.WriteLine($"Enviando correo con : {nameof(EnviarCorreoConPlugin)}");
        }
    }
}
