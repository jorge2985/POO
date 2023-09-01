using System;

namespace ejercicio2
{
    class Program
    {
        class Cumple
        {
            public int dia;
            public int mes;
            public int anio;
            public string calculoFecha()
            {
                int diaActual = DateTime.Now.Date.Day;
                int mesActual = DateTime.Now.Date.Month;
                if(dia == diaActual && mes == mesActual)
                {
                    return "Hoy es tu cumpleaños ¡Feliz cumpleaños!";
                } else {
                    return "Hoy no es tu cumpleaños";
                }
            }
            public string Edad() {
                int anioActual = DateTime.Now.Date.Year;
                int edad = anioActual - anio;
                return "Tu edad es " + edad + " años";
            }
            public Cumple(int d, int m, int a)
            {
                dia = d;
                mes = m;
                anio = a;
            }
        }
        public static void Main()
        {
            Cumple persona1 = new Cumple(29, 04, 1985);
            Console.WriteLine(persona1.calculoFecha() + ". " + persona1.Edad());
            Console.WriteLine("La fecha actual es: " + DateTime.Now.Date);
        }
    }
}