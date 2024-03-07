using System.Linq;

namespace exercicio6
{
    public class Program
    {
        public static List<List<int>> QuebraLista(List<int> array, int num)
        {
            try
            {
                List<List<int>> listOfLists = new List<List<int>>();

                //O quociente é calculado para saber quantas sublistas teremos na lista de listas
                int quotient = array.Count / num;

                //Elementos serão adicionados à sublistas até que não reste nenhum elemento restante no array original
                while (array.Count > 0)
                {

                    if (array.Count < num)
                    {
                        //Caso a quantidade de elementos restantes no array original seja menor do que o número
                        //de elementos que cada sublista deve conter e que foi passado na função,
                        //existirá uma última sublista com os números restantes.
                        var subList = array.ToList();
                        array.RemoveRange(0, array.Count);
                        listOfLists.Add(subList);
                    }
                    else
                    {
                        //Serão geradas N (quociente) sublistas de acordo com a quantidade de elementos cada
                        //(num) passadas na função.
                        for (int i = 0; i < quotient; i++)
                        {
                            var subList = array.Take(num).ToList();
                            array.RemoveRange(0, num);

                            listOfLists.Add(subList);
                        }
                    }
                }

                return listOfLists;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Main(string[] args)
        {
            // Exemplos para teste. Sinta-se à vontade para completar com outros testes!

            var test1 = QuebraLista(new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9}, 3); // new List<List<int>>{new List<int>{1, 2, 3}, new List<int>{4, 5, 6}, new List<int>{7, 8, 9}}
            foreach (var sublist in test1)
            {
                foreach (var item in sublist)
                {
                    Console.Write($"{item} ");
                }
                Console.Write(" | ");
            }
            Console.WriteLine();

            var test2 = QuebraLista(new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, 3); // new List<List<int>>{new List<int>{1, 2, 3}, new List<int>{4, 5, 6}, new List<int>{7, 8, 9}, new List<int>{10}}
            foreach (var sublist in test2)
            {
                foreach (var item in sublist)
                {
                    Console.Write($"{item} ");
                }
                Console.Write(" | ");
            }
            Console.WriteLine();

            var test3 = QuebraLista(new List<int>{2, 4, 6, 8, 10, 12, 14, 16}, 4); // new List<List<int>>{new List<int>{2, 4, 6, 8}, new List<int>{10, 12, 14, 16}}
            foreach (var sublist in test3)
            {
                foreach (var item in sublist)
                {
                    Console.Write($"{item} ");
                }
                Console.Write(" | ");
            }
            Console.WriteLine();

            var test4 = QuebraLista(new List<int>{2, 4, 6, 8, 10, 12, 14, 16}, 40); // new List<List<int>>{new List<int>{2, 4, 6, 8, 10, 12, 14, 16}}
            foreach (var sublist in test4)
            {
                foreach (var item in sublist)
                {
                    Console.Write($"{item} ");
                }
                Console.Write(" | ");
            }
            Console.WriteLine();

            var test5 = QuebraLista(new List<int>{}, 4); // new List<int>{}
            foreach (var sublist in test5)
            {
                foreach (var item in sublist)
                {
                    Console.Write($"{item} ");
                }
                Console.Write(" | ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

