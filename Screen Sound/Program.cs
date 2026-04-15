Album LilPeepPartOne = new Album();

LilPeepPartOne.Nome = "Part One";

Musica musicaPeep1 = new Musica();
musicaPeep1.Nome = "praying to the sky";
musicaPeep1.Duracao = 239;

Musica musicaPeep2 = new Musica();
musicaPeep2.Nome = "the way i see things";
musicaPeep2.Duracao = 133;

LilPeepPartOne.AdicionarMusica(musicaPeep1);
LilPeepPartOne.AdicionarMusica(musicaPeep2);

LilPeepPartOne.ExibirAlbum();
