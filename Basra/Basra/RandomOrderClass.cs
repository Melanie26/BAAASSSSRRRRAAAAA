using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basra
{
    class RandomOrderClass : IComparer<Card>
    {
        private Random gen1 = new Random();

        public int Compare(Card x, Card y)
        {
            return gen1.Next(-1, 1);
        }
    }
}
