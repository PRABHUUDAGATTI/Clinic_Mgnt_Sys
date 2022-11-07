using ClinicEntity.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Text;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Clinic_MVC.Controllers
{
    public class LoginTableController : Controller
    {

        private IConfiguration _configuration;
        public LoginTableController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public  async Task<IActionResult> Index(LoginTable login)
        {
            ViewBag.staus = "";
            using (HttpClient client = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(login), Encoding.UTF8, "application/json");
                string endpoint = _configuration["WebApiBaseUrl"] + "LoginTable/Login";
                using (var response = await client.PostAsync(endpoint, content))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        ViewBag.status = "Ok";
                        ViewBag.message = "Admin Login Succesfully";
                    }
                    else
                    {
                        ViewBag.staus = "Error";
                        ViewBag.message = "Wrong Entries";
                    }
                }
            }
            return View();
        }
    }
}
