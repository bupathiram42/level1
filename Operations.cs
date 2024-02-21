using System;
using System.Collections.Generic;
using System.Linq;

namespace Application;

public static partial class Operations
{
    public static List<MenuItem> menu = new List<MenuItem>();

    private static Cache s_cache = new Cache(3);

    internal static void LoadDefaultData()
    {
        menu.Add(new MenuItem() { UserId = "UID101", MealTime = MealTime.BREAKFAST, Category = Category.STARTERS, DishName = "Poori" });
        menu.Add(new MenuItem() { UserId = "UID101", MealTime = MealTime.BREAKFAST, Category = Category.MAINCOURSE, DishName = "Upma" });
        menu.Add(new MenuItem() { UserId = "UID101", MealTime = MealTime.BREAKFAST, Category = Category.DESSERTS, DishName = "Kesari" });
        menu.Add(new MenuItem() { UserId = "UID101", MealTime = MealTime.BREAKFAST, Category = Category.BEVERAGES, DishName = "Chai" });
        menu.Add(new MenuItem() { UserId = "UID102", MealTime = MealTime.BREAKFAST, Category = Category.STARTERS, DishName = "Idli" });
        menu.Add(new MenuItem() { UserId = "UID102", MealTime = MealTime.BREAKFAST, Category = Category.MAINCOURSE, DishName = "Dosa" });
        menu.Add(new MenuItem() { UserId = "UID102", MealTime = MealTime.BREAKFAST, Category = Category.DESSERTS, DishName = "Pongal" });
        menu.Add(new MenuItem() { UserId = "UID102", MealTime = MealTime.BREAKFAST, Category = Category.BEVERAGES, DishName = "Filter Coffee" });
        menu.Add(new MenuItem() { UserId = "UID103", MealTime = MealTime.BREAKFAST, Category = Category.STARTERS, DishName = "Vada" });
        menu.Add(new MenuItem() { UserId = "UID103", MealTime = MealTime.BREAKFAST, Category = Category.MAINCOURSE, DishName = "Uttapam" });
        menu.Add(new MenuItem() { UserId = "UID103", MealTime = MealTime.BREAKFAST, Category = Category.DESSERTS, DishName = "Halwa" });
        menu.Add(new MenuItem() { UserId = "UID103", MealTime = MealTime.BREAKFAST, Category = Category.BEVERAGES, DishName = "Tea" });
        menu.Add(new MenuItem() { UserId = "UID101", MealTime = MealTime.LUNCH, Category = Category.STARTERS, DishName = "Poori" });
        menu.Add(new MenuItem() { UserId = "UID101", MealTime = MealTime.LUNCH, Category = Category.MAINCOURSE, DishName = "Upma" });
        menu.Add(new MenuItem() { UserId = "UID101", MealTime = MealTime.LUNCH, Category = Category.DESSERTS, DishName = "Kesari" });
        menu.Add(new MenuItem() { UserId = "UID101", MealTime = MealTime.LUNCH, Category = Category.BEVERAGES, DishName = "Chai" });
        menu.Add(new MenuItem() { UserId = "UID102", MealTime = MealTime.LUNCH, Category = Category.STARTERS, DishName = "Idli" });
        menu.Add(new MenuItem() { UserId = "UID102", MealTime = MealTime.LUNCH, Category = Category.MAINCOURSE, DishName = "Dosa" });
        menu.Add(new MenuItem() { UserId = "UID102", MealTime = MealTime.LUNCH, Category = Category.DESSERTS, DishName = "Pongal" });
        menu.Add(new MenuItem() { UserId = "UID102", MealTime = MealTime.LUNCH, Category = Category.BEVERAGES, DishName = "Filter Coffee" });
        menu.Add(new MenuItem() { UserId = "UID103", MealTime = MealTime.LUNCH, Category = Category.STARTERS, DishName = "Vada" });
        menu.Add(new MenuItem() { UserId = "UID103", MealTime = MealTime.LUNCH, Category = Category.MAINCOURSE, DishName = "Uttapam" });
        menu.Add(new MenuItem() { UserId = "UID103", MealTime = MealTime.LUNCH, Category = Category.DESSERTS, DishName = "Halwa" });
        menu.Add(new MenuItem() { UserId = "UID103", MealTime = MealTime.LUNCH, Category = Category.BEVERAGES, DishName = "Tea" });
        menu.Add(new MenuItem() { UserId = "UID101", MealTime = MealTime.DINNER, Category = Category.STARTERS, DishName = "Poori" });
        menu.Add(new MenuItem() { UserId = "UID101", MealTime = MealTime.DINNER, Category = Category.MAINCOURSE, DishName = "Upma" });
        menu.Add(new MenuItem() { UserId = "UID101", MealTime = MealTime.DINNER, Category = Category.DESSERTS, DishName = "Kesari" });
        menu.Add(new MenuItem() { UserId = "UID101", MealTime = MealTime.DINNER, Category = Category.BEVERAGES, DishName = "Chai" });
        menu.Add(new MenuItem() { UserId = "UID102", MealTime = MealTime.DINNER, Category = Category.STARTERS, DishName = "Idli" });
        menu.Add(new MenuItem() { UserId = "UID102", MealTime = MealTime.DINNER, Category = Category.MAINCOURSE, DishName = "Dosa" });
        menu.Add(new MenuItem() { UserId = "UID102", MealTime = MealTime.DINNER, Category = Category.DESSERTS, DishName = "Pongal" });
        menu.Add(new MenuItem() { UserId = "UID102", MealTime = MealTime.DINNER, Category = Category.BEVERAGES, DishName = "Filter Coffee" });
        menu.Add(new MenuItem() { UserId = "UID103", MealTime = MealTime.DINNER, Category = Category.STARTERS, DishName = "Vada" });
        menu.Add(new MenuItem() { UserId = "UID103", MealTime = MealTime.DINNER, Category = Category.MAINCOURSE, DishName = "Uttapam" });
        menu.Add(new MenuItem() { UserId = "UID103", MealTime = MealTime.DINNER, Category = Category.DESSERTS, DishName = "Halwa" });
        menu.Add(new MenuItem() { UserId = "UID103", MealTime = MealTime.DINNER, Category = Category.BEVERAGES, DishName = "Tea" });
        menu.Add(new MenuItem() { UserId = "UID101", MealTime = MealTime.SNACKS, Category = Category.STARTERS, DishName = "Poori" });
        menu.Add(new MenuItem() { UserId = "UID101", MealTime = MealTime.SNACKS, Category = Category.MAINCOURSE, DishName = "Upma" });
        menu.Add(new MenuItem() { UserId = "UID101", MealTime = MealTime.SNACKS, Category = Category.DESSERTS, DishName = "Kesari" });
        menu.Add(new MenuItem() { UserId = "UID101", MealTime = MealTime.SNACKS, Category = Category.BEVERAGES, DishName = "Chai" });
        menu.Add(new MenuItem() { UserId = "UID102", MealTime = MealTime.SNACKS, Category = Category.STARTERS, DishName = "Idli" });
        menu.Add(new MenuItem() { UserId = "UID102", MealTime = MealTime.SNACKS, Category = Category.MAINCOURSE, DishName = "Dosa" });
        menu.Add(new MenuItem() { UserId = "UID102", MealTime = MealTime.SNACKS, Category = Category.DESSERTS, DishName = "Pongal" });
        menu.Add(new MenuItem() { UserId = "UID102", MealTime = MealTime.SNACKS, Category = Category.BEVERAGES, DishName = "Filter Coffee" });
        menu.Add(new MenuItem() { UserId = "UID103", MealTime = MealTime.SNACKS, Category = Category.STARTERS, DishName = "Vada" });
        menu.Add(new MenuItem() { UserId = "UID103", MealTime = MealTime.SNACKS, Category = Category.MAINCOURSE, DishName = "Uttapam" });
        menu.Add(new MenuItem() { UserId = "UID103", MealTime = MealTime.SNACKS, Category = Category.DESSERTS, DishName = "Halwa" });
        menu.Add(new MenuItem() { UserId = "UID103", MealTime = MealTime.SNACKS, Category = Category.BEVERAGES, DishName = "Tea" });
    }

