using Events;
using MassTransit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthMgt.InvoiceMgtMicroService.Messaging.Consumers
{
    public class AppointmentAddEventConsumer : IConsumer<AppointmentAddEvent>
    {
        //private readonly IApplicantRepository _applicantRepository;

        public AppointmentAddEventConsumer()
        {
            //_applicantRepository = applicantRepository;
        }

        //public async Task Consume(ConsumeContext<ApplicantAppliedEvent> context)
        //{
        //    await _applicantRepository.AddApplicantSubmission(new ApplicantSubmission
        //    {
        //        JobId = context.Message.JobId,
        //        ApplicantId = context.Message.ApplicantId,
        //        Title = context.Message.Title,
        //        SubmissionDate = context.Message.CreationDate
        //    });
        //}

        public Task Consume(ConsumeContext<AppointmentAddEvent> context)
        {
            throw new NotImplementedException();
        }
    }
}
