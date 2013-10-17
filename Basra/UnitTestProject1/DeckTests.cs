using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Basra;

namespace BasraTest
{
    [TestClass]
    public class DeckTests
    {
        [TestMethod]
        public void test_DeckHas52Cards()
        {
            Deck newDeck = new Deck();

            int count = 0;
            foreach (Card x in newDeck.storage)
            {
                count++;
            }

            Assert.AreEqual(52, count);
        }

        [TestMethod]
        public void test_ReturnRealCard()
        {
            Deck d = new Deck();
            Card returnedCard = d.returnTopCard();
            Assert.IsNotNull(returnedCard);
            //Assert.IsInstanceOfType(returnedCard, typeof(Card));
        }

        [TestMethod]
        public void test_shuffleWorks()
        {
            Deck newDeck = new Deck();
            Card oldTop = newDeck.peekAtTop();
            newDeck.shuffle();
            Card newTop = newDeck.peekAtTop();
            Assert.AreNotSame(oldTop, newTop);
        }
    }
}
