using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Assignment_VI
{
    class Passenger
    {
        protected int id;
        protected string firstName;
        protected string surName;
        protected string phoneNumber;
        protected List<Ticket> tickets = new List<Ticket>();

        protected string phoneNumberPattern = @"^([0-9]{10})$";
        protected Regex phoneRegEx;

        public Passenger(int id, string firstName, string surName, string phoneNumber)
        {
            InitRegEx();

            this.id = id;
            this.firstName = firstName;
            this.surName = surName;

            if (phoneRegEx.IsMatch(phoneNumber))
            {
                this.phoneNumber = phoneNumber;
            }
            else
            {
                this.phoneNumber = "Unknown";
            }
        }

        //Indexer to add ticket objects to list
        public virtual Ticket this[int index]
        {
            set
            {
                tickets.Add(value);
            }
            get
            {
                foreach (Ticket ticket in tickets)
                {
                    if (ticket.TicketID == index)
                    {
                        return ticket;
                    }
                }
                return null;
            }
        }

        public void InitRegEx()
        {
            phoneRegEx = new Regex(phoneNumberPattern);
        }

        public virtual string GetPassengerInfo(int id)
        {
            if (this.id == id)
            {
                return this.ToString();
            }
            return "";
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (Ticket t in tickets)
            {
                result.AppendLine(t.ToString());
            }
            if (result.ToString().Equals(""))
            {
                return "Passenger: " + id + ", " + firstName + " " + surName + ", Phone: " + phoneNumber;
            }
            return "Passenger: " + id + ", " + firstName + " " + surName + ", Phone: " + phoneNumber + "\nTickets:\n" + result.ToString();
        }
    }
}
