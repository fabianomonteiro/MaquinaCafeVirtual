using MaquinaCafeVirtual.Ingredientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafeVirtual.Produtos
{
    public class CafeComLeite : ProdutoBase
    {
        public CafeComLeite() : base("Café Com Leite", 3) { }

        protected CafeComLeite(string nome, decimal preco) : base(nome, preco) { }

        public override void CarregarIngredientes(List<IIngrediente> ingredientes)
        {
            ingredientes.Add(new Cafe());
            ingredientes.Add(new Leite());
        }
    }
}
