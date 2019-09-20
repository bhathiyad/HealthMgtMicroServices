
using HealthMgt.AuthMicroService.ViewModels.Validations;
using FluentValidation.Attributes;

namespace HealthMgt.AuthMicroService.ViewModels
{
    [Validator(typeof(CredentialsViewModelValidator))]
    public class CredentialsViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
