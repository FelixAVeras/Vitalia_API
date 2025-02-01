using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VitaliaAPI.Models;
using VitaliaAPI.Models.Data;

namespace VitaliaAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PatientsController : ControllerBase
{
    private readonly DataContext _context;

    public PatientsController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Patient>>> GetPatients()
    {
        return await _context.Patients.Include(p => p.Gender).ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Patient>> GetPatient(int id)
    {
        var patient = await _context.Patients
                                    .Include(p => p.Gender)
                                    .FirstOrDefaultAsync(p => p.PatientId == id);

        if (patient != null)
        {
            return patient;
        }
        
        return NotFound();

    }
}