class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }

    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirAlbum()
    {
        Console.WriteLine($"Album: {Nome}");
        foreach(var musica in musicas)
        {
            Console.WriteLine(musicas);
        }
        Console.WriteLine($"A duração total do album é {DuracaoTotal}")
    }
}