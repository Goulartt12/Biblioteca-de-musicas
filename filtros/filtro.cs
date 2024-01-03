namespace testapi.filtros;
using System.Linq;

internal class filtro
{
    public static void Filtrargeneros(List<Musica> musicas)
    {
        var filtrargeneros = musicas.Select(generos => generos.genero).Distinct();
        foreach (var genero in filtrargeneros)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtista(List<Musica> musicas)
    {
        var filtrarartista = musicas.Select(artista => artista.artista).Distinct().ToList();
        filtrarartista.Sort();
        foreach (var artista in filtrarartista)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarPorGen(List<Musica> musicas, string genero)
    {
        var filtrarporgen = musicas.Where(musica => musica.genero.Contains(genero)).Select(musica => musica.artista).Distinct().ToList();
        filtrarporgen.Sort();
        foreach (var artista in filtrarporgen)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarPorArt(List<Musica> musicas, string artista)
    {
        var filtrarporgen = musicas.Where(musica => musica.artista.Contains(artista)).Select(musica => musica.musica);
        foreach (var musica in filtrarporgen)
        {
            Console.WriteLine($"- {musica}");
        }
    }

    public static void FiltrarPorAno(List<Musica> musicas, int ano)
    {
        var filtrarporano = musicas.Where(musica => musica.ano == ano).OrderBy(musica => musica.musica).Select(musica => musica.musica);

        foreach (var musica in filtrarporano)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}
