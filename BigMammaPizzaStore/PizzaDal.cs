using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BigMammaPizzaStore
{
    public class PizzaDal

    {
        #region Instance fields
        private List<Pizza> _pizzaList = new List<Pizza> { }; //Atribut, hvor _pizzaList er Liste af objekter af datatype List"Pizza" 
       
        #endregion

        #region Constructor
        
        #endregion

        #region Properties
        public List<Pizza> Pizzas
        {
            get { return _pizzaList; }
        }


        #endregion

        #region Methods
        public void CreatePizza(Pizza pizza)
        {
                foreach (Pizza p in _pizzaList)
            {
                if (p.Id == pizza.Id) 
                {
                    Exception ex = new Exception("Id findes allerede");
                    throw ex;
                }
            
            }
                Pizzas.Add(pizza);
        }
        public Pizza Read(int id)
        {
            
            foreach (Pizza pizza in _pizzaList)
            {
                if (pizza.Id == id)
                { 
                    Console.WriteLine(pizza);
                }
            }
            return null;
        }
        public void Update(int newId, string name, string toppings, double price)
        {
            int id = int.Parse(Console.ReadLine());
            foreach (Pizza pizza in _pizzaList)
 

                if (pizza.Id == id)
                {
                    pizza.Id = newId;
                    pizza.Name = name;
                    pizza.Toppings = toppings;
                    pizza.Price = price;
                }
        }
        public void Delete(int id)
        {
            foreach (Pizza pizza in _pizzaList)

                if (pizza.Id == id)
                {
                    _pizzaList.Remove(pizza); 
                    break;

                }
        }
        public Pizza PrintPizzaList()
        { 
            foreach (Pizza pizza in _pizzaList)
            {
                Console.WriteLine(pizza);
            }
            return null;
        }

        public Pizza SearchPizza(string crit)
        {
            foreach (Pizza pizza in _pizzaList)
            {
                if (pizza.Name.StartsWith(crit))
                {
                    Console.WriteLine(pizza);
                }
            }
            return null;
        }
        #endregion



    }
}