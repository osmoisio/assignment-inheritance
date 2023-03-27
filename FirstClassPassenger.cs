using System.Text;

namespace Assignment_VI
{
    class FirstClassPassenger : Passenger
    {
        float bonus;
        static string mealMenu = "meals";

        public FirstClassPassenger(int id, string firstName, string surName, string phoneNumber) : base(id, firstName, surName, phoneNumber)
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

        public float Bonus
        {
            get { return bonus; }
        }

        public string MealMenu
        {
            get { return mealMenu; }
        }

        //Override indexer because bonus needs to be calculated
        public override Ticket this[int index]
        {
            set
            {
                tickets.Add(value);
                bonus += value.Price * 0.02f;
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

        public override string GetPassengerInfo(int id)
        {
            if (this.id == id)
            {
                return this.ToString();
            }
            return "";
        }

        public override string ToString()
        {
            StringBuilder ticketInfo = new StringBuilder();
            foreach (Ticket t in tickets)
            {
                ticketInfo.AppendLine(t.ToString());
            }
            return "Passenger: " + id + ", " + firstName + " " + surName + ", Phone: " + phoneNumber + ", Bonus: " + bonus + "e\nTickets:\n" + ticketInfo.ToString();
        }
    }
}
