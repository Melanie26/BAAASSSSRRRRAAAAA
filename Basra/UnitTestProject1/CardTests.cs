using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Basra;

namespace BasraTest
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void test_CardHasValue()
        {
            Card testCard = new Card("ACE", "SPADES");
            Assert.AreEqual("ACE", testCard.getValue());

        }

        [TestMethod]
        public void test_CardHasSuit()
        {
            Card c = new Card("EIGHT","HEARTS");
            Assert.AreEqual("HEARTS", c.getSuit());
        }
    }
}
