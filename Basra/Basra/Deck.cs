using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basra
{
    public enum Suits {CLUBS, HEARTS, DIAMONDS, SPADES};
    public enum Values {ACE = 1, TWO, THREE, FOUR, FIVE, SIX, SEVEN, EIGHT, NINE, TEN, JACK, QUEEN, KING};

    public class Deck
    {
        
        public List<Card> storage = new List<Card>();

        public Deck()
        {
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 13; y++)
                {
                    String cardSuit = null;
                    String cardVal = null;
                    
                    switch(x)
                    {
                        case 0:
                            cardSuit = "CLUBS";
                            break;
                        case 1:
                            cardSuit = "HEARTS";
                            break;
                        case 2:
                            cardSuit = "DIAMONDS";
                            break;
                        case 3:
                            cardSuit = "SPADES";
                            break;
                    }

                    switch (y)
                    {
                        case 0:
                            cardVal = "ACE";
                            break;
                        case 1:
                            cardVal = "TWO";
                            break;
                        case 2:
                            cardVal = "THREE";
                            break;
                        case 3:
                            cardVal = "FOUR";
                            break;
                        case 4:
                            cardVal = "FIVE";
                            break;
                        case 5:
                            cardVal = "SIX";
                            break;
                        case 6:
                            cardVal = "SEVEN";
                            break;
                        case 7:
                            cardVal = "EIGHT";
                            break;
                        case 8:
                            cardVal = "NINE";
                            break;
                        case 9:
                            cardVal = "TEN";
                            break;
                        case 10:
                            cardVal = "JACK";
                            break;
                        case 11:
                            cardVal = "QUEEN";
                            break;
                        case 12:
                            cardVal = "KING";
                            break;
                    }

                    storage.Add(new Card(cardVal, cardSuit));
                }
                }
            }
        
        public Card returnTopCard() 
        {
            Card tempCard = storage.ElementAt(0);
            storage.RemoveAt(0);
            return tempCard;
        }

        public Card peekAtTop()
        {
            return storage.ElementAt(0);
        }

        public void shuffle()
        {
            RandomOrderClass randOrd = new RandomOrderClass();
            storage.Sort(randOrd);
        }

    }
}