    public static void DisplayMainMenu()
    {
        int mainMenuChoice = 0;
        do
        {
            displayTitle();
            Console.WriteLine($"+------------------------------------------------------------------------------------+");
            Console.WriteLine($"| MAIN MENU                                                                          |");
            Console.WriteLine($"+------------------------------------------------------------------------------------+");
            Console.WriteLine($"| 1. Add Menu Item                                                                   |");
            Console.WriteLine($"| 2. Display menu Items                                                              |");
            Console.WriteLine($"| 3. Get Menu Item                                                                   |");
            Console.WriteLine($"| 4. Close Application                                                               |");
            Console.WriteLine($"+------------------------------------------------------------------------------------+\n");
            Console.WriteLine($"Choose an Option: ");

            bool temp = int.TryParse(Console.ReadLine(), out mainMenuChoice);
            while (!temp)
            {
                Console.WriteLine($"Invalid Input. Enter Again");
                temp = int.TryParse(Console.ReadLine(), out mainMenuChoice);
            }

            switch (mainMenuChoice)
            {
                case 1:
                    {
                        Console.WriteLine($"Calling Add Menu Item ...");
                        Console.WriteLine($"Press any key to Go to Add Menu Item page ...");
                        Console.ReadKey();
                        displayTitle();
                        addMenuItem();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine($"Calling Display Menu Items Page ...");
                        Console.WriteLine($"Press any key to Display Menu Items ...");
                        Console.ReadKey();
                        displayTitle();
                        displayMenuItems();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine($"Calling Get Menu Item Page ...");
                        Console.WriteLine($"Press any key to enter Get Item page ...");
                        Console.ReadKey();
                        displayTitle();
                        GetMenuItem();

                        break;
                    }
                case 4:
                    {
                        Console.WriteLine($"Closing the Application ...");
                        Console.WriteLine($"Press any key to Exit the Application ...");
                        Console.ReadKey();
                        break;
                    }
                default:
                    {
                        Console.WriteLine($"Invalid Input");
                        break;
                    }
            }
        } while (mainMenuChoice != 4);

    }

