using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            nombre = Console.ReadLine();
            Console.WriteLine(nombre);
            int cant = nombre.Length; //Length -> devuelve la cantidad de caracteres
            Console.WriteLine("cant: " + cant);
            Console.WriteLine(nombre.ToUpper()); //ToUpper() -> convierte toda la cadena a mayuscula
            nombre = nombre.ToUpper(); //Si quiero que la cadena quede fija en mayuscula la tengo que asginar
            nombre = nombre.ToLower(); //Tolower() -> transforma la cadena a miniscula
            Console.WriteLine(nombre);
            //nombre.Replace('a', 'u');
            Console.WriteLine(nombre.Replace('a', 'u')); //Replace() -> Reemplaza un caracter por otro. Caracter de la derecha reemplaza a la izquierda
            nombre = nombre.Replace("matias", "palacios"); //Replace() -> Tambien reemplaza cadenas. Cadena viaje izquierda, nueva derecha.
            Console.WriteLine(nombre);
        }
    }
}
