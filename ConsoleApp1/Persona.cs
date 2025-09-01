using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Persona
    {
        ///Persona: Edad, Sueldo, Nombre
        ///ATRIBUTOS o MIEMBROS -> Variables con la informacion de la Persona
        ///ENCAPSULAMIENTO -> Es un concepto que define que un miembro de una clase no puede ser accedido desde el exterior.
        
        private int edad;
        private float sueldo;
        private string nombre;

        //CONSTRUCTOR
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        ///MODIFICADORES DE VISIBILIDAD
        ///Son palabras reservadas que nos permiten calificar un atributo o función de la clase como PRIVADO, PUBLICO, PROTEJIDO.
        ///Los principales son public y private.
        
        public void setEdad(int e)
        {
            edad = e;
        }
        public int getEdad()
        {
            return edad;
        }

        //METODOS
        public string Saludar()
        {
            return "Hola soy..." + nombre;
        }

        public string Saludar(string personaje)
        {
            return "Hola " + personaje + ", soy " + nombre;
        }
    }
}
