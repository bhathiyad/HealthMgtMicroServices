using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Events;
using MassTransit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthMgt.OnlineAppointmentMgt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IBus _bus;

        public AppointmentController(IBus bus)
        {
            _bus = bus;
        }

        // GET: api/Appointment
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            int AppointmentId = 1;
            int CustomerId = 1;
            DateTime appointmentDate = DateTime.Now;
            await _bus.Publish<AppointmentAddEvent>(new { AppointmentId , CustomerId, DateTime.Now });
            return Ok("Success");
            //return new string[] { "value1", "value2" };
        }

        // GET: api/Appointment/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Appointment
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] string value)
        {
            //TODO: Call repository and pass data to appointment database

            await _bus.Publish<AppointmentAddEvent>(new { AppointmentId = 1, CustomerId = 1, DateTime.Now });
            return Ok("Success");
        }

        // PUT: api/Appointment/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
