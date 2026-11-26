using AddisEats.Api.Models;

namespace AddisEats.Api.Data;
public class SeedData    //for if u want by default when z app starts by seeding some datas - since we dont have a db yet
{
    //lets create a list 
    public static List<Restaurant> restaurants = new List<Restaurant>
    {
        //list of 12 restaurants  //seed data
        new Restaurant { Id = 1, Name = "Addis Ababa Restaurant", Address = "Bole", Phone = "555-1234", IsActive = true, OwnerName = "Abebe Kebede", OwnerPhone = "555-1001" },

        new Restaurant { Id = 2, Name = "Blue Nile Restaurant", Address = "Ayat", Phone = "555-5678", IsActive = false, OwnerName = "Abeba Hailu", OwnerPhone = "555-1002" },

        new Restaurant { Id = 3, Name = "Lucy Restaurant", Address = "Mexico", Phone = "555-9012", IsActive = true, OwnerName = "Belay Kindu", OwnerPhone = "555-1003" },

        new Restaurant { Id = 4, Name = "Ethio Restaurant", Address = "Megenagna", Phone = "555-3456", IsActive = true, OwnerName = "Gete Worku", OwnerPhone = "555-1004" },

        new Restaurant { Id = 5, Name = "Tena Yistilign Restaurant", Address = "Bole", Phone = "555-7890", IsActive = true, OwnerName = "Selam Fikir", OwnerPhone = "555-1005" },

        new Restaurant { Id = 6, Name = "Kategna Restaurant", Address = "Megenagna", Phone = "555-2345", IsActive = true, OwnerName = "Zeweter Desta", OwnerPhone = "555-1006" },

        new Restaurant { Id = 7, Name = "Sishu Restaurant", Address = "Bole", Phone = "555-6789", IsActive = false, OwnerName = "Alemayehu Eshetu", OwnerPhone = "555-1007" },

        new Restaurant { Id = 8, Name = "Abay Restaurant", Address = "Megenagna", Phone = "555-0123", IsActive = true, OwnerName = "Selamawit Worku", OwnerPhone = "555-1008" },

        new Restaurant { Id = 9, Name = "Fendika Restaurant", Address = "Mexico", Phone = "555-4567", IsActive = false, OwnerName = "Mekdes Haile", OwnerPhone = "555-1009" },

        new Restaurant { Id = 10, Name = "Doro Wat Restaurant", Address = "Megenagna", Phone = "555-8901", IsActive = true, OwnerName = "Getachew Assefa", OwnerPhone = "555-1010" },

        new Restaurant { Id = 11, Name = "Injera Restaurant", Address = "Mexico", Phone = "555-2345", IsActive = true, OwnerName = "Bethlehem Abate", OwnerPhone = "555-1011" },

        new Restaurant { Id = 12, Name = "Bunna Restaurant", Address = "Ayat", Phone = "555-6789", IsActive = true, OwnerName = "Mulugeta Desta", OwnerPhone = "555-1012" }
    };

}
