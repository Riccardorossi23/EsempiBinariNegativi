using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EsempiBinariNegativi_Tests
{
    [TestClass]
    public class BinariNegativi_Tests
    {
        [TestMethod]
        public void VisualizzaMax()
        {
            string aspettato = "11111";
            string valore_effettivo = EsempiBinariNegativi.BinariNegativi.VisualizzaMax(31);
            Assert.AreEqual(aspettato, valore_effettivo);

        }
    }
}
