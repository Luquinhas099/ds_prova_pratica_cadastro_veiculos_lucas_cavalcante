using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorVeiculos
{
    public abstract class Veiculo
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public decimal PrecoBase { get; set; }

        protected Veiculo(string modelo, decimal precoBase)
        {
            PrecoBase = precoBase;
            Modelo = modelo;
        }

        public abstract decimal CalcularValorSeguro();
    }
}
