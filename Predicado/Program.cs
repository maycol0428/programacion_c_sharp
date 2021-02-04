using System;

namespace Predicado
{
    class Program
    {
        static void Main(string[] args)
        {
            //pasamos el metodo al predicado 
            Predicate<Cerveza> predicado = EsPilsen;
            Cerveza cerveza = new Cerveza();
            cerveza.Nombre = "Pilsen";

            Console.WriteLine(predicado(cerveza));

            Console.Read();
        }

        private static bool EsPilsen(Cerveza obj)
        {
            return obj.Nombre == "Pilsen" ? true : false;
        }
    }

    class Cerveza
    {

        public string Nombre { get; set; }
    }
}
