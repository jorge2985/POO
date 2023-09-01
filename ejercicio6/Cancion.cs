class Cancion
{
    public String artista = "";
    public String titulo = "";
    public int duracion = 0;
    public int tamanioArchivo = 0;

    public Cancion()
    {

    }

    public Cancion(String art, String tit, int dur, int tam)
    {
        artista = art;
        titulo = tit;
        duracion = dur;
        tamanioArchivo = tam;
    }

    public void Mostrar()
    {
        Console.WriteLine($"\"{ titulo}\", por {artista}; duración: {duracion} segundos, tamaño: {tamanioArchivo} KB");
    }
}
