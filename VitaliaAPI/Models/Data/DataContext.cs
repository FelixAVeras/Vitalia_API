using Microsoft.EntityFrameworkCore;

namespace VitaliaAPI.Models.Data;

public class DataContext : DbContext
{
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<MedicalHistory> MedicalHistories { get; set; }
    public DbSet<Assistant> Assistants { get; set; }
    public DbSet<Invoice> Invoices { get; set; }


    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // Configuración de las relaciones, claves foráneas, etc.
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        // optionsBuilder.UseSqlServer("");
    }
}