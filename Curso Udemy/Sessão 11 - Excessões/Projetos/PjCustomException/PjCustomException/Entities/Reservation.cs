using PjCustomException.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PjCustomException.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Erro in reservation: Chec-kout date must be after a check-in date.");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new DomainException("Error in reservation: Reservation dates for update must be future dates");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("Erro in reservation: Check-out date must be after a check-in date.");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;          
        }

        public override string ToString()
        {
            return "Room " + RoomNumber + ", CheckIn: " + CheckIn.ToString("dd/MM/yyyy") + 
                ", CheckOut: " + CheckOut.ToString("dd/MM/yyyy") + ", " + Duration() + " nights.";
        }        
    }
}
