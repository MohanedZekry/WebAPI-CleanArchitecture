namespace PlacementTest.Application.Features.TestTakersFeatures.Get
{
    public sealed record GetAllTestTakersResponse
    {
        public Guid ID { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FormNumber { get; set; }
        public string BannerID { get; set; }
    }
}
