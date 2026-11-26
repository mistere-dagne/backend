using AddisEats.Api.Models;
using AddisEats.Api.DTOs;

namespace AddisEats.Api.Mappers;

public static class RestaurantMapper //maps class(model) to DTO
{
    public static RestaurantDTO ToDTO(this Restaurant restaurant)  // a function named ToDTO //this: oop concept //returns a record object(ie RestaurantDTO) 
    {
        return new RestaurantDTO(  //this is hardcode but search for a package? AutoMapper - it does automatically in one line map
            restaurant.Id,
            restaurant.Name,
            restaurant.Address,
            restaurant.Phone,
            restaurant.IsActive
        );
    }
}
//thus mapper is converting class into another type? ie from Restaurant to RestaurantDTo 
//how to use it: RestaurantDTO x = restaurant.ToDTO(); //or var x=
