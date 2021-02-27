using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepCounter.API.Controllers
{
	[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		public ActionResult<IEnumerable<int>> Get()
		{
			return new[] { 1, 2, 3 };
		}
	}
}
