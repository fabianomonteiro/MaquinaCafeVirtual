using MaquinaCafeVirtual.Ingredientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafeVirtual.Produtos
{
    /// <summary>
    /// Classe base para os produtos disponíveis na maquina de café virtual
    /// </summary>
    public abstract class ProdutoBase : IProduto
    {
        /// <summary>
        /// Nome do produto
        /// </summary>
        public string Nome { get; protected set; }

        /// <summary>
        /// Preço do produto
        /// </summary>
        public decimal Preco { get; private set; }

        List<IIngrediente> _ingredientes;
        /// <summary>
        /// Ingredientes do produto
        /// </summary>
        public IReadOnlyList<IIngrediente> Ingredientes { get => _ingredientes; }

        /// <summary>
        /// Método construtor do produto
        /// </summary>
        /// <param name="nome">Nome do produto</param>
        /// <param name="preco">Preço do produto</param>
        public ProdutoBase(string nome, decimal preco)
        {
            this.Nome = nome;
            this.Preco = preco;
            this._ingredientes = new List<IIngrediente>();
            this.CarregarIngredientes(_ingredientes);
        }

        /// <summary>
        /// Método responsável por validar a compra do produto
        /// </summary>
        /// <param name="saldo"></param>
        /// <returns></returns>
        public decimal Comprar(decimal saldo)
        {
            if (saldo < Preco)
                throw new Exception($"Saldo insuficiente para comprar o {Nome}.");

            return saldo - Preco;
        }

        /// <summary>
        /// Método abstrato para carregamento dos ingredientes do produto
        /// </summary>
        /// <param name="ingredientes"></param>
        public abstract void CarregarIngredientes(List<IIngrediente> ingredientes);
    }
}
