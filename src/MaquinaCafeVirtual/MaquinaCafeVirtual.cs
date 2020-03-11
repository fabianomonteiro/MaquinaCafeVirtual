using MaquinaCafeVirtual.Events;
using MaquinaCafeVirtual.Extensions;
using MaquinaCafeVirtual.Ingredientes;
using MaquinaCafeVirtual.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafeVirtual
{
    /// <summary>
    /// Classe responsável por controlar a maquina de café virtual
    /// </summary>
    internal class MaquinaCafeVirtual : IMaquinaCafeVirtual
    {        
        private List<IProduto> _produtorsDisponiveis;
        /// <summary>
        /// Produtos disponíveis na Máquina de Café Virtual
        /// </summary>
        public IReadOnlyList<IProduto> ProdutosDisponiveis
        {
            get
            {
                if (_produtorsDisponiveis == null)
                    CarregarProdutosDisponiveis();

                return _produtorsDisponiveis;
            }
        }

        /// <summary>
        /// Indica se há algum produto em preparo no momento
        /// </summary>
        public bool EmPreparo { get; private set; }

        /// <summary>
        /// Indica se há algum café pronto para ser retirado
        /// </summary>
        public bool CafeProntoParaRetirar { get; private set; }

        /// <summary>
        /// Indica o saldo em dinheiro adicionado à maquina de café virtual
        /// </summary>
        public decimal Saldo { get; private set; }

        /// <summary>
        /// Indica o troco em dinheiro disponível para ser retirado
        /// </summary>
        public decimal Troco { get; private set; }

        /// <summary>
        /// Adiciona moeda à maquina de café virtual
        /// </summary>
        /// <param name="moeda">O parâmetro moeda recebe um enum com as moedas que são aceitas na maquina de café virtual</param>
        public void AdicionarMoeda(Moeda moeda)
        {
            string descricao = moeda.GetDescription();
            decimal valor = (decimal)moeda / 100;

            if (valor <= 0.05M)
            {
                DispararEventoEnviandoMensagem("Moedas de 1 e 5 Centavos não são permitidas.");
                Troco += valor;
            }
            else
            {
                DispararEventoEnviandoMensagem($"Moeda de {descricao} adicionada.");
                Saldo += valor;
            }
        }

        /// <summary>
        /// Método responsável por iniciar o preparo de um produto
        /// </summary>
        /// <param name="produto">Produto a ser preparado</param>
        /// <param name="callbackSucesso">Callback retornado em caso de sucesso</param>
        /// <param name="callbackErro">Callback retornado em caso de erro</param>
        /// <returns></returns>
        public async Task IniciarPreparoAsync(IProduto produto, Action callbackSucesso = null, Action callbackErro = null)
        {
            await Task.Run(() =>
            {
                if (produto == null)
                {
                    DispararEventoEnviandoMensagem("Selecione o café desejado.");

                    if (callbackErro != null)
                        callbackErro.Invoke();

                    return;
                }

                try
                {
                    produto.Comprar(this.Saldo);
                    Saldo -= produto.Preco;
                }
                catch (Exception ex)
                {
                    DispararEventoEnviandoMensagem(ex.Message);

                    if (callbackErro != null)
                        callbackErro.Invoke();

                    return;
                }

                this.EmPreparo = true;
                this.DispararEventoIniciandoPreparo();

                DispararEventoEnviandoMensagem($"Iniciando o preparo do {produto.Nome}, por favor aguarde alguns instantes.");

                this.EsquentarAgua();

                foreach (var item in produto.Ingredientes)
                {
                    AnimarMensagem($"Adicionando {item.Nome}, por favor aguarde alguns instantes");
                }

                DispararEventoEnviandoMensagem($"{produto.Nome} pronto, pode retirar.");

                this.EmPreparo = false;
                this.CafeProntoParaRetirar = true;

                if (callbackSucesso != null)
                    callbackSucesso.Invoke();
            });
        }

        /// <summary>
        /// Método responsável por esquentar a água da maquina de café virtual
        /// </summary>
        private void EsquentarAgua()
        {
            AnimarMensagem("Esquentando a água, por favor aguarde alguns instantes");
        }

        /// <summary>
        /// Método responsável por devolver o saldo adicionado na maquina de café virtual
        /// </summary>
        public void DevolverSaldo()
        {
            this.Troco += this.Saldo;
            this.Saldo = 0;
        }

        /// <summary>
        /// Método responsável por retirar o troco da maquina de café virtual
        /// </summary>
        public void RetirarTroco()
        {
            this.Troco = 0;
        }

        /// <summary>
        /// Método responsável por retirar o café da maquina de café virtual
        /// </summary>
        public void RetirarCafe()
        {
            if (!this.CafeProntoParaRetirar)
            {
                DispararEventoEnviandoMensagem($"Não há café para ser retirado.");
            }
            else
            {
                this.CafeProntoParaRetirar = false;
                DispararEventoEnviandoMensagem($"Café retirado.");
            }
        }

        /// <summary>
        /// Método responsável por disparar o evento EnviandoMensagem
        /// </summary>
        /// <param name="mensagem"></param>
        private void DispararEventoEnviandoMensagem(string mensagem)
        {
            if (EnviandoMensagem != null)
                EnviandoMensagem.Invoke(this, new EnviandoMensagemEventArgs(mensagem));
        }

        /// <summary>
        /// Método responsável por disparar o evento IniciandoPreparo
        /// </summary>
        private void DispararEventoIniciandoPreparo()
        {
            if (this.IniciandoPreparo != null)
                this.IniciandoPreparo.Invoke(this, new IniciandoPreparoEventArgs());
        }

        /// <summary>
        /// Método responsável por carregar os produtos disponíveis
        /// </summary>
        private void CarregarProdutosDisponiveis()
        {
            this._produtorsDisponiveis = new List<IProduto>();

            IEnumerable<Type> types = Helpers.ReflectionHelper.FindDerivedTypes<ProdutoBase>();

            foreach (var type in types)
            {
                IProduto produto = (IProduto)Activator.CreateInstance(type);

                this._produtorsDisponiveis.Add(produto);
            }
        }

        /// <summary>
        /// Método responsável por animar as mensagens
        /// </summary>
        /// <param name="mensagem"></param>
        private void AnimarMensagem(string mensagem)
        {
            for (int p = 0; p < 3; p++)
            {
                for (int i = 0; i < 3; i++)
                {
                    DispararEventoEnviandoMensagem(mensagem + string.Empty.PadRight(i + 1, '.'));
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }

        /// <summary>
        /// Evento disparado quando há uma nova mensagem a ser exibida
        /// </summary>
        public event EnviandoMensagem EnviandoMensagem;

        /// <summary>
        /// Evento disparado quando um novo preparo é iniciado
        /// </summary>
        public event IniciandoPreparo IniciandoPreparo;
    }
}
