using System;
using System.Collections.Generic;
using System.Text;

namespace Task_object
{
    class Book
    {
        public string Name;
        public string Category;
       
        public int Price;

        public Book(string name,string category,int price)
        {
            this.Name = name;
            this.Category = category;
          
            this.Price = price;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name:{Name}Category:{Category} Price:{Price}");

        }
    }
}
