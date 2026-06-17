using ClubeDaLeitura.ConsoleApp.Compartilhado;
using ClubeDaLeitura.ConsoleApp.ModuloCaixa;

RepositorioCaixa repositorioCaixa = new RepositorioCaixa();
TelaCaixa telaCaixa = new TelaCaixa(repositorioCaixa);

TelaPrincipal telaPrincipal = new TelaPrincipal();

while (true)
{
    // Menu principal da Aplicação
    string? opcaoMenuPrincipal = telaPrincipal.ObterOpcaoMenuPrincipal();

    if (opcaoMenuPrincipal == "5")
    {
        break;
    }

    if (opcaoMenuPrincipal == "1") // Caixas
    {
        String? opcaoMenuInterno = telaCaixa.ObterOpcaoMenu();

        if (opcaoMenuPrincipal == "5")
        {
            break;
        }

        if (opcaoMenuInterno == "1")
        {
            telaCaixa.Cadastrar();
        }

        else if (opcaoMenuInterno == "2")
        {

        }

        else if (opcaoMenuInterno == "3")
        {

        }

        else if (opcaoMenuInterno == "4")
        {

        }
    }

    if (opcaoMenuPrincipal == "2") // Revistas
    {

    }

    if (opcaoMenuPrincipal == "3") // Amigos
    {

    }

    if (opcaoMenuPrincipal == "4") // Empréstimos
    {

    }
}
