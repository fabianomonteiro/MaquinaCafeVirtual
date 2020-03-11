using MaquinaCafeVirtual.Ingredientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafeVirtual.Produtos
{
    public class Cappuccino : CafeComLeite
    {
        public Cappuccino() : base("Cappuccino", 3.5M) { }

        public override void CarregarIngredientes(List<IIngrediente> ingredientes)
        {
            ingredientes.Add(new EspumaLeite());
        }
    }
}
