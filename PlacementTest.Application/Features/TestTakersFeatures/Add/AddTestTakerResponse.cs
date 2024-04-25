using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacementTest.Application.Features.TestTakersFeatures
{
    public sealed record class AddTestTakerResponse
    {
        public Guid ID { get; set; }
        public string BannerID { get; set; }
    }
}
