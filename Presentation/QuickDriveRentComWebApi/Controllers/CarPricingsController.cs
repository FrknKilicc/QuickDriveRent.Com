using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuickDriveRentCom.Application.Features.Mediator.Queries.CarPricingQueries;
using QuickDriveRentCom.Application.Features.Mediator.Queries.LocationQueries;

namespace QuickDriveRentComWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarPricingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarPricingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetCarPricingWithCarList()
        {
            var values = await _mediator.Send(new GetCarPricingQuery());
            return Ok(values);

        }
    }
}
