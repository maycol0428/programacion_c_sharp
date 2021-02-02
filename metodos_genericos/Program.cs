using Newtonsoft.Json;
using System;

namespace metodos_genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Cerveza cerveza = new Cerveza("Cuzqueña");
            Vino vino = new Vino("La Quincha");

            var result = Serilizar(cerveza);

            Console.Read();
        }

        private static string Serilizar<T>(T clase)
        {
            string serializado = JsonConvert.SerializeObject(clase);
            return serializado;
        }
    }

    public class Cerveza
    {
        public Cerveza(string nombre)
        {
            Nombre = nombre;
        }
        public string Nombre { get; set; }
    }

    public class Vino
    {
        public Vino(string nombre)
        {
            Nombre = nombre;
        }
        public string Nombre { get; set; }
    }
}
