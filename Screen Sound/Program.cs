//Screen Sound

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";
//List<string> listaDasBandas = new List<string>();

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>(); 
void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemDeBoasVindas);
}
void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para Registrar uma banda");
    Console.WriteLine("Digite 2 para Listar as bandas");
    Console.WriteLine("Digite 3 para Avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda();
            break;
        case 2: ExibirBandas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: ExibirMedia();
            break;
        case -1: Console.WriteLine("Até logo :)");
            break;
        default: Console.WriteLine("Opção Inválida");
            break;
    }

}
void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}
void ExibirBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as Bandas Registradas");
    //for(int i = 0; i < listaDasBandas.Count; i++)
    //{
    //    Console.WriteLine($"Banda: {listaDasBandas[i]}");
    //}
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine("\nPressione uma tecla para continuar");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)
{
    int quatidadeDeLetras = titulo.Length;
    string asteriscos = "".PadLeft(quatidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos +"\n");
}

void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda");
    //Digitar qual banda quer avaliar
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))    //verificar se a banda existe
    {
        //Atribuindo Nota
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else    //se não existir voltar ao menu principal
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirMedia()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir média da banda");
    //Qual a banda?
    Console.Write("Qual banda deseja consultar a média? ");
    string nomeDaBanda = Console.ReadLine()!;
    //essa banda ta no dicionario?
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        //calculo da media
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nA média da banda {nomeDaBanda} é {notasDaBanda.Average()}");
        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Pressione uma tecla para continuar");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

ExibirOpcoesDoMenu();