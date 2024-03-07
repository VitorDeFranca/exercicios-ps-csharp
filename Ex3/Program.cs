namespace exercicio3
{
    public class Program
    {
        public static int ContaDias(string data1, string data2)
        {
            try
            {
                DateOnly newData1, newData2;
                string dateFormat = "yyyy-MM-dd";

                //O programa irá verificar se as datas passadas estão de acordo com o formato especificado.
                //Caso estejam, a função retornará true e converterá as datas para o formato DateOnly.
                //Caso NÃO estejam de acordo com o formato, a função retornará false.

                bool firstParsing = DateOnly.TryParseExact(data1, dateFormat, out newData1);
                bool secondParsing = DateOnly.TryParseExact(data2, dateFormat, out newData2);

            
                if (firstParsing && secondParsing)
                {
                    //Caso as duas conversões tenham sido bem-sucedidas, o programa irá calcular
                    //a diferença de dias de uma data para outra.

                    int daysDifference = newData1.DayNumber - newData2.DayNumber;

                    //A função Abs() retorna o módulo de um número, já que, conforme o enunciado da questão,
                    //a ordem dos parâmetros não deve fazer diferença neste caso.

                    return Math.Abs(daysDifference);
                }

                throw new Exception("ERRO");

            }
            catch (Exception)
            {

                throw;
            }

        }

        public static void Main(string[] args)
        {
            // Exemplos para teste. Sinta-se à vontade para completar com outros testes!

            var test1 = ContaDias("2023-02-01", "2023-02-02"); // 1
            var test2 = ContaDias("2023-02-01", "2023-02-15"); // 14
            var test3= ContaDias("2023-02-01", "2022-02-01"); // 365
            var test4 = ContaDias("2022-02-01", "2023-02-01"); // 365
            var test5 = ContaDias("2023-02-01", "2023-02-01"); // 0
            var test6 = ContaDias("2023-02-01", "2023/02/01"); // ERRO
        }
    }
}

