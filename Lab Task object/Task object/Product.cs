using System;
using System.Collections.Generic;
using System.Text;

namespace Task_object
{
    class Product
    {
        public string Name;
        public double Price;
        public int Count;

        public double Income;

        public Product(string name, double price, int count)
        {
            this.Name = name;
            this.Price = price;
            this.Count = count;
        }

        public void Sell()
        {
            if (Count>0)
            {
                Count--;
                Income += Price;
            }
            else
            {
                Console.WriteLine("Get su al");
            }
        }
        public void Showinfo()
        {
            Console.WriteLine($"Name:{Name}\nPrice:{Price}\nCount:{Count}\n Income:{Count}");
        }
            

  
    }
}
