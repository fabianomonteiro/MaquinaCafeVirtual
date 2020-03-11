using MaquinaCafeVirtual.Ingredientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafeVirtual.Produtos
{
    public interface IProduto
    {
        string Nome { get; }

        decimal Preco { get; }

        IReadOnlyList<IIngrediente> Ingredientes { get; }

        decimal Comprar(decimal saldo);
    }
}
