using System;
using System.Text;

namespace Assignment_VI
{
    class Ticket
    {
        int ticketID;
        int passengerID;
        Flight flight;
        float price;
        readonly float extraTax;

        public Ticket(int ticketID, int passengerID, Flight flight, float price)
        {
            this.ticketID = ticketID;
            this.passengerID = passengerID;
            this.flight = flight;

            if (flight.Date.DayOfWeek.Equals(DayOfWeek.Saturday) || flight.Date.DayOfWeek.Equals(DayOfWeek.Sunday))
            {
                extraTax = 0.07f;
            }
            else
            {
                extraTax = 0.05f;
            }

            this.price = price + (extraTax * price);
        }

        public float Price
        {
            get { return price; }
        }

        public int TicketID
        {
            get { return ticketID; }
        }

        public float GetPrice(int ticketID)
        {
            if (this.ticketID == ticketID)
            {
                return price;
            }
            return 0;
        }

        public string GetTicketInfo(Passenger[] passengers)
        {
            StringBuilder result = new StringBuilder();
            foreach (Passenger p in passengers)
            {
                p.ToString();
            }
            return result.ToString();
        }

        public override string ToString()
        {
            return ticketID + ", " + passengerID + ", [Flight: " + flight.ToString() + "], " + price + "e (Including extra tax " + extraTax + ")";
        }
    }
}
