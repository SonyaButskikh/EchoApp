using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace EchoApp.Controllers
{
        [Route("[controller]")]
    public class EchoController : Controller
    {

        [HttpGet]
        public async Task Get()
        {
            Response.ContentType = "text/plain";
            await Response.WriteAsync("GET request received");
        }

        [HttpPost]
        public async Task Post()
        {
            Response.ContentType = "text/plain";
            await Response.WriteAsync("POST request received");
        }

        [HttpGet("Echo/Headers")]
        public async Task Headers()
        {
            Response.ContentType = "application/json";
            await Response.WriteAsJsonAsync(Request.Headers);
        }

        [HttpGet("Echo/Query")]
        public async Task Query()
        {
            Response.ContentType = "application/json";
            await Response.WriteAsJsonAsync(Request.Query);
        }

        [HttpPost("Echo/Body")]
        public async Task Body()
        {
            Response.ContentType = "text/plain";
            var body = await new StreamReader(Request.Body).ReadToEndAsync();
            await Response.WriteAsync(body);
        }
    }
}