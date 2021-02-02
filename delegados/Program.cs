using System;

namespace delegados
{
    class Program
    {
        //un delegado es un objeto que almacena una funcion
        public delegate void DelegadoEjemplo(int i, string s);
        static void Main(string[] args)
        {
            var delegado = new DelegadoEjemplo(Ejemplo2);
            Metodo(delegado,100,"hola");
            Console.WriteLine("----------------------");
            //un action define los parametros de entrada que tendra nuestro metodo
            Action<int, string> action = Ejemplo1;
            action(666,"numero del mal");

        }
        public static void Ejemplo1(int i, string s)
        { 
            Console.WriteLine($"estamos en un ejemplo 1");
            Console.WriteLine($"{i} {s}");
        }
        public static void Ejemplo2(int i, string s)
        {
            Console.WriteLine($"estamos en un ejemplo 2");
            Console.WriteLine($"{i} {s}");
        }
        public static void Metodo(DelegadoEjemplo delegadoEjemplo,int i,string s)
        {
            Console.WriteLine("hacer algo antes");
            Console.WriteLine("-------------------------");
            delegadoEjemplo(i,s);
            Console.WriteLine("-------------------------");
            Console.WriteLine("hacer algo despues");
        }
    }
}
