﻿using System;

namespace Registration.Orders
{
    [Serializable]
    public class OrderLine
    {
        public SeatQuantity SeatQuantity { get; private set; }
        public decimal LineTotal { get; private set; }

        public OrderLine(SeatQuantity seatQuantity, decimal lineTotal)
        {
            SeatQuantity = seatQuantity;
            LineTotal = lineTotal;
        }
    }
}
