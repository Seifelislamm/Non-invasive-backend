using Microsoft.AspNetCore.Mvc;
using GlucoseMonitoringApp.Models;
using System.Text.Json;

namespace GlucoseMonitoringApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MeasurementsController : ControllerBase
    {
        [HttpGet("latest")]
        public IActionResult GetLatest()
        {
            var dummy = new Measurement
            {
                Glucose = 120,
                Spo2 = 98,
                HeartRate = 72,
                BloodPressure = "120/80",
                Timestamp = DateTime.UtcNow
            };
            return Ok(dummy);
        }
    }
}
