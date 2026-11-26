namespace AddisEats.Api.DTOs;

public record MenuItemDTO(
    int Id,
    string Name,
    string Category,
    decimal Price,
    decimal PriceWithVat
);