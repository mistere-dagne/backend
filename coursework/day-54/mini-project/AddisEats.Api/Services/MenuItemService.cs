using AddisEats.Api.Models;

namespace AddisEats.Api.Services.MenuItemServices;

public class MenuItemService : IMenuItemService  //implementation
{
    private readonly List <MenuItem> _menuItems = new() //list of menu items //bc we dont have db
    {
        new MenuItem { Id = 1, Name = "Cheeseburger", Category = "Main Course", Price = 400},
        new MenuItem { Id = 2, Name = "Caesar Salad", Category = "Appetizer", Price = 200},
        new MenuItem { Id = 3, Name = "Choolate Cake", Category = "Dessert", Price = 100} 
        //add 2 more dishes!
    };

    //no constructor needed?

    //implementation of z functions:
    // fun-1 
    public List<MenuItem> GetAll(string? category)
    {
        var items = _menuItems.Where(x => category == null || x.category).ToList(); 

        return items;
    }
    //fun-2
    public MenuItem? GetById(int id)
    {
        return _menuItems.Where(m => m.Id == id).FirstOrDefault;
    }
}