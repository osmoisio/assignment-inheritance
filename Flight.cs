using System;

namespace Assignment_VI
{
    class Flight
    {
        int id;
        string origin;
        string destination;
        DateTime date;

        public Flight(int id, string origin, string destination, DateTime date)
        {
            this.id = id;
            this.origin = origin;
            this.destination = destination;
            this.date = date;
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string GetFlightInfo(int id)
        {
            if (id == this.id)
            {
                return this.ToString();
            }
            return "";
        }

        public override string ToString()
        {
            return id + ", from " + origin + " to " + destination + ", " + date.ToString("dd.MM.yyyy");
        }
    }
}
