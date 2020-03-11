using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafeVirtual
{
    public static class MaquinaCafeVirtualFactory
    {
        /// <summary>
        /// Método responsável por criar uma instância da maquina de café virtual
        /// </summary>
        /// <returns></returns>
        public static IMaquinaCafeVirtual Create()
        {
            return new MaquinaCafeVirtual();
        }
    }
}
