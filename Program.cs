using System.Text.Json;
using System.Text.Json.Nodes;
using testapi.filtros;


using (HttpClient client = new HttpClient())
{
    string res = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    var musicas = JsonSerializer.Deserialize<List<Musica>>(res);

    bool w = true;
    while (w is true)
    {
        Console.WriteLine("Digite sua opção");
        Console.WriteLine("1- Lista bruta de todas as músicas");
        Console.WriteLine("2- Escolher um artista aleatório");
        Console.WriteLine("3- Filtro");
        Console.WriteLine("4- Encerrar");
        int r = int.Parse(Console.ReadLine());
        Console.Clear();
        switch (r)
        {
            case 1:
                Console.WriteLine(res);
                Console.WriteLine("Pressione uma tecla para voltar");
                Console.ReadKey();
                Console.Clear();
                break;

            case 2:
                Console.WriteLine("Digite um número de 0 a 1998");
                int n = int.Parse(Console.ReadLine());
                musicas[n].Exibiçao();
                Console.WriteLine();
                Console.WriteLine("Pressione uma tecla para voltar");
                Console.ReadKey();
                Console.Clear();
                break;

            case 3:
                Console.WriteLine("1-Listar todos os artistas");
                Console.WriteLine("2-Ver todos os gêneros músicais");
                Console.WriteLine("3-Ver artistas de determinado gênero músical");
                Console.WriteLine("4-Ver músicas de um determinado artista");
                Console.WriteLine("5-Ver músicas de determinado ano");
                Console.WriteLine("6- Voltar");
                int escolha = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (escolha)
                {
                    case 1:
                        filtro.FiltrarArtista(musicas);
                        Console.WriteLine("Pressione uma tecla para voltar");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 2:
                        filtro.Filtrargeneros(musicas);
                        Console.WriteLine("Pressione uma tecla para voltar");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 3:
                        Console.WriteLine("Digite o gênero músical:");
                        string g = Console.ReadLine();
                        Console.Clear();
                        filtro.FiltrarPorGen(musicas, g);
                        Console.WriteLine("Pressione uma tecla para voltar");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 4:
                        Console.WriteLine("Digite o nome do artista:");
                        string art = Console.ReadLine();
                        Console.Clear();
                        filtro.FiltrarPorArt(musicas, art);
                        Console.WriteLine("Pressione uma tecla para voltar");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 5:
                        Console.WriteLine("Digite um ano:");
                        int ano = int.Parse(Console.ReadLine());
                        Console.Clear();
                        filtro.FiltrarPorAno(musicas, ano);
                        Console.WriteLine("Pressione uma tecla para voltar");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case 6:
                        break;
                }
                break;

            case 4:
                Console.WriteLine("Deseja sair da aplicação?");
                string resposta = Console.ReadLine();
                if (resposta == "sim")
                {
                    w = false;
                }
                else
                {
                    w = true;
                    Console.Clear();
                }
                break;

            default:
                Console.WriteLine("Opção inválida");
                Console.Clear();
                break;
        }
    }
}
