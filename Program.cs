using System;

namespace Assignment_VI
{
    class Program
    {
        static void Main(string[] args)
        {
            Flight flight1 = new Flight(100, "Vaasa", "Helsinki", new DateTime(2023, 2, 25));
            Flight flight2 = new Flight(200, "Vaasa", "Helsinki", new DateTime(2023, 2, 27));

            EconomyPassenger passenger1 = new EconomyPassenger(1, "Firstname", "Surname", "0401234567");
            FirstClassPassenger passenger2 = new FirstClassPassenger(2, "Firstname", "Surname", "0401234567");

            //Adding tickets to passengers through indexing
            passenger1[0] = new Ticket(1000, 1, flight1, 50f);
            passenger1[0] = new Ticket(2000, 1, flight2, 50f);

            passenger2[0] = new Ticket(3000, 2, flight1, 100f);
            passenger2[0] = new Ticket(4000, 2, flight2, 100f);

            Console.WriteLine(passenger1.ToString());
            Console.WriteLine(passenger2.ToString());

            Console.WriteLine(passenger1.GetPassengerInfo(1));
            Console.WriteLine(passenger2.GetPassengerInfo(2));

        }
    }
}
