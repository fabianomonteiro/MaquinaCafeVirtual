using System;
using System.Threading.Tasks;
using MaquinaCafeVirtual.Produtos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaquinaCafeVirtual.UnitTest
{
    [TestClass]
    public class MaquinaCafeVirtualUnitTest
    {
        [TestMethod]
        public void TestarRejeicaoMoedaUmCentavo()
        {
            IMaquinaCafeVirtual maquinaCafeVirtual = MaquinaCafeVirtualFactory.Create();

            maquinaCafeVirtual.AdicionarMoeda(Moeda.UmCentavo);

            Assert.AreEqual(maquinaCafeVirtual.Troco, 0.01M);
        }

        [TestMethod]
        public void TestarRejeicaoMoedaCincoCentavos()
        {
            IMaquinaCafeVirtual maquinaCafeVirtual = MaquinaCafeVirtualFactory.Create();

            maquinaCafeVirtual.AdicionarMoeda(Moeda.CincoCentavos);

            Assert.AreEqual(maquinaCafeVirtual.Troco, 0.05M);
        }

        [TestMethod]
        public void TestarMoedaDezCentavos()
        {
            IMaquinaCafeVirtual maquinaCafeVirtual = MaquinaCafeVirtualFactory.Create();

            maquinaCafeVirtual.AdicionarMoeda(Moeda.DezCentavos);

            Assert.AreEqual(maquinaCafeVirtual.Saldo, 0.10M);
        }

        [TestMethod]
        public void TestarMoedaVinteCincoCentavos()
        {
            IMaquinaCafeVirtual maquinaCafeVirtual = MaquinaCafeVirtualFactory.Create();

            maquinaCafeVirtual.AdicionarMoeda(Moeda.VinteCincoCentavos);

            Assert.AreEqual(maquinaCafeVirtual.Saldo, 0.25M);
        }

        [TestMethod]
        public void TestarMoedaCinquentaCentavos()
        {
            IMaquinaCafeVirtual maquinaCafeVirtual = MaquinaCafeVirtualFactory.Create();

            maquinaCafeVirtual.AdicionarMoeda(Moeda.CinquentaCentavos);

            Assert.AreEqual(maquinaCafeVirtual.Saldo, 0.50M);
        }

        [TestMethod]
        public void TestarMoedaUmReal()
        {
            IMaquinaCafeVirtual maquinaCafeVirtual = MaquinaCafeVirtualFactory.Create();

            maquinaCafeVirtual.AdicionarMoeda(Moeda.UmReal);

            Assert.AreEqual(maquinaCafeVirtual.Saldo, 1);
        }

        [TestMethod]
        public void TestarCalculoSaldoTroco()
        {
            IMaquinaCafeVirtual maquinaCafeVirtual = MaquinaCafeVirtualFactory.Create();

            maquinaCafeVirtual.AdicionarMoeda(Moeda.UmCentavo);
            maquinaCafeVirtual.AdicionarMoeda(Moeda.CincoCentavos);
            maquinaCafeVirtual.AdicionarMoeda(Moeda.DezCentavos);
            maquinaCafeVirtual.AdicionarMoeda(Moeda.VinteCincoCentavos);
            maquinaCafeVirtual.AdicionarMoeda(Moeda.CinquentaCentavos);
            maquinaCafeVirtual.AdicionarMoeda(Moeda.UmReal);

            Assert.AreEqual(maquinaCafeVirtual.Saldo, 1.85M);
            Assert.AreEqual(maquinaCafeVirtual.Troco, 0.06M);
        }

        [TestMethod]
        public async Task TestarCompraSemSelecionarCafe()
        {
            IMaquinaCafeVirtual maquinaCafeVirtual = MaquinaCafeVirtualFactory.Create();

            await maquinaCafeVirtual.IniciarPreparoAsync(null,
                callbackSucesso: () =>
                {
                    Assert.Fail();
                });
        }

        [TestMethod]
        public async Task TestarCompraCafeSemSaldo()
        {
            IMaquinaCafeVirtual maquinaCafeVirtual = MaquinaCafeVirtualFactory.Create();

            await maquinaCafeVirtual.IniciarPreparoAsync(new Cappuccino(),
                callbackSucesso: () =>
                {
                    Assert.Fail();
                });
        }

        [TestMethod]
        public async Task TestarCompraCafeSaldoMenor()
        {
            IMaquinaCafeVirtual maquinaCafeVirtual = MaquinaCafeVirtualFactory.Create();

            maquinaCafeVirtual.AdicionarMoeda(Moeda.UmReal);
            maquinaCafeVirtual.AdicionarMoeda(Moeda.UmReal);

            await maquinaCafeVirtual.IniciarPreparoAsync(new Cappuccino(),
                callbackSucesso: () =>
                {
                    Assert.Fail();
                });
        }

        [TestMethod]
        public async Task TestarCompraCafeSaldoMaior()
        {
            IMaquinaCafeVirtual maquinaCafeVirtual = MaquinaCafeVirtualFactory.Create();

            maquinaCafeVirtual.AdicionarMoeda(Moeda.UmReal);
            maquinaCafeVirtual.AdicionarMoeda(Moeda.UmReal);
            maquinaCafeVirtual.AdicionarMoeda(Moeda.UmReal);
            maquinaCafeVirtual.AdicionarMoeda(Moeda.UmReal);

            Assert.AreEqual(maquinaCafeVirtual.Saldo, 4);

            await maquinaCafeVirtual.IniciarPreparoAsync(new Cappuccino());

            Assert.AreEqual(maquinaCafeVirtual.Saldo, 0.5M);
        }
    }
}
