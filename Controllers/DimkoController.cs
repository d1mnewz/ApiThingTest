using Microsoft.AspNetCore.Mvc;

namespace ApiThingTest.Controllers
{
	[ApiController]
	[Route("api/dimko")]
	public sealed class DimkoController : ControllerBase
	{
		[HttpGet, Route("must-be-nice")]
		public bool MustBeNice() => true;

		[HttpGet, Route("/must-not-be-nice")]
		public bool MustNotBeNice() => true;
	}
}
