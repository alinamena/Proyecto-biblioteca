using System;
using System.Windows.Forms;


public class Reservation
{
    public int ReservationId { get; set; }
    public User ReservedBy { get; set; }
    public Book ReservedBook { get; set; }
    public DateTime ReservationDate { get; set; }
    public DateTime ReturnDate { get; set; }
}
