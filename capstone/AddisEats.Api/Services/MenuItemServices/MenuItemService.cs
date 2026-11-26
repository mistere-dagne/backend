using AddisEats.Api.Data;
using AddisEats.Api.Models;

namespace AddisEats.Api.Services.MenuItemServices;

public class MenuItemService : IMenuItemService
{
    private readonly List<MenuItem> _menuItems = SeedData.menuItems;

    public List<MenuItem> ForRestaurant(int restaurantId, string? category)
    {
        var items = _menuItems
            .Where(m => m.RestaurantId == restaurantId)
            .Where(m => category == null || m.Category == category)
            .ToList();

        return items;
    }
}