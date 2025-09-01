using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int edad;
            //float sueldo;
            //string nombre;
            //int[] = new int[10];
            //float[] = new float[10];
            //string[] = new string[10];
            Persona persona1 = new Persona("Matias"); ///-> Instancia del objeto Persona
            persona1.setEdad(20);
            Console.WriteLine(persona1.Saludar());
            Console.WriteLine(persona1.Saludar("Chichi"));

            Console.WriteLine("La edad de la persona es: " + persona1.getEdad());
            Console.ReadKey();

            Botella b1 = new Botella("azul", "plastico");
            //b1.Capacidad = 10;
            Console.WriteLine("La capacidad de la botella es: " + b1.Capacidad);
            //int valor = b1.Capacidad; //Devuelvo el valor (get()) usando la PROPIEDAD
            //Console.WriteLine("valor: " + valor);
            Console.WriteLine("Color de la botella: " + b1.Color);
            Console.WriteLine("Material de la botella: " + b1.Material);
            Console.WriteLine("Capacidad botella: " + b1.Capacidad);
            Console.WriteLine("La capacidad actual es: " + b1.CantidadActual);
            b1.recargar();
            Console.WriteLine("Luego de la recarga la capacidad actual es: " + b1.CantidadActual);
            Console.ReadKey();
        }
    }
}
