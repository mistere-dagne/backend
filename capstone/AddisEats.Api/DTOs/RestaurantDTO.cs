namespace AddisEats.Api.DTOs;

public record RestaurantDTO
(
 int Id,
 string Name,
 string Address,
 string Phone,
 bool IsActive
 );

 //these are the specific datas we want sent by z api