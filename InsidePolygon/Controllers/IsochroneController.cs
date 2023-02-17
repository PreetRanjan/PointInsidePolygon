using InsidePolygon.Models;
using Knowwhere.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace InsidePolygon.Controllers
{
    [Route("api/[action]")]
    [ApiController]
    public class IsochroneController : ControllerBase
    {
        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> PointInsidePolygon([FromBody] Request request)
        {
            var response = new Response();
            response.IsInside = IsoService.isInside(request.Polygon, request.Polygon.Length, request.InputPoint);
            response.Message = response.IsInside ? "Point is inside the given polygon" : "Point is not inside the polygon";
            return Ok(response);
        }
    }
}
