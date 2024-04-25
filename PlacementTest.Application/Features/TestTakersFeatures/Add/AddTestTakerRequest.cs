using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacementTest.Application.Features.TestTakersFeatures
{
    public sealed record AddTestTakerRequest(string Email, string FirstName, string LastName, string BannerID, string FormNumber) : IRequest<AddTestTakerResponse>;
}
