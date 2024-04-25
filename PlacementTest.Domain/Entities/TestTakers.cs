using PlacementTest.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlacementTest.Domain.Entities
{
    public class TestTakers : BaseEntity
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FormNumber { get; set; }
        public string BannerID { get; set; }
    }
}
