using System.Text;

namespace Assignment_VI
{
    class EconomyPassenger : Passenger
    {
        static float luggageWeight = 20f;

        public EconomyPassenger(int id, string firstName, string surName, string phoneNumber) : base(id, firstName, surName, phoneNumber)
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
            return "Passenger: " + id + ", " + firstName + " " + surName + ", Phone: " + phoneNumber + ", Luggage weight: " + luggageWeight + "kg\nTickets:\n" + ticketInfo.ToString();
        }
    }
}
