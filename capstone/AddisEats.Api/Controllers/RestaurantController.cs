using Microsoft.AspNetCore.Mvc; //always when creating a controller
using AddisEats.Api.Mappers;
using AddisEats.Api.Services.RestaurantServices;
using AddisEats.Api.Services.MenuItemServices;

namespace AddisEats.Api.Controllers;

[ApiController] //annotation refrencing that this class is controller's
[Route("api/v1/[controller]")] //endpoints need route

public class RestaurantController : ControllerBase  //implementation
{
    private readonly IRestaurantService _restaurantService; //service injection?
    private readonly IMenuItemService _menuItemService;
    public RestaurantController(IRestaurantService restaurantService, IMenuItemService menuItemService)  
    {
        _restaurantService = restaurantService;
        _menuItemService = menuItemService; //multiple service 
    } //service dependency injection using a constructor
    
    //now our end points :
    [HttpGet("{id}")]
    public IActionResult GetRestaurantById (int id)  //returns anything
    {
        var restaurant= _restaurantService.GetById(id); //calls and put on z var
        
        if (restaurant==null)
        {
            return NotFound(); //400
        }
        
        return Ok(restaurant); //ok wz response body ie restaurant
    }

    [HttpGet()]
    public IActionResult GetAllRestaurants([FromQuery] string? address, [FromQuery] int page=1, [FromQuery] int pageSize=3) //queries //default values(incase not sent from frontend)
    {
        var restaurants = _restaurantService.GetAll(address, page, pageSize);
        
        var restaurantDTOs = restaurants.Select(r=>r.ToDTO()).ToList();  

        return Ok(restaurantDTOs); 
    }
    //* when implementation called , the service goes

    //lets add one more endpoint
    [HttpGet("{id}/menu")]
    public IActionResult GetMenu(int id, [FromQuery] string? category)
    {
        if (_restaurantService.GetById(id) is null)
        {
            return NotFound();
        }

        var items = _menuItemService.ForRestaurant(id, category)
            .Select(m => m.ToDTO())
            .ToList();

        return Ok(items);
    }
}


