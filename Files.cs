using System;
using System.IO;

namespace Application
{
    public static class Files
    {
        /*
            The Function,
            1. Creates a folder if not exists.
            2. Create files if not exists.
        */
        public static void CreateFile()
        {
            if (!Directory.Exists("./Resources"))
            {
                Console.WriteLine($"Directory Does not exist.So Creating a Folder");
                Directory.CreateDirectory("./Resources");
            }
            else
            {
                Console.WriteLine($"Directory exists");
            }

            if (!File.Exists("./Resources/MenuItemDetails.csv"))
            {
                Console.WriteLine($"File Does not exist.So Creating a File");
                File.Create("./Resources/MenuItemDetails.csv").Close();
            }
            else
            {
                Console.WriteLine($"File exists");
            }
        }

        /*
            The Function,
            1. Writes a file with data in the list after processing the application or at the time of closing the application.
        */
        public static void WriteFile()
        {
            // To write Menu Details List to file
            string[] menuDetails = new string[Operations.menu.Count];
            for (int i = 0; i < Operations.menu.Count; i++)
            {
                menuDetails[i] = Operations.menu[i].MenuId + "," + Operations.menu[i].UserId + "," + Operations.menu[i].MealTime + "," + Operations.menu[i].Category + "," + Operations.menu[i].DishName;
            }
            File.WriteAllLines("./Resources/MenuItemDetails.csv", menuDetails);
        }

        /*
            The Function,
            1. Reads the lines in the files.
            2. Store it to string[].
            3. Create new Objects for each line(user) using new constructor.
            4. New Constructor => Add the data passed to the newly created object.
            5. Add the object to the list.
        */
        public static void ReadFiles()
        {
            string[] menuItemsDetailsList = File.ReadAllLines("./Resources/MenuItemDetails.csv");
            foreach (string menuItem in menuItemsDetailsList)
            {
                Operations.menu.Add(new MenuItem(menuItem));
            }
        }


    }
}