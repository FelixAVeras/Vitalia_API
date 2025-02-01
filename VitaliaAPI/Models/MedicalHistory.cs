namespace VitaliaAPI.Models;

public class MedicalHistory
{
    public int MedicalHistoryId { get; set; } // Primary key as int
    public int PatientId { get; set; } // Relationship with Patient
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public string Diagnosis { get; set; }

    public Patient Patient { get; set; }
}