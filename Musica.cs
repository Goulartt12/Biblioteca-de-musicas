using System.Text.Json.Serialization;

internal class Musica
{
    [JsonPropertyName("song")]
    public string musica { get; set; }
    [JsonPropertyName("artist")]
    public string artista { get; set; }
    [JsonPropertyName("year")]
    public string MusicaAno { get; set; }

    [JsonPropertyName("genre")]
    public string genero { get; set; }
    public int ano
    { 
        get 
        {
            return int.Parse(this.MusicaAno);
        }
    }

    public void Exibiçao()
    {
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Música: {musica}");
        Console.WriteLine($"Ano de lançamento: {ano}");
        Console.WriteLine($"Gênero músical: {genero}");
    }
}