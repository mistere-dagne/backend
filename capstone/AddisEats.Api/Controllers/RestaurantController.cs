using Microsoft.AspNetCore.Mvc; //always when creating a controller
using AddisEats.Api.Data;
using AddisEats.Api.DTOs;
using AddisEats.Api.Models;
using AddisEats.Api.Mappers;

namespace AddisEats.Api.Controllers;

[ApiController] //annotation refrencing that this class is controller's
[Route("api/v1/[controller]")] //endpoints need route

public class RestaurantController : ControllerBase  //implementation
{
    private readonly List<Restaurant> allRestaurants = SeedData.restaurants;

    //our end points :
    [HttpGet("{id}")]
    public IActionResult GetRestaurantById (int id)  //returns anything
    {
        var restaurant= allRestaurants.Where(r=>r.Id==id).FirstOrDefault();
        if (restaurant==null)
        {
            return NotFound(); //400
        }
        return Ok(restaurant.ToDTO()); //ok wz response body ie restaurant
    }

    [HttpGet()]
    public IActionResult GetAllRestaurants([FromQuery] string? address, [FromQuery] int page=1, [FromQuery] int pageSize=3) //queries //default values(incase not sent from frontend)
    {
         var restaurants = allRestaurants
            .Where(r=>address==null || r.Address == address)
            .OrderBy(r=>r.Name)
            .Skip((page-1)*pageSize)   //pagenation?
            .Take(pageSize)
            .ToList();
        
        var restaurantDTOs = restaurants.Select(r=>r.ToDTO()).ToList();  //Select built in*
        
        return Ok(restaurantDTOs); 
    }
}

