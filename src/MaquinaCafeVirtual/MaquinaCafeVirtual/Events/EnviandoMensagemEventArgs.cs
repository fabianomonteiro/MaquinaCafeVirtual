using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafeVirtual.Events
{
    public class EnviandoMensagemEventArgs : EventArgs
    {
        public string Mensagem { get; private set; }

        public EnviandoMensagemEventArgs(string mensagem)
        {
            this.Mensagem = mensagem;
        }
    }
}
