using BuberBreakfast.Contracts.Breakfast;
using Microsoft.AspNetCore.DataProtection.Internal;
using Microsoft.AspNetCore.Mvc;

namespace BuberBreakfast.Controllers;

[ApiController]
public class Breakfastcontroller:ControllerBase
{
  [HttpPost("/breakfast")]
  public IActionResult Createbreakfast(CreatebreakfastRequest request)
  {
    return Ok(request);
  }

  [HttpGet("/breakfasts/{id.guid}")]
  public IActionResult GetBreakfast(Guid id)
  {
    return Ok(id);
  }

  [HttpPut("/breakfast/{id:guid}")]
  public IActionResult UpsertBreakfast(Guid id, UpsertBreakfastRequest request)
  {
    return Ok(request);
  }

  [HttpDelete("/breakfast/{id :guid}")]
  public IActionResult DeleteBreakfast(Guid id)
  {
    
  }
}