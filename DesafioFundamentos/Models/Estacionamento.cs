namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal _precoInicial = 0;
        private decimal _precoPorHora = 0;
        private readonly List<string> veiculos = new();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            _precoInicial = precoInicial;
            _precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // Implementado
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine().ToUpper();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // Implementado
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal
                // Implementado
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = _precoInicial + (_precoPorHora * horas);

                // TODO: Remover a placa digitada da lista de veículos
                // Implementado
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // Implementado
                Console.WriteLine("Veículos estacionados: ");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo.ToString());
                }
                Console.WriteLine($"Temos um total de: {veiculos.Count} veículos estacionados.");
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}