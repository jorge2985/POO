using System;

namespace ejercicio1
{
    class Program
    {
        class Persona
            {
                public string nombre = "";
                public string apellido = "";
                public int edad = 0;
                public string telefono = "";

                public Persona(string nom, string ape, int e, string tel){
                    nombre = nom;
                    apellido = ape;
                    edad = e;
                    telefono = tel;
                }

                public void mostrar()
                {
                    Console.WriteLine(nombre);
                    Console.WriteLine(apellido);
                    Console.WriteLine(edad);
                    Console.WriteLine(telefono);
                }
            }
        static void Main(string[] args)
        {
            Persona primerPersona;
            primerPersona = new Persona("Pablo", "Avellaneda", 53, "123456789");
            primerPersona.mostrar();
        }
    }
}