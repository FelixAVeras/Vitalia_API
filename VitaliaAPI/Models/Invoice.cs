namespace VitaliaAPI.Models;

public class Invoice
{
    public int InvoiceId { get; set; } // Primary key as int
    public int AppointmentId { get; set; } // Relationship with Appointment
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
    public string Status { get; set; } // e.g. Pending, Paid

    // Relationship with Appointment
    public Appointment Appointment { get; set; }
}