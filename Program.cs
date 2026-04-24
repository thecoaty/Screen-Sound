
Banda lilpeep = new Banda("Lil Peep");

Album LilPeepPartOne = new Album("Part One");

Musica musicaPeep1 = new Musica(lilpeep, "praying to the sky")
{
    Duracao = 239,
    Disponivel = true
};

Musica musicaPeep2 = new Musica(lilpeep, "the way i see things")
{
    Duracao = 133,
    Disponivel = true
};
musicaPeep1.ExibirFichaTecnica();
musicaPeep2.ExibirFichaTecnica();
LilPeepPartOne.AdicionarMusica(musicaPeep1);
LilPeepPartOne.AdicionarMusica(musicaPeep2);
LilPeepPartOne.ExibirAlbum();
lilpeep.AdicionarAlbum(LilPeepPartOne);
lilpeep.ExibirDiscografia();

//Podcast podfrutas = new("PodFrutas", "Ronaldo");
//Episodio ep1 = new(1, "Incio do Podfrutas papi", 30);
//ep1.AdicionarConvidado("Ronaldo");
//Episodio ep2 = new(2, "O que é a vida?", 189);
//ep2.AdicionarConvidado("Arthur Petry");
//podfrutas.AdicionarEpisodio(ep1);
//podfrutas.AdicionarEpisodio(ep2);
//podfrutas.ExibirDetalhes();