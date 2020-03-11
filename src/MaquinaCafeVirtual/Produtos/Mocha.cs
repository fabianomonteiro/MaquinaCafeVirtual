using MaquinaCafeVirtual.Ingredientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafeVirtual.Produtos
{
    public class Mocha : CafeComLeite
    {
        public Mocha() : base("Mocha", 4) { }

        public override void CarregarIngredientes(List<IIngrediente> ingredientes)
        {
            ingredientes.Add(new Chocolate());
            ingredientes.Add(new Caramelo());
        }
    }
}