    private static void AddMenuItem()
    {
        Console.WriteLine($"+------------------------------------------------------------------------------------+");
        Console.WriteLine($"| MENU ITEM DATA                                                                     |");
        Console.WriteLine($"+------------------------------------------------------------------------------------+\n");
        Console.WriteLine($"Type BACK to return ...");
        Console.Write($"Enter UserID: ");
        string userId = Console.ReadLine();
        if (IsReturn(userId))
        {
            return;
        }
        bool temp = !String.IsNullOrEmpty(userId);
        while (!temp)
        {
            Console.Write($"\nInvalid Input. Enter Again: ");
            userId = Console.ReadLine();
            if (IsReturn(userId))
            {
                return;
            }
            temp = !String.IsNullOrEmpty(userId);
        }

        Console.Write($"\nChoose the Meal Time (Breakfast, Lunch, Dinner, Snacks): ");
        string mealTimeInput = Console.ReadLine().ToUpper();
        if (IsReturn(mealTimeInput))
        {
            return;
        }
        temp = MealTime.TryParse(mealTimeInput, out MealTime mealtime) && Convert.ToInt32(mealTimeInput) <= 4 && Convert.ToInt32(mealTimeInput) >= 0;
        while (!temp)
        {
            Console.Write($"\nInvalid Input. Enter Again: ");
            mealTimeInput = Console.ReadLine().ToUpper();
            if (IsReturn(mealTimeInput))
            {
                return;
            }
            temp = MealTime.TryParse(mealTimeInput, out mealtime) && Convert.ToInt32(mealTimeInput) <= 4 && Convert.ToInt32(mealTimeInput) >= 0;
        }

        Console.Write($"\nChoose the Meal Time (Starters, MainCourse, Desserts, Beverages): ");
        string categoryInput = Console.ReadLine().ToUpper();
        if (IsReturn(categoryInput))
        {
            return;
        }
        temp = Category.TryParse(categoryInput, out Category category) && Convert.ToInt32(categoryInput) <= 4 && Convert.ToInt32(categoryInput) >= 0;
        while (!temp)
        {
            Console.Write($"\nInvalid Input. Enter Again: ");
            categoryInput = Console.ReadLine().ToUpper();
            if (IsReturn(categoryInput))
            {
                return;
            }
            temp = Category.TryParse(categoryInput, out category) && Convert.ToInt32(categoryInput) <= 4 && Convert.ToInt32(categoryInput) >= 0;
        }

        Console.Write($"\nEnter Dish Name: ");
        string dishName = Console.ReadLine();
        if (IsReturn(dishName))
        {
            return;
        }
        temp = !String.IsNullOrEmpty(dishName);
        while (!temp)
        {
            Console.Write($"\nInvalid Input. Enter Again: ");
            dishName = Console.ReadLine();
            if (IsReturn(dishName))
            {
                return;
            }
            temp = !String.IsNullOrEmpty(dishName);
        }
        if (ValidateMenuItem(userId, mealtime, category, dishName))
        {
            MenuItem item = new MenuItem() { UserId = userId, MealTime = mealtime, Category = category, DishName = dishName };
            menu.Add(item);
            s_cache.AddToCache(item.MenuId, item);

            Console.WriteLine($"+------------------------------------------------------------------------------------+");
            Console.WriteLine($"| Your Item is added successfully.                                                   |");
            Console.WriteLine($"+------------------------------------------------------------------------------------+\n");
        }


        Console.WriteLine($"Press any key to Go to Main Menu ...");
        Console.ReadKey();
    }

    private static bool IsReturn(string input)
    {
        if (input.ToUpper().Equals("BACK"))
        {
            return true;
        }
        return false;
    }

