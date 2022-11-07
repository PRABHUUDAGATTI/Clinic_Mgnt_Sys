using ClinicBusiness;
using ClinicBusiness.Services;
using ClinicEntity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        /*AdminServices _adminServices;
        public AdminController(AdminServices adminServices)
        {
            _adminServices = adminServices;
        }

        [HttpPost("AddAdmin")]
        public IActionResult AddAdmin(Admin admin)
        {
            _adminServices.AddAdmin(admin);
            return Ok("Admin Added Successfully");
        }*/
    }
}
