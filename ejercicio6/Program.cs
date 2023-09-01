using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana1_Ej6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            Crea una clase que almacene datos de una canción en formato MP3:
            Artista, Título, Duración (en segundos), Tamaño del archivo (en KB).
            Un programa debe pedir los datos de una canción al usuario,
            almacenarlos en un objeto y después mostrarlos en pantalla.*/

            // Crea el objeto canción, sin datos
            Cancion cancion = new Cancion();

            // Pide los datos al usuario
            Console.Write("Ingrese el título de la canción: ");
            cancion.titulo = Console.ReadLine();
            Console.Write("Ingrese el intérprete de la canción: ");
            cancion.artista = Console.ReadLine();
            Console.Write("Ingrese la duración en segundos de la canción: ");
            cancion.duracion = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tamaño en KB del archivo de la canción: ");
            cancion.tamanioArchivo = int.Parse(Console.ReadLine());

            // Muestra los datos de la canción
            cancion.Mostrar();
        }
    }
}