namespace VitaliaAPI.Models;

public class Appointment
{
    public int AppointmentId { get; set; } // Primary key as int
    public int PatientId { get; set; } // Relationship with Patient
    public int DoctorId { get; set; } // Relationship with Doctor
    public DateTime DateTime { get; set; } // Date and time of the appointment
    public string Reason { get; set; }
    public string Status { get; set; } // e.g. Pending, Completed, Cancelled

    // Relationships
    public Patient Patient { get; set; }
    public Doctor Doctor { get; set; }
}