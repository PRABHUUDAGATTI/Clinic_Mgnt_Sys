using ClinicBusiness;
using ClinicEntity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        PatientService _patientService;
        public PatientController(PatientService patientService)
        {
            _patientService = patientService;
        }

        [HttpPost("AddPatient")]
        public IActionResult AddPatient(Patient patient)
        {
            _patientService.AddPatient(patient);
            return Ok("Patient Added Successfully");
        }
    }
}
