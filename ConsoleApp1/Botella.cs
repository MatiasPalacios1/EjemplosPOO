using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Botella
    {
        //Capacidad maxima: 300
        //CantidadActual: Inicia en 0
        //Metodo recarga: carga al 100 y devuelve el costo de recargar. 50 cada 100
        //CONSTRUCTOR
        public Botella(string color, string material) 
        {
            this.color = color;
            this.material = material;
            this.capacidad = 100;
            this.cantidadActual = 0;

        }
        //SOBRECARGA DE CONSTRUCTORES
        public Botella(){}
        //public Botella(string){}

        //DESTRUCTOR
        ~Botella(){}

        //Botella: Capacidad, Color, Material
        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;

        //PROPIEDAD
        //Es la manera que maneja C# a los sets() y gets().
        //Es una "única" función y dentro de esa función esta el getter y setter.
        //La diferencia es que el objeto en el main no tiene que llamar al set y al get.

        public int Capacidad //El metodo con Mayuscula
        {
            get { return capacidad; }
        }

        public string Color
        {
            get { return color; }
        }
        public string Material
        {
            get { return material; }
        }

        public int CantidadActual
        {
            get { return cantidadActual; }
        }

        //METODO
        public float recargar()
        {
            if(cantidadActual > 0)
            {
                int dif = capacidad - cantidadActual;
                float monto = dif * 50 / 100;
                cantidadActual += dif;
                return monto;
            }
            cantidadActual = 100;
            return 50;
        }

        public float recargar(int cantidad)
        {
            cantidadActual += cantidad;
            return cantidad * 50 / 100;
        }
    }
}
