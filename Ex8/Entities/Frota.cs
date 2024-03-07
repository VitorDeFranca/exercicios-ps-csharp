using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8.Entities
{
    public class Frota
    {
        public int FrotaId { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public List<Veiculo>? Veiculos { get; set; }

        public Frota(int frotaId, string razaoSocial, string cnpj, List<Veiculo>? veiculos)
        {
            FrotaId = frotaId;
            RazaoSocial = razaoSocial;
            CNPJ = cnpj;
            Veiculos = veiculos;
        }
    }
}
