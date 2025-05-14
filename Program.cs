// Game Ranker - A game ranking application
string mensagemDeBoasVindas = "Bem-vindo ao Game Ranker! Aqui você pode classificar seus jogos favoritos.";

void exibirMensagemDeBoasVindas()
{
    Console.WriteLine(@"
░██████╗░░█████╗░███╗░░░███╗███████╗  ██████╗░░█████╗░███╗░░██╗██╗░░██╗███████╗██████╗░
██╔════╝░██╔══██╗████╗░████║██╔════╝  ██╔══██╗██╔══██╗████╗░██║██║░██╔╝██╔════╝██╔══██╗
██║░░██╗░███████║██╔████╔██║█████╗░░  ██████╔╝███████║██╔██╗██║█████═╝░█████╗░░██████╔╝
██║░░╚██╗██╔══██║██║╚██╔╝██║██╔══╝░░  ██╔══██╗██╔══██║██║╚████║██╔═██╗░██╔══╝░░██╔══██╗
╚██████╔╝██║░░██║██║░╚═╝░██║███████╗  ██║░░██║██║░░██║██║░╚███║██║░╚██╗███████╗██║░░██║
░╚═════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝╚══════╝  ╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝
");
    Console.WriteLine("\n*******************");
    Console.WriteLine(mensagemDeBoasVindas);
    Console.WriteLine("*******************");
}

void exibirMenu()
{
    Console.WriteLine("\nEscolha uma opção:");
   
    Console.WriteLine("\n1. Adicionar jogo");
    Console.WriteLine("2. Listar jogos");
    Console.WriteLine("3. Avaliar jogo");
    Console.WriteLine("4. Exibir média de avaliação do jogo");
    Console.WriteLine("5. Sair");

    Console.Write("\nOpção escolhida: ");
    Console.ReadLine(); // Lê a opção do usuário

}

exibirMensagemDeBoasVindas();
Thread.Sleep(4000); // Pausa de 4 segundos para o usuário ler a mensagem
exibirMenu();
