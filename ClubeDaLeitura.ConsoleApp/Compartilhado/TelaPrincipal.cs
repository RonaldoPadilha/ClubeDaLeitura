namespace ClubeDaLeitura.ConsoleApp.Compartilhado;

public class TelaPrincipal
{
    public string? ObterOpcaoMenuPrincipal()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("Clube de Leitura");
        Console.WriteLine("------------------------------");
        Console.WriteLine("1 - Gerenciar caixas de revistas");
        Console.WriteLine("2 - Gerenciar revistas");
        Console.WriteLine("3 - Gerenciar amigos");
        Console.WriteLine("4 - Gerenciar empréstimos");
        Console.WriteLine("5 - Sair");
        Console.WriteLine("------------------------------");
        Console.Write("> ");

        string? opcaoMenuPrincipal = Console.ReadLine()?.ToUpper();

        return opcaoMenuPrincipal;
    }
}
