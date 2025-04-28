using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Booking
    {
        public int BookingId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int RoomId { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public bool IsConfirmed { get; set; }

        public virtual User User { get; set; }
        public virtual Room Room { get; set; }
    }
}