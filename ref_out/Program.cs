using System;

namespace ref_out
{
    class Program
    {
        static void Main(string[] args)
        {

            Cerveza cerveza = new Cerveza("Cuzqueña");
            Console.WriteLine("TIPO REFERENCIA");
            Console.WriteLine("antes del cambio: ");
            Console.WriteLine(cerveza.Nombre);
            Console.WriteLine("despues del cambio: ");
            EditarCerveza(cerveza,"Pilsen");
            Console.WriteLine(cerveza.Nombre);

            Console.WriteLine("----------------------------------------------");

            int numero = 1;
            int numer2 = 2;
            Console.WriteLine("TIPO Valor");
            Console.WriteLine("antes del cambio: ");
            Console.WriteLine(numero);
            Console.WriteLine("despues del cambio: ");
            EditarNumero(ref numer2, out numero);
            Console.WriteLine(numero);

            Console.Read();

        }
        //los tipos valor nesecitan la clausula REF o OUT
        //REF no nesecita un valor asignado antes de enviarle al metodo
        //OUT nesecita que le asignen un valor antes de enviarlo al metodo
        private static void EditarNumero(ref int numero,out int v)
        {
            v = numero;
        }
        //las clases se pasan por referencia
        private static void EditarCerveza(Cerveza cerveza, string nombre)
        {
            cerveza.Nombre = nombre;
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

}
