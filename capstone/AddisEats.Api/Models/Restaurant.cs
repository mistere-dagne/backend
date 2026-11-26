namespace AddisEats.Api.Models;

public class Restaurant
{
 public int Id { get; init; } //init - allows assignment during object initialization only
 public string Name { get; set; } = "";
 public string Address { get; set; } = "";
 public string Phone { get; set; } = "";
 public bool IsActive { get; set; } = true;
public string OwnerName { get; set; } = "";
 public string OwnerPhone { get; set; } = "";
}

