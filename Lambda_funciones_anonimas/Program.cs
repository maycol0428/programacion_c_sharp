using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_funciones_anonimas
{
    class Program
    {
        private static int cervezasQueNoSonCristal;

        static void Main(string[] args)
        {
            //Func<int,int> suma = x => { return x + 2; };
            //func con varios parametros de entrada
            //Func<int,int, int> multiplicar = (x,y) => { return x *y; };
            //Console.WriteLine(suma(2));
            //Console.WriteLine(multiplicar(2,3));
            List<Cerveza> cervesaz = new List<Cerveza>()
            {
                new Cerveza{Nombre = "Quequeña" , Grados  = 8 ,Precio = 50.08M},
                new Cerveza{Nombre = "Pilsen" , Grados  = 1 ,Precio = 50.08M},
                new Cerveza{Nombre = "Brama" , Grados  = 2 ,Precio = 50.08M},
                new Cerveza{Nombre = "Cristal" , Grados  = 3 ,Precio = 50.08M},
                new Cerveza{Nombre = "Heineken" , Grados  = 5 ,Precio = 50.08M},
                new Cerveza{Nombre = "Corona" , Grados  = 15,Precio = 50.08M },
                new Cerveza{Nombre = "Budu" , Grados  = 20,Precio = 50.08M },
            };

            //Func<Cerveza, bool> func = x => { return x.Grados>5; w};

            var result = cervesaz.Where((x,indice) => indice < 3).
                OrderBy(x=>x.Nombre).
                Select(x=>x.Nombre).
                ToList();
            var result2 = cervesaz.Where((x, indice) => indice < 3).
                OrderBy(x => x.Nombre).
                Select(x => new {
                    Nombre = x.Nombre , 
                    Grados = x.Grados }).
                ToList();
            //sirve para paginacion
            var result3 = cervesaz.Skip(0).Take(2).ToList();

            var result4 = cervesaz.GroupBy(x => {
                if (x.Grados < 5)
                {
                    return "Menores que 5 grados";
                }
                else
                {
                    return "Mayores que 5 grados";
                }
            }).ToList();
            foreach (var grupo in result4)
            {
                Console.WriteLine($"{grupo.Key}----Cantidad: {grupo.Count()}");
                foreach (var cerveza in grupo)
                {
                    Console.WriteLine($"{cerveza.Nombre} {cerveza.Grados} {cerveza.Precio}");
                }
            }
            
        }
    }

    class Cerveza
    {
        public string Nombre { get; set; }
        public int Grados{ get; set; }
        public decimal Precio { get; set; }
    }
}
