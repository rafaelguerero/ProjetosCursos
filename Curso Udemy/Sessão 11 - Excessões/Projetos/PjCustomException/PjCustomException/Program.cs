using PjCustomException.Entities;
using PjCustomException.Entities.Exceptions;
using System;

namespace PjCustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Check-in date: ");
                DateTime checkin = DateTime.Parse(Console.ReadLine());

                Console.Write("Check-out date: ");
                DateTime checkout = DateTime.Parse(Console.ReadLine());


                Reservation reservation = new Reservation(number, checkin, checkout);
                Console.WriteLine(reservation.ToString());

                Console.WriteLine();
                Console.WriteLine("Enter the data to update reservation: ");
                checkin = DateTime.Parse(Console.ReadLine());
                checkout = DateTime.Parse(Console.ReadLine());

                reservation.UpdateDates(checkin, checkout);

                Console.WriteLine(reservation.ToString());
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}
