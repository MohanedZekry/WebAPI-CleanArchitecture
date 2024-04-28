using MediatR;
using Microsoft.AspNetCore.Mvc;
using PlacementTest.Application.Features.TestTakersFeatures;
using PlacementTest.Application.Features.TestTakersFeatures.Get;
using PlacementTest.WebAPI.Controllers.Base;

namespace PlacementTest.WebAPI.Controllers
{

    public class TestTakerController : BaseController
    {
        private readonly IMediator _mediator;

        public TestTakerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllTestTakersResponse>>> GetAll(CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(new GetAllTestTakersRequest(), cancellationToken);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<AddTestTakerResponse>> Create(AddTestTakerRequest request,
            CancellationToken cancellationToken)
        {
            var response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }
    }
}
