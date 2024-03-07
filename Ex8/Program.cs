using Ex8.Entities;

namespace exercicio8
{
    public class Program
    {

        public static void Main(string[] args)
        {
            // Resolva aqui, utilizando as classes criadas, os items a seguir:

            //Criando as duas frotas
            Frota frota1 = new Frota(1, "Cooperativa de veículos CMCar LTDA", "03.019.756/0001-70", new List<Veiculo>());
            Frota frota2 = new Frota(2, "Consórcio de veículos CMCar S.A", "26.402.504/0001-21", new List<Veiculo>());

            //Criando os dezoito veículos
            Veiculo veiculo1 = new Veiculo(1, 1, "van", "Ford", "Transit", "2008", 97000, 2, 1);
            Veiculo veiculo2 = new Veiculo(2, 1, "van", "Citroen", "Jumper", "2008", 95000, 2, 1);
            Veiculo veiculo3 = new Veiculo(3, 1, "van", "Citroen", "Jumper", "2012", 17000, 2, 1);
            Veiculo veiculo4 = new Veiculo(4, 1, "van", "Citroen", "Jumper", "2023", 0, 2, 1);
            Veiculo veiculo5 = new Veiculo(5, 1, "van", "Fiat", "Ducato", "2006", 15000, 4, 1);
            Veiculo veiculo6 = new Veiculo(6, 1, "carro", "Fiat", "Palio", "2009", 15000, 2, 0);
            Veiculo veiculo7 = new Veiculo(7, 1, "carro", "Fiat", "Palio", "2009", 25000, 2, 0);
            Veiculo veiculo8 = new Veiculo(8, 1, "carro", "Ford", "Ka", "2015", 76560, 4, 0);
            Veiculo veiculo9 = new Veiculo(9, 1, "carro", "Chevrolet", "Onix", "2010", 15000, 4, 0);
            Veiculo veiculo10 = new Veiculo(10, 1, "moto", "Yamaha", "Flup", "2023", 0, 0, 0);

            Veiculo veiculo11 = new Veiculo(11, 2, "van", "Ford", "Transit", "2018", 65000, 2, 1);
            Veiculo veiculo12 = new Veiculo(12, 2, "van", "Fiat", "Ducato", "2007", 15400, 2, 1);
            Veiculo veiculo13 = new Veiculo(13, 2, "carro", "Fiat", "Palio", "2019", 35000, 2, 0);
            Veiculo veiculo14 = new Veiculo(14, 2, "carro", "Chevrolet", "Onix", "2012", 65000, 4, 0);
            Veiculo veiculo15 = new Veiculo(15, 2, "moto", "Yamaha", "Flup", "2023", 0, 0, 0);
            Veiculo veiculo16 = new Veiculo(16, 2, "moto", "Yamaha", "Flup", "2023", 10000, 0, 0);
            Veiculo veiculo17 = new Veiculo(17, 2, "moto", "Yamaha", "Flup", "2022", 5500, 0, 0);
            Veiculo veiculo18 = new Veiculo(18, 2, "moto", "Honda", "CB300", "2023", 0, 0, 0);

            //Adicionando os veículos às frotas
            frota1.Veiculos.Add(veiculo1);
            frota1.Veiculos.Add(veiculo2);
            frota1.Veiculos.Add(veiculo3);
            frota1.Veiculos.Add(veiculo4);
            frota1.Veiculos.Add(veiculo5);
            frota1.Veiculos.Add(veiculo6);
            frota1.Veiculos.Add(veiculo7);
            frota1.Veiculos.Add(veiculo8);
            frota1.Veiculos.Add(veiculo9);
            frota1.Veiculos.Add(veiculo10);

            frota2.Veiculos.Add(veiculo11);
            frota2.Veiculos.Add(veiculo12);
            frota2.Veiculos.Add(veiculo13);
            frota2.Veiculos.Add(veiculo14);
            frota2.Veiculos.Add(veiculo15);
            frota2.Veiculos.Add(veiculo16);
            frota2.Veiculos.Add(veiculo17);
            frota2.Veiculos.Add(veiculo18);

            // a) A quantidade de veículos da frota 1. Resposta: 10
            int qtdVeiculosFrota1 = frota1.Veiculos.Count();
            Console.Write("a) ");
            Console.WriteLine(qtdVeiculosFrota1);

            // b) A quantidade de carros com 4 portas na empresa. Resposta: 3
            int qtdCarros = frota1.Veiculos.Where(v => (v.QtdPortasSimples + v.QtdPortasCorrer) == 4).Count() +
                frota2.Veiculos.Where(v => (v.QtdPortasSimples + v.QtdPortasCorrer) == 4).Count();
            Console.Write("b) ");
            Console.WriteLine(qtdCarros);


            // c) O total de lugares (capacidade) disponíveis da frota 1. Resposta: 82
            int capacidadeTotalFrota1 = frota1.Veiculos.Sum(v => v.QtdLugares);
            Console.Write("c) ");
            Console.WriteLine(capacidadeTotalFrota1);

            // d) A média de quilômetros rodados de todos os veículos da frota 2. Resposta: 24.487,5
            double mediaKmFrota2 = frota2.Veiculos.Average(v => v.Kilometragem);
            Console.Write("d) ");
            Console.WriteLine(mediaKmFrota2);

            // e) O(s) veículo(s) mais novo(s) da frota 1 (retornar em forma de lista, pois pode haver mais de um). Resposta: Veiculo 4 e Veiculo 10
            var maisNovosFrota1 = frota1.Veiculos.Where(v => Convert.ToInt32(v.Ano) == frota1.Veiculos.Max(v => Convert.ToInt32(v.Ano)));
            Console.Write("e) ");
            foreach (var veiculo in maisNovosFrota1)
            {
                Console.Write("| Veiculo "+ veiculo.VeiculoId);
            }

            Console.WriteLine();

            // f) O(s) veículo(s) mais rodado(s) da frota 2 (retornar em forma de lista, pois pode haver mais de um). Resposta: Veiculo 11 e Veiculo 14
            var maisRodados = frota2.Veiculos.Where(v => v.Kilometragem == frota2.Veiculos.Max(v => v.Kilometragem));
            Console.Write("f) ");
            foreach (var veiculo in maisRodados)
            {
                Console.Write("| Veiculo " + veiculo.VeiculoId);
            }
            Console.WriteLine();

            // g) O(s) veículo(s) mais antigo(s) da empresa (retornar em forma de lista, pois pode haver mais de um). Resposta: Veiculo 5
            var todosVeiculosEmpresa = frota1.Veiculos.Concat(frota2.Veiculos);
            var maisAntigosEmpresa = todosVeiculosEmpresa.Where(v => Convert.ToInt32(v.Ano) == todosVeiculosEmpresa.Min(v => Convert.ToInt32(v.Ano)));
            Console.Write("g) ");
            foreach (var veiculo in maisAntigosEmpresa)
            {
                Console.Write("| Veiculo " + veiculo.VeiculoId);
            }
            Console.WriteLine();

            // h) A frota com a maior quantidade de vans (retornar em forma de lista, pois pode haver mais de um) Resposta: Frota 1
            List<Frota> frotaMaisVans = new List<Frota>();
            if (frota1.Veiculos.Where(v => v.Tipo == "van").Count() >
                frota2.Veiculos.Where(v => v.Tipo == "van").Count())
            {
                frotaMaisVans.Add(frota1);
            }
            else if (frota1.Veiculos.Where(v => v.Tipo == "van").Count() <
                frota2.Veiculos.Where(v => v.Tipo == "van").Count())
            {
                frotaMaisVans.Add(frota2);
            }
            else
            {
                frotaMaisVans.Add(frota1);
                frotaMaisVans.Add(frota2);
            }

            Console.Write("h) ");
            foreach (var frota in frotaMaisVans)
            {
                Console.WriteLine("Frota "+ frota.FrotaId);
            }

            Console.ReadKey();
            
        }
    }
}

