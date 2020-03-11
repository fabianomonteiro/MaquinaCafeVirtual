using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafeVirtual.Ingredientes
{
    /// <summary>
    /// Classe base para os ingredientes
    /// </summary>
    public abstract class IngredienteBase : IIngrediente
    {
        /// <summary>
        /// Nome do ingrediente
        /// </summary>
        public string Nome { get; protected set; }

        /// <summary>
        /// Método construtor do ingrediente
        /// </summary>
        /// <param name="nome">Nome do ingrediente</param>
        public IngredienteBase(string nome)
        {
            this.Nome = nome;
        }
    }
}