    private static bool ValidateMenuItem(string userId, MealTime mealTime, Category category, string dishName)
    {
        bool isAdd = true;
        if (string.IsNullOrEmpty(userId))
        {
            Console.WriteLine("User ID cannot be empty");
            isAdd = false;
        }
        if (MealTime.Default == mealTime)
        {
            Console.WriteLine("Meal Time cannot be empty");
            isAdd = false;
        }
        if (Category.Default == category)
        {
            Console.WriteLine("Category cannot be empty");
            isAdd = false;
        }
        if (string.IsNullOrEmpty(dishName))
        {
            Console.WriteLine("Dish Name cannot be empty");
            isAdd = false;
        }
        return isAdd;
    }

    public static void DisplayTitle()
    {
        Console.Clear();
        Console.WriteLine($"+------------------------------------------------------------------------------------+");
        Console.WriteLine($"|                          MENU ITEMS MANAGEMENT APPLICATION                         |");
        Console.WriteLine($"+------------------------------------------------------------------------------------+\n");
    }

    static void DisplayMenuItems()
    {
        Console.WriteLine($"+------------------------------------------------------------------------------------+");
        Console.WriteLine($"| MENU ITEMS LIST                                                                    |");
        Console.WriteLine($"+------------------------------------------------------------------------------------+");
        Console.WriteLine($"| MENU ID        | USER ID        | MEAL TIME      | CATEGORY       | DISH NAME      |");
        Console.WriteLine($"+------------------------------------------------------------------------------------+");
        bool flag = false;
        foreach (MenuItem menuItem in menu)
        {
            flag = true;
            Console.WriteLine("| {0,-14} | {1,-14} | {2,-14} | {3,-14} | {4,-14} |", menuItem.MenuId.ToUpper(), menuItem.UserId.ToUpper(), menuItem.MealTime, menuItem.Category, menuItem.DishName.ToUpper());
            Console.WriteLine($"+------------------------------------------------------------------------------------+");
        }
        Console.WriteLine($"");

        if (!flag)
        {
            Console.WriteLine($"| No Items Found                                                                      |");
            Console.WriteLine($"+------------------------------------------------------------------------------------+");
        }
        Console.WriteLine($"Press any key to Go to Main Menu ...");
        Console.ReadKey();
    }

    public static List<MenuItem> GetSearchMenuItems(string searchBy, string searchTerm)
    {
        List<MenuItem> searchedItems = new List<MenuItem>();

        if (menu == null)
        {
            Console.WriteLine("Menu is null. Unable to search.");
            return searchedItems;
        }

        var property = typeof(MenuItem).GetProperty(searchBy);
        if (property == null)
        {
            Console.WriteLine($"Property '{searchBy}' does not exist in MenuItem class.");
            return searchedItems;
        }

        try
        {
            searchedItems = menu.Where(x => property.GetValue(x)?.ToString().ToUpper().Contains(searchTerm.ToUpper()) ?? false).ToList();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        return searchedItems;
    }

    static void GetMenuItem()
    {
        Console.WriteLine($"Type BACK to return ...");
        Console.Write($"Enter the Menu Id to retrieve: ");
        string menuId = Console.ReadLine();
        if (IsReturn(menuId))
        {
            return;
        }
        bool temp = !String.IsNullOrEmpty(menuId);
        while (!temp)
        {
            Console.Write($"\nInvalid Input. Enter Again: ");
            menuId = Console.ReadLine();
            if (IsReturn(menuId))
            {
                return;
            }
            temp = !String.IsNullOrEmpty(menuId);
        }
        MenuItem result = s_cache.GetMenuItem(menuId);
        if (result != null)
        {
            Console.WriteLine($"+------------------------------------------------------------------------------------+");
            Console.WriteLine($"| MENU ID        | USER ID        | MEAL TIME      | CATEGORY       | DISH NAME      |");
            Console.WriteLine($"+------------------------------------------------------------------------------------+");
            Console.WriteLine("| {0,-14} | {1,-14} | {2,-14} | {3,-14} | {4,-14} |", result.MenuId.ToUpper(), result.UserId.ToUpper(), result.MealTime, result.Category, result.DishName.ToUpper());
            Console.WriteLine($"+------------------------------------------------------------------------------------+");
        }
        else
        {
            Console.WriteLine($"+------------------------------------------------------------------------------------+");
            Console.WriteLine($"| MENU ID        | USER ID        | MEAL TIME      | CATEGORY       | DISH NAME      |");
            Console.WriteLine($"+------------------------------------------------------------------------------------+");
            Console.WriteLine($"| No Result found                                                                    |");
            Console.WriteLine($"+------------------------------------------------------------------------------------+");
        }
        Console.WriteLine($"Press any key to go to main menu ...");
        Console.ReadKey();
    }

}
