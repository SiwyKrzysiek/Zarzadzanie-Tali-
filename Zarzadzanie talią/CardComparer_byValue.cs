﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zarzadzanie_talią
{
    public class CardComparer_byValue : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            if (x.Value > y.Value)
                return 1;
            else if (x.Value < y.Value)
                return -1;
            else
                if (x.Suit > y.Suit)
                    return 1;
                else if (x.Suit < y.Suit)
                    return -1;
                else
                    return 0;
        }
    }
}
