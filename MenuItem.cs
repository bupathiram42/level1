using System;
namespace Application
{
    public enum MealTime { Default, BREAKFAST, LUNCH, DINNER, SNACKS }
    public enum Category { Default, STARTERS, MAINCOURSE, DESSERTS, BEVERAGES }
    public class MenuItem
    {
        private static int s_menuID = 1000;
        public string MenuId { get; }
        public string UserId { get; set; }
        public MealTime MealTime { get; set; }
        public Category Category { get; set; }
        public string DishName { get; set; }
        public MenuItem()
        {
            s_menuID++;
            MenuId = "" + s_menuID;
        }

        public MenuItem(string data)
        {
            string[] values = data.Split(',');
            s_menuID = int.Parse(values[0].Remove(0, 2));
            MenuId = values[0];
            UserId = values[1];
            MealTime = Enum.Parse<MealTime>(values[2], true);
            Category = Enum.Parse<Category>(values[3], true);
            DishName = values[4];
        }

    }
}