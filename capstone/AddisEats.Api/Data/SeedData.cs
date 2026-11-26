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



public static List<MenuItem> menuItems = new()
{
    // Restaurant 1 - Addis Ababa Restaurant
    new MenuItem { Id = 1, RestaurantId = 1, Name = "Doro Wat", Category = "Main Course", Price = 450 },
    new MenuItem { Id = 2, RestaurantId = 1, Name = "Tibs", Category = "Main Course", Price = 380 },
    new MenuItem { Id = 3, RestaurantId = 1, Name = "Shiro", Category = "Main Course", Price = 180 },
    new MenuItem { Id = 4, RestaurantId = 1, Name = "Sambusa", Category = "Appetizer", Price = 80 },
    new MenuItem { Id = 5, RestaurantId = 1, Name = "Firfir", Category = "Breakfast", Price = 150 },
    new MenuItem { Id = 6, RestaurantId = 1, Name = "Baklava", Category = "Dessert", Price = 120 },

    // Restaurant 2 - Blue Nile Restaurant
    new MenuItem { Id = 7, RestaurantId = 2, Name = "Kitfo", Category = "Main Course", Price = 420 },
    new MenuItem { Id = 8, RestaurantId = 2, Name = "Gored Gored", Category = "Main Course", Price = 400 },
    new MenuItem { Id = 9, RestaurantId = 2, Name = "Misir Wat", Category = "Main Course", Price = 180 },
    new MenuItem { Id = 10, RestaurantId = 2, Name = "Azifa", Category = "Appetizer", Price = 100 },
    new MenuItem { Id = 11, RestaurantId = 2, Name = "Chechebsa", Category = "Breakfast", Price = 160 },
    new MenuItem { Id = 12, RestaurantId = 2, Name = "Fruit Salad", Category = "Dessert", Price = 130 },

    // Restaurant 3 - Lucy Restaurant
    new MenuItem { Id = 13, RestaurantId = 3, Name = "Beyaynet", Category = "Main Course", Price = 250 },
    new MenuItem { Id = 14, RestaurantId = 3, Name = "Special Tibs", Category = "Main Course", Price = 480 },
    new MenuItem { Id = 15, RestaurantId = 3, Name = "Gomen Besiga", Category = "Main Course", Price = 300 },
    new MenuItem { Id = 16, RestaurantId = 3, Name = "Sambusa", Category = "Appetizer", Price = 80 },
    new MenuItem { Id = 17, RestaurantId = 3, Name = "Enkulal Firfir", Category = "Breakfast", Price = 170 },
    new MenuItem { Id = 18, RestaurantId = 3, Name = "Baklava", Category = "Dessert", Price = 120 },

    // Restaurant 4 - Ethio Restaurant
    new MenuItem { Id = 19, RestaurantId = 4, Name = "Doro Wat", Category = "Main Course", Price = 450 },
    new MenuItem { Id = 20, RestaurantId = 4, Name = "Dulet", Category = "Main Course", Price = 280 },
    new MenuItem { Id = 21, RestaurantId = 4, Name = "Shiro", Category = "Main Course", Price = 180 },
    new MenuItem { Id = 22, RestaurantId = 4, Name = "Timatim Fitfit", Category = "Appetizer", Price = 120 },
    new MenuItem { Id = 23, RestaurantId = 4, Name = "Kinche", Category = "Breakfast", Price = 140 },
    new MenuItem { Id = 24, RestaurantId = 4, Name = "Fruit Salad", Category = "Dessert", Price = 130 },

    // Restaurant 5 - Tena Yistilign Restaurant
    new MenuItem { Id = 25, RestaurantId = 5, Name = "Kitfo", Category = "Main Course", Price = 420 },
    new MenuItem { Id = 26, RestaurantId = 5, Name = "Tibs", Category = "Main Course", Price = 380 },
    new MenuItem { Id = 27, RestaurantId = 5, Name = "Fasolia", Category = "Main Course", Price = 160 },
    new MenuItem { Id = 28, RestaurantId = 5, Name = "Azifa", Category = "Appetizer", Price = 100 },
    new MenuItem { Id = 29, RestaurantId = 5, Name = "Chechebsa", Category = "Breakfast", Price = 160 },
    new MenuItem { Id = 30, RestaurantId = 5, Name = "Honey Bread", Category = "Dessert", Price = 100 },

    // Restaurant 6 - Kategna Restaurant
    new MenuItem { Id = 31, RestaurantId = 6, Name = "Special Kategna", Category = "Main Course", Price = 220 },
    new MenuItem { Id = 32, RestaurantId = 6, Name = "Doro Wat", Category = "Main Course", Price = 450 },
    new MenuItem { Id = 33, RestaurantId = 6, Name = "Gomen", Category = "Main Course", Price = 160 },
    new MenuItem { Id = 34, RestaurantId = 6, Name = "Sambusa", Category = "Appetizer", Price = 80 },
    new MenuItem { Id = 35, RestaurantId = 6, Name = "Firfir", Category = "Breakfast", Price = 150 },
    new MenuItem { Id = 36, RestaurantId = 6, Name = "Baklava", Category = "Dessert", Price = 120 },

    // Restaurant 7 - Sishu Restaurant
    new MenuItem { Id = 37, RestaurantId = 7, Name = "Burger", Category = "Main Course", Price = 350 },
    new MenuItem { Id = 38, RestaurantId = 7, Name = "Chicken Sandwich", Category = "Main Course", Price = 280 },
    new MenuItem { Id = 39, RestaurantId = 7, Name = "Beef Pizza", Category = "Main Course", Price = 500 },
    new MenuItem { Id = 40, RestaurantId = 7, Name = "French Fries", Category = "Appetizer", Price = 120 },
    new MenuItem { Id = 41, RestaurantId = 7, Name = "Pancakes", Category = "Breakfast", Price = 180 },
    new MenuItem { Id = 42, RestaurantId = 7, Name = "Chocolate Cake", Category = "Dessert", Price = 160 },

    // Restaurant 8 - Abay Restaurant
    new MenuItem { Id = 43, RestaurantId = 8, Name = "Beyaynet", Category = "Main Course", Price = 250 },
    new MenuItem { Id = 44, RestaurantId = 8, Name = "Gored Gored", Category = "Main Course", Price = 400 },
    new MenuItem { Id = 45, RestaurantId = 8, Name = "Misir Wat", Category = "Main Course", Price = 180 },
    new MenuItem { Id = 46, RestaurantId = 8, Name = "Timatim Fitfit", Category = "Appetizer", Price = 120 },
    new MenuItem { Id = 47, RestaurantId = 8, Name = "Kinche", Category = "Breakfast", Price = 140 },
    new MenuItem { Id = 48, RestaurantId = 8, Name = "Fruit Salad", Category = "Dessert", Price = 130 },

    // Restaurant 9 - Fendika Restaurant
    new MenuItem { Id = 49, RestaurantId = 9, Name = "Special Tibs", Category = "Main Course", Price = 480 },
    new MenuItem { Id = 50, RestaurantId = 9, Name = "Kitfo", Category = "Main Course", Price = 420 },
    new MenuItem { Id = 51, RestaurantId = 9, Name = "Gomen Besiga", Category = "Main Course", Price = 300 },
    new MenuItem { Id = 52, RestaurantId = 9, Name = "Azifa", Category = "Appetizer", Price = 100 },
    new MenuItem { Id = 53, RestaurantId = 9, Name = "Chechebsa", Category = "Breakfast", Price = 160 },
    new MenuItem { Id = 54, RestaurantId = 9, Name = "Honey Bread", Category = "Dessert", Price = 100 },

    // Restaurant 10 - Doro Wat Restaurant
    new MenuItem { Id = 55, RestaurantId = 10, Name = "Doro Wat", Category = "Main Course", Price = 450 },
    new MenuItem { Id = 56, RestaurantId = 10, Name = "Tibs", Category = "Main Course", Price = 380 },
    new MenuItem { Id = 57, RestaurantId = 10, Name = "Fasolia", Category = "Main Course", Price = 160 },
    new MenuItem { Id = 58, RestaurantId = 10, Name = "Sambusa", Category = "Appetizer", Price = 80 },
    new MenuItem { Id = 59, RestaurantId = 10, Name = "Enkulal Firfir", Category = "Breakfast", Price = 170 },
    new MenuItem { Id = 60, RestaurantId = 10, Name = "Chocolate Cake", Category = "Dessert", Price = 160 },

    // Restaurant 11 - Injera Restaurant
    new MenuItem { Id = 61, RestaurantId = 11, Name = "Beyaynet", Category = "Main Course", Price = 250 },
    new MenuItem { Id = 62, RestaurantId = 11, Name = "Shiro", Category = "Main Course", Price = 180 },
    new MenuItem { Id = 63, RestaurantId = 11, Name = "Dulet", Category = "Main Course", Price = 280 },
    new MenuItem { Id = 64, RestaurantId = 11, Name = "Timatim Fitfit", Category = "Appetizer", Price = 120 },
    new MenuItem { Id = 65, RestaurantId = 11, Name = "Firfir", Category = "Breakfast", Price = 150 },
    new MenuItem { Id = 66, RestaurantId = 11, Name = "Baklava", Category = "Dessert", Price = 120 },

    // Restaurant 12 - Bunna Restaurant
    new MenuItem { Id = 67, RestaurantId = 12, Name = "Kitfo", Category = "Main Course", Price = 420 },
    new MenuItem { Id = 68, RestaurantId = 12, Name = "Gored Gored", Category = "Main Course", Price = 400 },
    new MenuItem { Id = 69, RestaurantId = 12, Name = "Misir Wat", Category = "Main Course", Price = 180 },
    new MenuItem { Id = 70, RestaurantId = 12, Name = "Azifa", Category = "Appetizer", Price = 100 },
    new MenuItem { Id = 71, RestaurantId = 12, Name = "Chechebsa", Category = "Breakfast", Price = 160 },
    new MenuItem { Id = 72, RestaurantId = 12, Name = "Honey Bread", Category = "Dessert", Price = 100 }
};

}