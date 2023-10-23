using Sistema_Hotel_Hospedagem.Models;

bool hotelEmFuncionamento = true;
Reserva reserva = new Reserva();
Suite suite = new Suite();
Pessoa pessoa = new Pessoa();

Console.WriteLine("Seja Bem Vindo Ao Sistema De Hotel Hospedagem!");


while (hotelEmFuncionamento)
{
    Console.WriteLine("Escolher Uma Opção \n");
    Console.WriteLine("1* Cadastrar Suite");
    Console.WriteLine("2* Cadastrar Hospede");
    Console.WriteLine("3* Obter Hospede");
    Console.WriteLine("4* Calcular valor diaria");
    Console.WriteLine("5* Fechar");


    switch (Console.ReadLine())
    {
        case "1":
            Console.WriteLine("Escolher Uma Suite \n\n");
            Console.WriteLine("1* Suite Premium");
            Console.WriteLine("2* Suite Good");
            Console.WriteLine("3* Suite Economica");
            Console.WriteLine("4* Sair");

            switch (Console.ReadLine())
            {
                case "1":
                    int Capacidade = 10;
                    string TipoSuite = "Premium";
                    decimal ValorDiaria = 860;

                    suite.Capacidade = Capacidade;
                    suite.TipoSuite = TipoSuite;
                    suite.ValorDiaria = ValorDiaria;

                    Console.WriteLine($"Suite escolhida: {TipoSuite} - preço: {ValorDiaria} - capacidade: {Capacidade}");
                    reserva.CadastrarSuite(suite);
                    break;
                case "2":
                    Capacidade = 5;
                    TipoSuite = "Good";
                    ValorDiaria = 560;

                    suite.Capacidade = Capacidade;
                    suite.TipoSuite = TipoSuite;
                    suite.ValorDiaria = ValorDiaria;

                    Console.WriteLine($"Suite escolhida: {TipoSuite} - preço: {ValorDiaria} - capacidade: {Capacidade}");
                    reserva.CadastrarSuite(suite);
                    break;
                case "3":
                    Capacidade = 1;
                    TipoSuite = "Economica";
                    ValorDiaria = 160;

                    suite.Capacidade = Capacidade;
                    suite.TipoSuite = TipoSuite;
                    suite.ValorDiaria = ValorDiaria;

                    Console.WriteLine($"Suite escolhida: {TipoSuite} - preço: {ValorDiaria} - capacidade: {Capacidade}");
                    reserva.CadastrarSuite(suite);
                    break;
                default: Console.WriteLine("Opção errada!"); break;
            }
            break;
        case "2":
            Console.WriteLine("Digite Nome do hospede: ");
            pessoa = new Pessoa(Console.ReadLine());
            reserva.CadastrarHospedes(pessoa, suite.Capacidade);
            break;
        case "3":
            int quant = reserva.ObterQuantidadeHospedes();
            Console.WriteLine($"Quantidade de hospedes no hotel: {quant}");
            break;
        case "4":
            Console.WriteLine("Digite a quantidade de dias que ficou no hotel.");
            int dias = Convert.ToInt32(Console.ReadLine());
            reserva.CalcularValorDiaria(dias);
            break;
        case "5":
            hotelEmFuncionamento = false;
            Console.WriteLine("Fechando as portas.");
            break;
        default: Console.WriteLine("Opção errada!"); break;
    }
}



