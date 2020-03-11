using MaquinaCafeVirtual.Events;
using MaquinaCafeVirtual.Produtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MaquinaCafeVirtual
{
    public interface IMaquinaCafeVirtual
    {
        IReadOnlyList<IProduto> ProdutosDisponiveis { get; }

        bool EmPreparo { get; }

        bool CafeProntoParaRetirar { get; }

        decimal Saldo { get; }

        decimal Troco { get; }

        void AdicionarMoeda(Moeda moeda);        

        Task IniciarPreparoAsync(IProduto produto, Action callbackSucesso = null, Action callbackErro = null);

        void DevolverSaldo();

        void RetirarTroco();

        void RetirarCafe();

        event EnviandoMensagem EnviandoMensagem;

        event IniciandoPreparo IniciandoPreparo;
    }
}
