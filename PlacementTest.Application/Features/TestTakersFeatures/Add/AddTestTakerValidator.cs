using FluentValidation;

namespace PlacementTest.Application.Features.TestTakersFeatures
{
    public sealed class AddTestTakerValidator : AbstractValidator<AddTestTakerRequest>
    {
        public AddTestTakerValidator()
        {
            RuleFor(x => x.Email).NotEmpty().MaximumLength(50).EmailAddress();
            RuleFor(x => x.FirstName).NotEmpty().MinimumLength(2).MaximumLength(50);
            RuleFor(x => x.LastName).NotEmpty().MinimumLength(2).MaximumLength(50);
            RuleFor(x => x.BannerID).NotEmpty().MinimumLength(2).MaximumLength(20);
            RuleFor(x => x.FormNumber).NotEmpty().MinimumLength(2).MaximumLength(35);
        }
    }
}
