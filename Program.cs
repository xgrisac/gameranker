// Game Ranker - A game ranking application
string mensagemDeBoasVindas = "Bem-vindo ao Game Ranker! Aqui você pode classificar seus jogos favoritos.";

Dictionary<string, List<int> > JogosRegistrados = new Dictionary<string, List<int> >(); // Dicionário para armazenar os jogos e suas avaliações


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
    Console.WriteLine("\n1. Adicionar um novo jogo");
    Console.WriteLine("2. Listar todos os jogos");
    Console.WriteLine("3. Avaliar um jogo");
    Console.WriteLine("4. Exibir média de avaliação do jogo");
    Console.WriteLine("5. Excluir um jogo");
    Console.WriteLine("6. Sair");

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
            AvaliarUmJogo();
            break;
        case 4:
            ExibirMedia();
            break;
        case 5:
            ExcluirJogo();
            break;
        case 6:
            Console.WriteLine("\nClique em qualquer tecla para sair! :)");
            break;
        default: 
            Console.WriteLine("\nOpção inválida. Tente novamente.");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirMenu();
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
        Console.WriteLine("\nNome do jogo não pode ser nulo. Tente novamente.");
        Thread.Sleep(2000); // Pausa por 2 segundos
        RegistrarJogo();

    } if (JogosRegistrados.ContainsKey(nomeDoJogo))
    {
        Console.WriteLine($"\nO jogo {nomeDoJogo} foi registrado, tente outra opção.");
        Thread.Sleep(2000);
        RegistrarJogo();

    } else
    {
        JogosRegistrados.Add(nomeDoJogo, new List<int>()); // Adiciona o jogo à lista utilizando os 2 parâmetros, o nome e a lista de jogoss
        Console.WriteLine($"\nO jogo {nomeDoJogo} foi registrado com sucesso!");
        Thread.Sleep(2000); // Pausa por 4 segundos
        Console.Clear();
        ExibirMenu(); // Chama o menu novamente
    }
}



void ExibirJogos()
{
    Console.Clear();
    ExibirTituloDaOpcao("SUA LISTA DE JOGOS");

    if (JogosRegistrados.Count == 0) // Verifica se a lista está vazia
    {
        Console.WriteLine("Nenhum jogo registrado ainda.");
        

    } else
     {
        foreach (string nomeDoJogo in JogosRegistrados.Keys) // Pra cada jogo na minha lista de jogos
        {
            Console.WriteLine($"{nomeDoJogo}"); // Exibe o nome do jogo
        }
     }
    Console.WriteLine("\nPressione 'Enter' para voltar ao menu príncipal.");
    Console.ReadKey(); // Aguarda o usuário pressionar qualquer tecla
    Console.Clear();
    ExibirMenu();
}

void AvaliarUmJogo()
{
    Console.Clear();
    ExibirTituloDaOpcao("AVALIAÇÃO DE JOGOS");
    if (JogosRegistrados.Count == 0) // Verifica se a lista está vazia
    {
        Console.WriteLine("Nenhum jogo registrado ainda.");
        Console.WriteLine("\nPressione 'Enter' para voltar ao menu príncipal, selecione a opção 1 e digite um novo jogo.");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    }

    else
    {
        Console.Write("Digite o nome do jogo que deseja avaliar: ");
        string nomeDoJogo = Console.ReadLine()!;
        if (JogosRegistrados.ContainsKey(nomeDoJogo)) // Comando que confere se dentro do dicionario tem algum jogo com o nome digitado 
        {
            Console.Write($"\nAvalie numa escala de 0 a 10 o jogo {nomeDoJogo}: ");
            int avaliacao = int.Parse(Console.ReadLine()!); // Lê a avaliação do usuário convertendo de string para int com o comando Parse
            JogosRegistrados[nomeDoJogo].Add(avaliacao); // Adiciona a avaliação à lista de avaliações do jogo
            Console.WriteLine("Registrando...");
            Thread.Sleep(2000);
            Console.WriteLine($"\n{nomeDoJogo} foi avaliado com a nota {avaliacao}");
            Console.WriteLine("\nRetornando ao meu principal...");
            Thread.Sleep(4000);
            Console.Clear();
            ExibirMenu();

        } else
        {
            Console.WriteLine($"\n{nomeDoJogo} não encontrado, tente novamente.");
            Thread.Sleep(2000);
            Console.Clear();
            AvaliarUmJogo();
        }
     }
}

void ExibirMedia()
{
    Console.Clear();
    ExibirTituloDaOpcao("MÉDIA DE AVALIAÇÃO DOS JOGOS");
    if (JogosRegistrados.Count == 0) // Verifica se a lista está vazia
    {
        Console.WriteLine("Nenhum jogo registrado ainda.");
        Console.WriteLine("\nPressione 'Enter' para voltar ao menu príncipal, selecione a opção 1 e digite um novo jogo.");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();

    } else
    {
        Console.Write("\nDigite o nome do jogo que deseja ver a média: ");
        string nomeDoJogo = Console.ReadLine()!;
        if (JogosRegistrados.ContainsKey(nomeDoJogo))
        {
            List<int> avaliaçõesDosJogos = JogosRegistrados[nomeDoJogo]; // Pega a lista de avaliações do jogo
            if (avaliaçõesDosJogos.Count == 0) // Verifica se a lista esta vazia
            {
                Console.WriteLine($"\nO jogo {nomeDoJogo} ainda não foi avaliado, selecione um jogo já avaliado ou avalie o jogo selecionado e tenta novamente.");
                Thread.Sleep(4000);
                Console.Clear();
                ExibirMenu();
            } else
            {
                Console.WriteLine($"\nA média de avaliação do jogo {nomeDoJogo} é {avaliaçõesDosJogos.Average()}"); ; // AVERAGE calcula a média das avaliações
                Console.WriteLine("Voltando ao meu meu principal...");
                Thread.Sleep(2000);
                Console.Clear();
                ExibirMenu();
            }
            


        } else
        {
            Console.WriteLine($"\nO jogo {nomeDoJogo} não está na sua lista de jogos.");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirMedia();
        }
        
    }
}

void ExcluirJogo()
{
    Console.Clear();
    ExibirTituloDaOpcao("EXCLUSÃO DE JOGOS");
    if (JogosRegistrados.Count == 0) // Verifica se a lista está vazia
    {
        Console.WriteLine("Nenhum jogo registrado ainda.");
        Console.WriteLine("\nPressione 'Enter' para voltar ao menu príncipal, selecione a opção 1 e digite um novo jogo.");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();
    } else
    {
        Console.Write("\nDigite o nome do jogo que deseja excluir: ");
        string nomeDoJogo = Console.ReadLine()!;
        if (JogosRegistrados.ContainsKey(nomeDoJogo)) // Verifica se o jogo existe na lista
        {
            JogosRegistrados.Remove(nomeDoJogo); // Remove o jogo da lista
            Console.WriteLine($"\nO jogo {nomeDoJogo} foi excluído com sucesso!");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirMenu();
        } else
        {
            Console.WriteLine($"\nO jogo {nomeDoJogo} não está na sua lista de jogos.");
            Thread.Sleep(2000);
            Console.Clear();
            ExcluirJogo();
        }

    }
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
