
using AutoMapper;
using TezAPI.Application.ViewModel.Users;
using TezAPI.Domain.Entities;

namespace TezAPI.Presentation.Utilitiys.AutoMapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<UserRegisterModel, User>();
           
        }



    }
}
