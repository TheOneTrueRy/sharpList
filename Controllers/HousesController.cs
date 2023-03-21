using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace sharpList.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class HousesController : ControllerBase
  {
    private readonly HousesService housesService;

    public HousesController(HousesService housesService)
    {
      this.housesService = housesService;
    }

    [HttpGet]
    public ActionResult<List<House>> GetAllHouses()
    {
      try
      {
        List<House> houses = housesService.GetAllHouses();
        return Ok(houses);
      }
      catch (Exception e)
      {
        return BadRequest(e.Message);
      }
    }
  }
}