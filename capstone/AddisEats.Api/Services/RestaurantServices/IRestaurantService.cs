using AddisEats.Api.Models;

namespace AddisEats.Api.Services.RestaurantServices;

public interface IRestaurantService
{
    //get by id method
    Restaurant? GetById(int id); //nullable
   //another method
    List<Restaurant> GetAll(string? address, int page, int pageSize);
    // List<Restaurant> Search(string? area); //query for search //but nvm lets include it in the above function
}