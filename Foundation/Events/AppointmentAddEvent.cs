using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public class AppointmentAddEvent : IntegrationEvent
    {
        public int AppointmentId { get; set; }
        public int CustomerId { get; set; }
        public DateTime AppointmentDate { get; set; }

        public AppointmentAddEvent()
        {

        }
        public AppointmentAddEvent(int appointmentId, int customerId, DateTime appointmentDate)
        {
            AppointmentId = appointmentId;
            CustomerId = customerId;
            AppointmentDate = appointmentDate;
        }
    }
}
