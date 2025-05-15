// Game Ranker - A game ranking application
string mensagemDeBoasVindas = "Bem-vindo ao Game Ranker! Aqui você pode classificar seus jogos favoritos.";
List<string> listaDeJogos = new List<string>(); // Lista para armazenar os jogos

void ExibirLogo()   
{
    Console.WriteLine(@"
░██████╗░░█████╗░███╗░░░███╗███████╗  ██████╗░░█████╗░███╗░░██╗██╗░░██╗███████╗██████╗░
██╔════╝░██╔══██╗████╗░████║██╔════╝  ██╔══██╗██╔══██╗████╗░██║██║░██╔╝██╔════╝██╔══██╗
██║░░██╗░███████║██╔████╔██║█████╗░░  ██████╔╝███████║██╔██╗██║█████═╝░█████╗░░██████╔╝
██║░░╚██╗██╔══██║██║╚██╔╝██║██╔══╝░░  ██╔══██╗██╔══██║██║╚████║██╔═██╗░██╔══╝░░██╔══██╗
╚██████╔╝██║░░██║██║░╚═╝░██║███████╗  ██║░░██║██║░░██║██║░╚███║██║░╚██╗███████╗██║░░██║
░╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝  ╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝
");
    ExibirTituloDaOpcao(mensagemDeBoasVindas);
}

void ExibirMenu()
{
    ExibirLogo(); // Chama a função de boas-vindas
    Console.WriteLine("\nEscolha uma opção:");
    Console.WriteLine("\n1. Adicionar jogo");
    Console.WriteLine("2. Listar jogos");
    Console.WriteLine("3. Avaliar jogo");
    Console.WriteLine("4. Exibir média de avaliação do jogo");
    Console.WriteLine("5. Sair");

    Console.Write("\nOpção escolhida: ");
    string opcaoEscolhida = Console.ReadLine()!; // Lê a opção do usuário
    int opçãoEscolhidaNumerica = int.Parse(opcaoEscolhida); // Converte a opção para inteiro    
  
    switch (opçãoEscolhidaNumerica) // Condiçao que avalia como if e else if
    {
        case 1:
            RegistrarJogo();
            break;
        case 2:
            ExibirJogos();
            break;
        case 3:
            Console.WriteLine("Você escolheu a opção " + opçãoEscolhidaNumerica);
            break;
        case 4:
            Console.WriteLine("Você escolheu a opção " + opçãoEscolhidaNumerica);
            break;
        case 5:
            Console.WriteLine("Clica em qualquer tecla para sair! :)");
            break;
        default: 
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}

void RegistrarJogo()
{
    Console.Clear(); // Limpa o console
    ExibirTituloDaOpcao("REGISTRO DE JOGOS"); // Chama a função que exibe o título da opção
    Console.Write("\nDigite o nome do jogo: ");
    string nomeDoJogo = Console.ReadLine()!;

    if (string.IsNullOrWhiteSpace(nomeDoJogo)) // Impede que o nome seja um espaço vazio
    {
        Console.WriteLine("Nome do jogo não pode ser nulo. Tente novamente.");
        Thread.Sleep(2000); // Pausa por 2 segundos
        RegistrarJogo();
    } else
    {
        listaDeJogos.Add(nomeDoJogo); // Adiciona o jogo à lista
        Console.WriteLine($"\nO jogo {nomeDoJogo} foi registrado com sucesso!");
        Thread.Sleep(4000); // Pausa por 4 segundos
        Console.Clear();
        ExibirMenu(); // Chama o menu novamente
    }

}

void ExibirJogos()
{
    Console.Clear();
    ExibirTituloDaOpcao("SUA LISTA DE JOGOS");

    if (listaDeJogos.Count == 0) // Verifica se a lista está vazia
    {
        Console.WriteLine("Nenhum jogo registrado ainda");
    } else
     {
        foreach (string nomeDoJogo in listaDeJogos) // Pra cada jogo na minha lista de jogos
        {
            Console.WriteLine($"{nomeDoJogo}"); // Exibe o nome do jogo
        }

     }

    Console.WriteLine("\nPressione 'Enter' para voltar ao menu príncipal");
    Console.ReadKey(); // Aguarda o usuário pressionar qualquer tecla
    Console.Clear();
    ExibirMenu();
}

// Esta função foi criada com objetivo de criar asteriscos em volta do titulo acompanhamento a quantidade de letras com o recurso Lenght
void ExibirTituloDaOpcao(string titulo)
{
    int QntLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(QntLetras, '*'); // Esta função exige 2 parametros, a qnt de repetições e o caracter
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + '\n');
}

ExibirMenu();
