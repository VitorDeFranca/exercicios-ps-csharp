using System.Linq;

namespace exercicio4
{

    public class Usuario
    {
        public string Email { get; }
        public string Nome { get; }
        public string Senha { get; }

        public Usuario(string email, string nome)
        {
            this.Email = email;
            this.Nome = nome;
            this.Senha = Guid.NewGuid().ToString();
        }
    }
    public class Program
    {
        public static List<Usuario> IdentificaDuplicados(List<Usuario> array)
        {
            try
            {
                if (array is null) throw new Exception("ERRO");

                //SelectMany() é usado para "desagrupar" os grupos formados pelo GroupBy()
                List<Usuario> repeatedEmailsList = array.GroupBy(x => x.Email)
                    .Where(x => x.Count() > 1)
                    .SelectMany(g => g)
                    .ToList();

                return repeatedEmailsList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Main(string[] args)
        {
            // Exemplos para teste. Sinta-se à vontade para completar com outros testes!
            // Obs: Como a função retorna uma lista de objetos, a resposta abaixo apenas representa o(s) objeto(s) retornados!

            var test1 = IdentificaDuplicados(new List<Usuario> {
                new Usuario("jc@cmu.com.br", "João Carlos"),
                new Usuario("ana@cmu.com.br", "Ana Maria"),
                new Usuario("pedro@cmu.com.br", "Pedro Almeida"),
                new Usuario("joaozin@cmu.com.br", "João Marcelo")}); // new List<Usuario> {}

            var test2 = IdentificaDuplicados(new List<Usuario> {
                new Usuario("joaozin@cmu.com.br", "João Carlos"),
                new Usuario("ana@cmu.com.br", "Ana Maria"),
                new Usuario("pedro@cmu.com.br", "Pedro Almeida"),
                new Usuario("joaozin@cmu.com.br", "João Marcelo")}); // new List<Usuario> {Usuario{"João Carlos"}, Usuario{"João Marcelo"}}

            var test3 = IdentificaDuplicados(new List<Usuario> {}); // new List<Usuario> {}
                
            var test4 = IdentificaDuplicados(null); // ERRO
        }
    }
}

