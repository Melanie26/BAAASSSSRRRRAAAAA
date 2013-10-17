using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basra
{
    public class Card
    {
        
        String cardValue;
        String suitValue;

        public Card(String value, String suit)
        {
            cardValue = value;
            suitValue = suit;
        }

        public String getValue()
        {
            return cardValue;
        }

        public String getSuit()
        {
            return suitValue;
        }

    }
}
