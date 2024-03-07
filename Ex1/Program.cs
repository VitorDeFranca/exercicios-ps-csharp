

using System.Diagnostics;

namespace exercicio1
{
    public class Program
    {
        //Solução utilizando LINQ
        public static List<string> FiltraTerminadasEmALINQ(List<string> array)
        {
            var sw = new Stopwatch();
            try
            {
                sw.Start();
                return array.Where(x => x.ToLower().Last() == 'a').ToList();

            }
            catch (Exception)
            {
                throw;
            }
            finally 
            { 
                sw.Stop();
                double elapsedTime = ((double)sw.ElapsedTicks / Stopwatch.Frequency);
                Console.WriteLine($"Tempo de execução do método com LINQ: {elapsedTime}s");
                sw.Reset();
            }
        }

        //Solução usando um foreach para verificar se cada uma das string termina com A.
        public static List<string> FiltraTerminadasEmA(List<string> array)
        {
            var sw = new Stopwatch();
            try
            {
                sw.Start();
                List<string> endsWithAnA = new List<string>();

                foreach (string str in array)
                {
                    if (str.ToLower().Last() == 'a') endsWithAnA.Add(str);
                }
                return endsWithAnA;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sw.Stop();
                double elapsedTime = ((double)sw.ElapsedTicks / Stopwatch.Frequency);
                Console.WriteLine($"Tempo de execução do método sem LINQ: {elapsedTime}s");
                sw.Reset();
            }
            
        }

        public static void Main(string[] args)
        {
            //Implementei um stopwatch como um princípio de benchmarking para
            //comparar o tempo de execução de ambas as funções nos casos sugeridos

            var test1 = FiltraTerminadasEmALINQ(new List<string> {"Pera", "Maçã", "Banana", "Uva", "Abacate"}); // new List<string> {"Pera", "Banana", "Uva"}
            foreach (var str in test1)
            {
                Console.Write($"{str} |");
            }
            Console.WriteLine();
            var test2 = FiltraTerminadasEmA(new List<string> { "Pera", "Maçã", "Banana", "Uva", "Abacate" }); // new List<string> {"Pera", "Banana", "Uva"}
            foreach (var str in test2)
            {
                Console.Write($"{str} |");
            }
            Console.WriteLine();
            Console.WriteLine();

            var test3 = FiltraTerminadasEmALINQ(new List<string> {"BANANA", "AZEITE", "Sacola", "MERCADO"}); // new List<string> {"BANANA", "Sacola"}
            foreach (var str in test3)
            {
                Console.Write($"{str} |");
            }
            Console.WriteLine();
            var test4 = FiltraTerminadasEmA(new List<string> { "BANANA", "AZEITE", "Sacola", "MERCADO" }); // new List<string> {"BANANA", "Sacola"}
            foreach (var str in test4)
            {
                Console.Write($"{str} |");
            }
            Console.WriteLine();
            Console.WriteLine();

            var test5 = FiltraTerminadasEmALINQ(new List<string> {}); // new List<string> {}
            if (test5.Count() == 0)
            {
                Console.WriteLine("{}");
            }
            var test6 = FiltraTerminadasEmA(new List<string> { }); // new List<string> {}
            if (test5.Count() == 0)
            {
                Console.WriteLine("{}");
            }

            Console.WriteLine();
            Console.WriteLine(@"Concluímos assim que, ao menos para um pequeno conjunto de
itens, o método sem a utilização de LINQ é mais performático");

            Console.ReadKey();
        }
    }
}

