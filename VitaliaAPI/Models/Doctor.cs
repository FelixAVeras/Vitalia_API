namespace VitaliaAPI.Models;

public class Doctor
{
    public int DoctorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Specialty { get; set; }
    public string LicenseNumber { get; set; }

    public ICollection<Appointment> Appointments { get; set; }
}