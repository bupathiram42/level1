using System.Collections.Generic;

namespace Application
{
    public delegate void EventManager();
    public delegate void GroupORFilterEventManager(List<MenuItem> menu, string groupBy);
    public delegate void SearchEventManager(string searchBy, string searchTerm);
    public static partial class Operations
    {
        public static event EventManager starter;
        public static event EventManager displayTitle, addMenuItem, displayMenuItems, retrieveItem, searchItem;
        public static event GroupORFilterEventManager displayGroupedMenuItems, filterMenuItems;
        public static event SearchEventManager searchMenuItems;

        public static void Starter()
        {
            Subscribe();
            starter();
        }
    
        public static void Subscribe()
        {
            starter += new EventManager(Files.CreateFile);
            // starter += new EventManager(Operations.LoadDefaultData);
            starter += new EventManager(Files.ReadFiles);
            starter += new EventManager(Operations.DisplayMainMenu);
            starter += new EventManager(Files.WriteFile);

            displayTitle = new EventManager(DisplayTitle);
            addMenuItem = new EventManager(AddMenuItem);
            displayMenuItems = new EventManager(DisplayMenuItems);
        }
    
    }
}