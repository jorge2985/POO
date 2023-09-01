using System;

public class Cumples
{
    public string nombre;
    public string apellido;
    public int dia;
    public int mes;
    public int anio;

    public Cumples (int d, int m, int a, string n, string ap){
        apellido = ap;
        nombre = n;
        dia = d;
        mes = m;
        anio = a;
    }

    public static void Recorrido(Cumples[] array)
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(array[i].nombre + " nació el " + array[i].dia + "/" + array[i].mes + "/" + array[i].anio);
        }
    }

    public static void Main(string[] args)
    {
        Cumples[] arrayCumples;
        arrayCumples = new Cumples[5]; 
        arrayCumples[0] = new Cumples (13, 6, 1997, "Ole", "Jaramillo");
        arrayCumples[1] = new Cumples (24, 5, 1990, "Nico", "Deletrear");
        arrayCumples[2] = new Cumples (26, 8, 1989, "Leo", "");
        arrayCumples[3] = new Cumples (29, 4, 2008, "Jorge", "González");
        arrayCumples[4] = new Cumples (29, 10, 1990, "Emma", "Espinoza");
     
        int cumpleMes;
        int contador = 0;
        
        Recorrido(arrayCumples);

        Console.WriteLine("Elige un número de mes y te diré cuántos amigos tuyos están de cumple: ");
        cumpleMes = int.Parse(Console.ReadLine());

        for (int i = 0; i < 5; i++)
        {
            if (cumpleMes == arrayCumples[i].mes){
                contador ++;
            }
        }
        
        if (contador > 0)
        {
            Console.WriteLine("La cantidad de amigos que cumplen en el mes " + cumpleMes + " es: " + contador);
        } else {
            Console.WriteLine("Nadie cumpleaños en el mes " + cumpleMes);
        }
        
    }

}