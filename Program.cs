using desafio_projeto_fundamentos.Models;

int horasDePermanencia;
double precoInicial, precoPorHora, precoFinal;
string? opcao, placa;
bool encerrarPrograma = false;

Console.WriteLine("Bem-vindo ao Sistema de Estacionamento!");
Console.WriteLine("Digite o valor fixo inicial: ");
precoInicial = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor cobrado por hora");
precoPorHora = Convert.ToDouble(Console.ReadLine());

Estacionamento estacionamento = new(precoInicial, precoPorHora);

while (!encerrarPrograma)
{
    Console.WriteLine("\nDigite a opção desejada.");
    Console.WriteLine("1. Cadastrar veículo;");
    Console.WriteLine("2. Remover veículo;");
    Console.WriteLine("3. Listar veículos;");
    Console.WriteLine("4. Encerrar.");
    opcao = Console.ReadLine();
    Console.Clear();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Digite a placa do carro:");
            placa = Console.ReadLine();
            Console.Clear();            
            if (!estacionamento.AdicionarVeiculo(placa))
            {
                Console.WriteLine("Veículo já cadastrado.");
            }
            else
            {
                Console.WriteLine($"Carro de placa {placa} cadastrado!");
            }
            break;

        case "2":
            Console.WriteLine("Digite a placa do carro que deseja remover");
            placa = Console.ReadLine();
            if (estacionamento.RemoverVeiculo(placa))
            {
                Console.WriteLine("Quantas horas este carro permaneceu no estacionamento?");
                horasDePermanencia = int.Parse(Console.ReadLine());
                Console.Clear();
                precoFinal = precoInicial + (precoPorHora * horasDePermanencia);
                Console.WriteLine($"Veiculo removido! Valor cobrado: R$ {precoFinal}");
            }
            else
            {
                Console.WriteLine("Placa não encontrada.");
            }
            break;

        case "3":
            Console.WriteLine("Listando veículos:");
            estacionamento.ListarVeiculos();
            break;

        case "4":
            Console.Clear();
            Console.WriteLine("Encerrando Programa...");
            encerrarPrograma = true;
            break;
    }

}