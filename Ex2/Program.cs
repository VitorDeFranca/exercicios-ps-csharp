using System.ComponentModel;
using System.Text;

namespace exercicio2
{
    public class Program
    {
        public static int ContaAparicoes(string frase, string palavra, int counter = 0)
        {
            try
            {
                //caso a frase ou a palavra sejam nulos a função já retorna 0;
                if (frase == string.Empty || palavra == string.Empty) return 0;

            
                while (frase.Contains(palavra))
                {
                    //enquanto a frase conter a palavra o programa irá detectar o index de início da palavra
                    //e removê-la, somando mais um no contador a cada incidência da palavra removida.
                    var startIndexOfPalavra = frase.IndexOf(palavra);
                    frase = frase.Remove(startIndexOfPalavra, palavra.Length);

                    counter++;
                }

                return counter;
            }
            catch (Exception)
            {
                //é importante retornar apenas throw no catch
                //para preservar a stack, que irá apontar qual método causou a exceção
                throw;
            }
        }

        public static void Main(string[] args)
        {
            // Exemplos para teste. Sinta-se à vontade para completar com outros testes!

            var test1 = ContaAparicoes("Banana", "a"); // 3
            var test2 = ContaAparicoes("Banana", "na"); // 2
            var test3 = ContaAparicoes("Banana", "ka"); // 0
            var test4 = ContaAparicoes("BBBBBBBBB", "BB"); // 4
        }
    }
}

