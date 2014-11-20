﻿using System;
using ENode.Eventing;
using Registration.Orders;

namespace Registration.SeatAssigning
{
    [Serializable]
    public class SeatAssigned : DomainEvent<Guid>
    {
        public int Position { get; private set; }
        public Guid SeatType { get; private set; }
        public Attendee Attendee { get; private set; }

        public SeatAssigned(Guid sourceId, int position, Guid seatType, Attendee attendee) : base(sourceId)
        {
            Position = position;
            SeatType = seatType;
            Attendee = attendee;
        }
    }
}
