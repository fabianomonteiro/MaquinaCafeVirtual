using MaquinaCafeVirtual.Extensions;
using MaquinaCafeVirtual.Produtos;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MaquinaCafeVirtual.WindowsForms
{
    public partial class FormMaquinaCafeVirtual : Form
    {
        private IMaquinaCafeVirtual _maquinaCafeVirtual;

        public FormMaquinaCafeVirtual()
        {
            InitializeComponent();
        }

        private void FormMaquinaCafeVirtual_Load(object sender, EventArgs e)
        {
            this._maquinaCafeVirtual = MaquinaCafeVirtualFactory.Create();

            this._maquinaCafeVirtual.EnviandoMensagem += _maquinaCafeVirtual_EnviandoMensagem;
            this._maquinaCafeVirtual.IniciandoPreparo += _maquinaCafeVirtual_IniciandoPreparo1; ;

            this.CarregarCafesDisponiveis();
            this.CarregarComboMoeda();
            this.AtualizarControles();
        }

        private void buttonAdicionarMoeda_Click(object sender, EventArgs e)
        {
            this._maquinaCafeVirtual.AdicionarMoeda((Moeda)Enum.Parse(typeof(Moeda), this.comboBoxMoeda.SelectedValue.ToString()));
            this.AtualizarControles();
        }

        private void buttonIniciarPreparo_Click(object sender, EventArgs e)
        {
            string cafeSelecionado = RetornarCafeSelecionado();
            IProduto produto = this._maquinaCafeVirtual.ProdutosDisponiveis.FirstOrDefault(x => x.Nome == cafeSelecionado);

            _maquinaCafeVirtual.IniciarPreparoAsync(produto,
                callbackSucesso: () =>
                {
                    this.AtualizarControles();
                },
                callbackErro: () =>
                {
                    this.AtualizarControles();
                });
        }

        private void buttonDevolverSaldo_Click(object sender, EventArgs e)
        {
            this._maquinaCafeVirtual.DevolverSaldo();
            this.AtualizarControles();
        }

        private void buttonRetirarTroco_Click(object sender, EventArgs e)
        {
            this._maquinaCafeVirtual.RetirarTroco();
            this.AtualizarControles();
        }

        private void buttonRetirarCafe_Click(object sender, EventArgs e)
        {
            this._maquinaCafeVirtual.RetirarCafe();
            this.AtualizarControles();
        }

        private void _maquinaCafeVirtual_EnviandoMensagem(object sender, Events.EnviandoMensagemEventArgs e)
        {
            this.ThreadSafe(() =>
            {
                this.labelMensagem.Text = e.Mensagem;
                this.Update();
            });
        }

        private void _maquinaCafeVirtual_IniciandoPreparo1(object sender, Events.IniciandoPreparoEventArgs e)
        {
            this.AtualizarControles();
        }

        private void AtualizarControles()
        {
            this.ThreadSafe(() =>
            {
                this.labelSaldo.Text = _maquinaCafeVirtual.Saldo.ToString();
                this.labelTroco.Text = _maquinaCafeVirtual.Troco.ToString();

                foreach (Control item in groupBoxOpcoes.Controls)
                {
                    if (item != this.buttonRetirarCafe)
                        item.Enabled = !_maquinaCafeVirtual.EmPreparo && !_maquinaCafeVirtual.CafeProntoParaRetirar;
                }

                this.buttonRetirarCafe.Enabled = _maquinaCafeVirtual.CafeProntoParaRetirar;

                this.Update();
            });
        }

        private void CarregarCafesDisponiveis()
        {
            for (int i = 0; i < this._maquinaCafeVirtual.ProdutosDisponiveis.Count; i++)
            {
                IProduto produto = this._maquinaCafeVirtual.ProdutosDisponiveis[i];
                RadioButton radioButton = new RadioButton();

                radioButton.Name = produto.Nome;
                radioButton.AutoSize = true;
                radioButton.Text = produto.Nome + " R$ " + string.Format("{0:0.00}", produto.Preco);
                radioButton.Location = new Point(10, (i + 1) * 25);

                this.groupBoxOpcoes.Controls.Add(radioButton);
            }
        }

        private string RetornarCafeSelecionado()
        {
            foreach (var item in this.groupBoxOpcoes.Controls)
            {
                RadioButton radioButton = item as RadioButton;

                if (radioButton != null && radioButton.Checked)
                    return radioButton.Name;
            }

            return null;
        }

        private void CarregarComboMoeda()
        {
            this.comboBoxMoeda.DataSource = Enum.GetValues(typeof(Moeda)).OfType<Moeda>().Select(x => new { Text = x.GetDescription(), Value = x.ToString() }).ToList();
            this.comboBoxMoeda.DisplayMember = "Text";
            this.comboBoxMoeda.ValueMember = "Value";
        }

        private void ThreadSafe(Action action)
        {
            this.Invoke(action);
        }
    }
}
