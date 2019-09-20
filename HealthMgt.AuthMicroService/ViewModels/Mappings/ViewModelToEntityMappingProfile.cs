
using HealthMgt.AuthMicroService.Models;
using AutoMapper;
using HealthMgt.AuthMicroService.DAO;

namespace HealthMgt.AuthMicroService.ViewModels.Mappings
{
    public class ViewModelToEntityMappingProfile : Profile
    {
        public ViewModelToEntityMappingProfile()
        {
            CreateMap<RegistrationViewModel, AppUserEntity>().ForMember(au => au.UserName, map => map.MapFrom(vm => vm.Email));
        }
    }
}
