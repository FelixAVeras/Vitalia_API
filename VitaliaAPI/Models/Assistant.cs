namespace VitaliaAPI.Models;

public class Assistant
{
    public int AssistantId { get; set; } // Primary key as int
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    // Relationship with appointments
    public ICollection<Appointment> Appointments { get; set; }
}