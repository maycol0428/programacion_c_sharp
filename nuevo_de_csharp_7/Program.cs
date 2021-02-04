using System;

namespace nuevo_de_csharp_7
{
    class Program
    {
        static void Main(string[] args)
        {
            BebidasAlcholicas b1 = new Cerveza();
            b1.nombre = "Brama";
            BebidasAlcholicas b2 = new Vino();
            b2.nombre = "Cristañ";
            //comprueba si es una clase y la instancia si es verdadera           
            if (b1 is Cerveza cerveza)
            {
                Console.WriteLine("si es una cerveza");
                Console.WriteLine(cerveza.nombre);
                Console.WriteLine(cerveza.FullNombre);
            }
            //variables out
            if (DateTime.TryParse("2019-04-20",out DateTime result))
            {
                Console.WriteLine(result);
            }
            
        }
    }
    class BebidasAlcholicas
    {
        public string nombre { get; set; }
        //expresiones en metodos o proppiedades
        public string FullNombre => $"{nombre} esta bien helada y barata";
    }

    class Cerveza : BebidasAlcholicas
    {

    }

    class Vino : BebidasAlcholicas
    {

    }
}
