using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaPizzaStore
{
    public class MainSettings
    {
        public MainSettings()
        {
            CloseMenu = false;
        }
        public bool CloseMenu { get; set; }
            public int SettingsMainMenu()

        {
            Console.Clear();
            List<string> menu = new List<string>
                  {
                    "1. Product Settings",
                    "2. Customer Settings",
                    "3. Order Settings",
                    "4. Close menu",
                  };

            {
                Console.WriteLine("SETTINGS");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine("Please choose an option by entering a number from the menu.");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine();
                foreach (string menuItem in menu)
                {
                    Console.WriteLine(menuItem);
                    Console.WriteLine();
                }
            }

            int selectMenu = int.Parse(Console.ReadLine());

            switch (selectMenu)
            {
                case 1:
                    Console.WriteLine("You selected:   " + menu[1 - 1]);
                    Console.Clear();
                    PizzaSettings ui = new PizzaSettings();
                    while (!ui.CloseMenuPizza) 
                    { 
                    ui.PizzaSetting();
                    }
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("To be implemented...");
                    Console.WriteLine("--------------------------------------------");
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("To be implemented...");
                    Console.WriteLine("--------------------------------------------");
                    break;
                case 4:
                    Console.Clear();
                    CloseMenu = true;
                    break;
            }
            return selectMenu;
        }

    }
}
