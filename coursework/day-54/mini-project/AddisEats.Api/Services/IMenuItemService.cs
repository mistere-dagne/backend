using AddisEats.Api.Models;

namespace AddisEats.Api.Services.MenuItemServices;

public interface IMenuItemService //interface vs class //:a class that defines functions and implemented by another class
{
    // 2 methods  bc we have 2 endpoints we created in controllers
    //1
    List<MenuItem> GetAll(string? category); 
    //2
    MenuItem? GetById(int id); 
}