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



            [TestMethod]

            [ExpectedException(typeof(ArgumentOutOfRangeException))]

            public void Konto_KannNichtMitNegativemBetragErstelltWerden()

            {

            // Arrange 

            int guthaben = -1;


            // Act 

            Konto k = new Konto(guthaben);

        }



        [TestMethod]

        public void KontoNr_KannAbgefragtWerden()

        {

            // Arrange 

            Konto k = new Konto(0);

            int nummer_soll = 1;

            // Act 

            int nummer_ist = k.KontoNr;

            //Arrange 

            Assert.AreEqual(nummer_soll, nummer_ist);

        }



        [TestMethod]

        public void KontoNr_WirdAutomatischVergeben()

        {

            // Arrange 

            Konto k1 = new Konto(0);

            Konto k2 = new Konto(0);

            Konto k3 = new Konto(0);

            int kontoNummer_soll = 3;

            // Act 

            int kontoNummer_ist = k3.KontoNr;

            // Assert 

            Assert.AreEqual(kontoNummer_soll, kontoNummer_ist);

        }

    }

}

