using AddisEats.Api.Models;
using Microsoft.AspNetCore.Mvc; //always when creating controller
using AddisEats.Api.Services.MenuItemServices;

namespace AddisEats.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")] //essentials 

public class MenuItemController : ControllerBase
{
    
    
    private readonly IMenuItemService _menuItemService; 
    public MenuItemController(IMenuItemService menuItemService)  //dependency injection*
    {
        _menuItemService = menuItemService;
    }

    
    [HttpGet]
    public IActionResult GetAll([FromQuery] string? category) 
    {
        var result = _menuItemService.GetAll(category); // 
        return Ok(result); //
    } 


    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var result = _menuItemService.GetById(id); //

        if (result == null)  //
        {
            return NotFound(); 
        }
        return Ok(result); //
    }
}

