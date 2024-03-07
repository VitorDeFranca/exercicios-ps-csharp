using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8.Entities
{
    public class Veiculo
    {
        public int VeiculoId { get; set; }
        public int? FrotaId { get; set; }
        public Frota? Frota { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Ano { get; set; }
        public int Kilometragem { get; set; }
        public byte QtdPortasSimples { get; set; }
        public byte QtdPortasCorrer { get; set; }
        public byte QtdLugares { get; set; }

        public Veiculo(int veiculoId, int frotaId, string tipo, string marca, string modelo, string ano, int kilometragem,
            byte qtdPortasSimples, byte qtdPortasCorrer)
        {
            VeiculoId = veiculoId;
            FrotaId = frotaId;
            Tipo = tipo;
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Kilometragem = kilometragem;
            QtdPortasSimples = qtdPortasSimples;
            QtdPortasCorrer = qtdPortasCorrer;
            if (tipo.ToLower() == "van")
            {
                QtdLugares = 12;
            }
            else if (tipo.ToLower() == "carro")
            {
                QtdLugares = 5;
            }
            else if (tipo.ToLower() == "moto")
            {
                QtdLugares = 2;
            }


        }


    }

    
}
