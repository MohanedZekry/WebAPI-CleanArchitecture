using AutoMapper;
using PlacementTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacementTest.Application.Features.TestTakersFeatures.Get
{
    public sealed class GetAllTestTakersMapper : Profile
    {
        public GetAllTestTakersMapper()
        {
            CreateMap<TestTakers, GetAllTestTakersResponse>();
        }
    }
}
