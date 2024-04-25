using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacementTest.Application.Features.TestTakersFeatures.Get
{
    public sealed record GetAllTestTakersRequest : IRequest<List<GetAllTestTakersResponse>>;
}
