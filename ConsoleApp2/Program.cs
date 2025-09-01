using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Primer lote con 10 registros de productos, cada producto tiene:
            //.Código articulo(3 dígitos no correlativos)
            //.Precio
            //.Código de Marca(1 a 10)
            //Segundo lote con las ventas de la semana. Cada venta tiene:
            //.Código articulo
            //.Cantidad
            //.Código cliente(1 a 100)
            //Este lote corta con Código de Cliente cero.

            Articulo articulo1 = new Articulo();

            articulo1.CodigoArticulo = 5;
            int cod = articulo1.CodigoArticulo;
            Console.WriteLine("cod: " + cod);
            articulo1.CodigoMarca = 55;
            Console.WriteLine("Codigo marca: " + articulo1.CodigoMarca);
            articulo1.CodigoMarca = 5;
            Console.WriteLine("Codigo marca: " + articulo1.CodigoMarca);
            
            Articulo[] articulos = new Articulo[10];

            for(int i=0; i<10; i++)
            {
                articulos[i] = new Articulo();

                Console.WriteLine("Codigo de articulo:");
                articulos[i].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio:");
                articulos[i].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Codigo de marca:");
                articulos[i].CodigoMarca = int.Parse(Console.ReadLine());
            }

            Venta venta = new Venta();

            Console.WriteLine("Ingrese la venta:");
            Console.WriteLine("Codigo de cliente:");
            venta.CodigoCliente = int.Parse(Console.ReadLine());
            while(venta.CodigoCliente != 0)
            {
                Console.WriteLine("Codigo de articulo:");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad:");
                venta.Cantidad = int.Parse(ReadLine());
                Console.WriteLine("Ingrese la venta:");
                Console.WriteLine("Codigo de cliente:");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
            }
            
        }
    }
}
