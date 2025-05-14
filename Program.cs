// Game Ranker - A game ranking application
string mensagemDeBoasVindas = "Bem-vindo ao Game Ranker! Aqui você pode classificar seus jogos favoritos.";

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
    Console.WriteLine(mensagemDeBoasVindas);
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
            Console.WriteLine("Você escolheu a opção " + opçãoEscolhidaNumerica);
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
    Console.WriteLine("Registro de Jogo\n");
    Console.Write("Digite o nome do jogo: ");
    string nomeDoJogo = Console.ReadLine()!;
    Console.WriteLine($"O jogo {nomeDoJogo} foi registrado com sucesso!"); 
    Thread.Sleep(4000); // Pausa por 4 segundos
    Console.Clear();
    ExibirMenu(); // Chama a função de boas-vindas novamente
}


ExibirMenu();
