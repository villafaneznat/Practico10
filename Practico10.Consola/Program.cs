using Practico10.Entidades;
using Practico10.Entidades.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico10.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LAPIZ
            Lapiz miLapiz = new Lapiz(10);

            EscrituraWrapper elapiz = ((IAcciones)miLapiz).Escribir("Hola");

            Console.ForegroundColor = elapiz.color;

            Console.WriteLine(elapiz.texto);

            Console.WriteLine(miLapiz.ToString());

            //BOLIGRAFO

            Boligrafo miBoligrafo = new Boligrafo(5, ConsoleColor.Green);

            EscrituraWrapper eBoligrafo = miBoligrafo.Escribir("Hola");

            Console.ForegroundColor = eBoligrafo.color;

            Console.WriteLine(eBoligrafo.texto);

            Console.WriteLine(miBoligrafo.ToString());


            //CARTUCHERA SIMPLE

            CartucheraSimple cartucheraSimple = new CartucheraSimple();

            CartucheraMultiuso cartucheraMultiuso = new CartucheraMultiuso();

            cartucheraSimple.AgregarBoligrafos(miBoligrafo);
            cartucheraSimple.AgregarLapices(miLapiz);

            //cartucheraMultiuso.AgregarElementos(miBoligrafo);
            //cartucheraMultiuso.AgregarElementos(miLapiz);

            //do
            //{
            //    Console.WriteLine(cartucheraMultiuso.RecorrerElementos());
            //    EscrituraWrapper texto = miBoligrafo.Escribir("Ho");
            //    Console.WriteLine(miBoligrafo.ToString());
            //} while (cartucheraMultiuso.RecorrerElementos());

            //cartucheraMultiuso.RecorrerElementos();
            //Console.WriteLine(miBoligrafo.ToString());

            Lapiz lapiz = new Lapiz(10);
            cartucheraMultiuso.AgregarElementos(lapiz);
            while (cartucheraMultiuso.RecorrerElementos())
            {
                EscrituraWrapper txt = ((IAcciones)lapiz).Escribir("Me gasto");
                Console.WriteLine(lapiz.ToString());
            }
            cartucheraMultiuso.RecorrerElementos();
            Console.WriteLine(lapiz.ToString());

            Console.ReadLine();

            
        }
    }
}
