using AddisEats.Api.Models;
using AddisEats.Api.DTOs;

namespace AddisEats.Api.Mappers;

public static class MenuItemMapper
{
    public static MenuItemDTO ToDTO(this MenuItem menuItem)
    {
        return new MenuItemDTO(
            menuItem.Id,
            menuItem.Name,
            menuItem.Category,
            menuItem.Price,
            menuItem.PriceWithVat
        );
    }
}