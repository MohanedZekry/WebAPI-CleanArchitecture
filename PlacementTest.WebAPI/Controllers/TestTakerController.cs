using MediatR;
using Microsoft.AspNetCore.Mvc;
using PlacementTest.Application.Features.TestTakersFeatures;
using PlacementTest.Application.Features.TestTakersFeatures.Get;

namespace PlacementTest.WebAPI.Controllers
{
    [ApiController]
    [Route("test-taker")]
    public class TestTakerController : ControllerBase
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
