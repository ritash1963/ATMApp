using System;
using System.Linq;
using API.DTOs;
using API.Entities;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AccountDto,Account>();
            CreateMap<Account,AccountDto>();
            CreateMap<OperationDto,Operation>();
            CreateMap<Operation,OperationDto>();
        }
    }
}
