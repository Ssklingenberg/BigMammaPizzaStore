using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BigMammaPizzaStore
{
    public class Pizza
    {
        #region Instance fields
        private int _id;
        private string _name;
        private string _toppings;
        private double _price;
       
        #endregion

        #region Constructor
        public Pizza(int id, string name, string toppings, double price)
        {
            _id = id;
            _name = name;
            _toppings = toppings;
            _price = price;   
        }
        #endregion
        

        #region Properties
        public int Id 
        {  
            get { return _id; }
            set { _id = value; }
        }
        public string Name 
        { 
            get { return _name; }
            set { _name = value; }
        }
        public string Toppings 
        {  
            get { return _toppings; } 
            set { _toppings = value; }
        }
        public double Price 
        { 
            get { return _price; }
            set { _price = value; }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"Number:{Id}, PizzaName: {Name}, Toppings: {Toppings}, Price: {Price}";
        }

        #endregion
    }
}
