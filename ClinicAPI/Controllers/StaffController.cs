using ClinicBusiness.Services;
using ClinicData.Repository;
using ClinicEntity.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;

namespace ClinicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        StaffService _staffService;
        public StaffController(StaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet("GetAllStaffs")]
        public IEnumerable<OtherStaff> GetAllStaffs()
        {
            return _staffService.GetAllStaffs();
        }

        [HttpPost("AddStaff")]
        public IActionResult AddStaff(OtherStaff otherStaff)
        {
            _staffService.AddStaff(otherStaff);
            return Ok("Staff added successfully");
        }

        [HttpPut("UpdateStaff")]
        public IActionResult UpdateStaff(OtherStaff otherStaff)
        {
            _staffService.UpdateStaff(otherStaff);
            return Ok("Staff updated Successfully");
        }

        [HttpDelete("DeleteStaff")]
        public IActionResult DeleteStaff(int staffId)
        {
            _staffService.DeleteStaff(staffId);
            return Ok("Staff deleted successfully");
        }

        [HttpGet("GetStaffById")]
        public OtherStaff GetStaffById(int staffId)
        {
            return _staffService.GetStaffById(staffId); 
        }
    }
}
