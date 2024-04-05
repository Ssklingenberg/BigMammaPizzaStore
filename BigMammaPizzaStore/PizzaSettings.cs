using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BigMammaPizzaStore
{
    internal class PizzaSettings
    {

        ProductCatalog pizzaMenu= new ProductCatalog();
        public PizzaSettings() 
        {
            CloseMenuPizza = false;
        }
        #region Properties
        public bool CloseMenuPizza { get; set; }

        #endregion

        public int PizzaSetting()

        {
            {
                List<string> menu = new List<string>
                  {
                    "1. Add new to pizza to the menu",
                    "2. Delete pizza",
                    "3. Update pizza",
                    "4. Search pizza",
                    "5. Display pizza menu",
                    "6. Return to main menu",
                  };

                {
                    Console.WriteLine();
                    Console.WriteLine("PIZZA SETTINGS");
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine("Please choose an option by entering a number from the menu.");
                    Console.WriteLine("------------------------------------------------------------");
                    Console.WriteLine();
                    foreach (string menuItem in menu)
                    {
                        Console.WriteLine(menuItem);
                    }
                }
                
                

                int selectMenu = int.Parse(Console.ReadLine());

                switch (selectMenu)
                {
                    case 1:
                         Console.WriteLine("You selected:   " + menu[1 - 1]);
                         Console.Clear();
                         Console.WriteLine("Insert pizza id:");
                         int id = int.Parse(Console.ReadLine());
                         Console.WriteLine("Insert pizza name:");
                         string name = Console.ReadLine();
                         Console.WriteLine("Insert pizza toppings:");
                         string toppings = Console.ReadLine();
                         Console.WriteLine("Insert price:");
                         double price = double.Parse(Console.ReadLine());
                         Console.Clear();
                        try
                        {
                            pizzaMenu.Create(id, name, toppings, price);
                            Console.WriteLine("Pizza added to the menu");
                        }
                        catch (Exception ex)
                        { 
                            Console.WriteLine(ex.Message);
                        }
                        break;
                       

                    case 2:
                        Console.WriteLine("You selected:   " + menu[2 - 1]);
                        Console.Clear();
                        Console.WriteLine("Insert a pizza id you want to delete");
                        
                        id = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine($"Are you sure you want to delete {id}");
                        Console.WriteLine("Yes, press 1");
                        Console.WriteLine("No, press 2");

                        int choose = int.Parse(Console.ReadLine());

                        int yes = 1;
                        int no = 2;
                        
                        if (choose == 1)
                        {
                            Console.Clear();
                            pizzaMenu.Delete(id);
                            Console.WriteLine($"Pizza {id} is now deleted");
                        }
                        else
                        {
                            Console.Clear();
                            Console.Write("Pizza is not deleted");
                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        Console.WriteLine("You selected:   " + menu[3 - 1]);
                        Console.Clear();
                        Console.WriteLine("Insert pizza id you want update");
                        id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insert a NEW pizza id");
                        id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Insert a NEW pizza name");
                        name = (Console.ReadLine());
                        Console.WriteLine("Insert NEW Toppings");
                        string topping = (Console.ReadLine());
                        Console.WriteLine("Insert a NEW pizza Price");
                        price = double.Parse(Console.ReadLine());
                        pizzaMenu.Update(id, name, topping, price);
                        break;

                    case 4:
                        Console.WriteLine("You selected:   " + menu[4 - 1]);
                        Console.Clear();
                        Console.WriteLine("Insert pizza id you want find");
                        string crit = (Console.ReadLine());
                        try
                        {
                            pizzaMenu.FindPizza(crit); 
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine($"{ex.Message} - i UI");
                        }
                        break;

                    case 5:
                        Console.WriteLine("You selected:   " + menu[5 - 1]);
                        Console.Clear();
                        pizzaMenu.DisplayPizzaMenu();
                        break;

                    case 6:
                        Console.Clear();
                        CloseMenuPizza = true;
                        break;
                }
                return selectMenu;
            }
        }

        public override string ToString()
        {
            return $"{PizzaSetting}";
        }
        

    }

}