using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Articulo
    {
        //ATRIBUTOS
        //private int codigoArticulo;
        //private float precio;
        private int codigoMarca;

        //PROPIEDADES FORMA CORTA
        //(atributo + propiedad).
        //En tiempo de ejecución crea un atributo privado que va a manipular.
        //public int CodgioArticulo { get; } ->PROPIEDAD SOLO LECTURA (solo get)
        public int CodigoArticulo { get; set; }
        public float Precio { get; set; }
        //public int CodigoMarca { get; set; }

        public int CodigoMarca
        {
            get { return codigoMarca; }
            set
            {
                if(value > 0 && value < 11) //value = valor, parametro que mando
                {
                    codigoMarca = value;
                }
                else
                {
                    codigoMarca = -1;
                }
            }
        }
    }
}
