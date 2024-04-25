using AutoMapper;
using PlacementTest.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacementTest.Application.Features.TestTakersFeatures
{
    public sealed class AddTestTakerMapper : Profile
    {
        public AddTestTakerMapper()
        {
            CreateMap<AddTestTakerRequest, TestTakers>();
            CreateMap<TestTakers, AddTestTakerResponse>();
        }
    }
}