using System.Text.Json;
using ScreenSound_04.Modelos;
using ScreenSound_04.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        LinqFilter.FiltrarMusicasEmCSharp(musicas);

        //musicas[1].ExibirDetalhesDaMusica();
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");

        //var minhasMusicasPreferidas = new MusicasPreferidas("Henrick");
        //minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[6]);
        //minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[14]);
        //minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[20]);
        //minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[22]);
        //minhasMusicasPreferidas.AdicionarMusicasFavoritas(musicas[31]);

        //minhasMusicasPreferidas.ExibirMusicasFavoritas();

        //minhasMusicasPreferidas.GerarArquivoJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}