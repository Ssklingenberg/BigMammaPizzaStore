using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BigMammaPizzaStore
{
    public class ProductCatalog
                
    {
        #region Instance fields
        PizzaDal pizzaDal = new PizzaDal();

        #endregion
     
        
        #region Methods
        public void Create(int id, string name, string toppings, double price)
        {
            
            Pizza p = new Pizza(id, name, toppings, price);
            pizzaDal.CreatePizza(p);
        }

        public Pizza Get(int id)
        {
            return pizzaDal.Read(id);
        }

        public void Update(int newId, string name, string toppings, double price)
        {
            pizzaDal.Update(newId, name, toppings, price);
        }

        public void Delete(int id)
        {
            pizzaDal.Delete(id);
        }

        public Pizza DisplayPizzaMenu() // Printmenu referere til objektet Pizza
        {
            return pizzaDal.PrintPizzaList();
        }
        
        public Pizza FindPizza(string crit)
        {
            return pizzaDal.SearchPizza(crit);
        }
        #endregion
       


    }
}