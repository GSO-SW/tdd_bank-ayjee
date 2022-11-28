using Bank;
using Konto_test;

namespace Konto_test
{
    [TestClass]
    public class KontoTests
    {
        [TestMethod]

        // Arrage
        public void Einzahlen_SteigertGuthaben()
        {
            int startguthaben = 100;
            int einzahlungsbetrag = 20;
            Konto k1 = new Konto(startguthaben);

            int guthben_soll = startguthaben + einzahlungsbetrag;

            //Act
            k1.Einzahlen(einzahlungsbetrag);

            //Assert
            Assert.AreEqual(guthben_soll, k1.Guthaben);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Einzahlen_NegativerBetrag()
        {
            //Arrange
            int startguthaben = 100;
            Konto k1 = new Konto(startguthaben);
            int einzahlungsbetrag = -1;

            int guthaben_soll = startguthaben + einzahlungsbetrag;


            //Act
            k1.Einzahlen(einzahlungsbetrag);
        }
    }
}