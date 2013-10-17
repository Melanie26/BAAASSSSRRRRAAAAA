using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasraTest
{
    [TestClass]
    public class CardTest1
    {
        [TestMethod]
        public void Test_ReturnSuit()
        {
            Card card1 = new Card("ACE", "SPADES");
            String expectedSuit = "SPADES";
            Assert.AreEqual(expectedSuit, card1.getSuit());
        }

        [TestMethod]
        public void Test_ReturnValue()
        {
            Card card1 = new Card("ACE", "SPADES");
            String expectedValue = "ACE";
            Assert.AreEqual(expectedValue, card1.getValue());
        }

        public void Cardhasavalue()
        {
            Card c = new Card("ID");
            Assert.AreEqual("ID", c.Value);
        }
    }
}
