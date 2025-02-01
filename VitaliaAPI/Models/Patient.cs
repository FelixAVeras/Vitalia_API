namespace VitaliaAPI.Models;

public class Patient
{
    public int PatientId { get; set; }
    public string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string LastName { get; set; }
    public string DocumentNumber { get; set; }
    public DateTime BirthDate { get; set; }
    public int GenderId { get; set; }
    public string? Email { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }

    public Gender Gender { get; set; }
    public ICollection<MedicalHistory> MedicalHistories { get; set; }
    public ICollection<Appointment> Appointments { get; set; }
}