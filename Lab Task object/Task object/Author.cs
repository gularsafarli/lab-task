using System;
using System.Collections.Generic;
using System.Text;

namespace Task_object
{
    class Author : Human
    {
        public string About;

        public Book [] Books;

        public Author(string name, string surname, int age, string nationality) :base( name, surname, age, nationality)
        {
            
        }
         
        public override void ShowFullName()
        {
            Console.WriteLine($"Name:{Name}\n Surname:{Surname}");
        }
         public override void ShowInfo()
         {
            Console.WriteLine($"Name:{Name}\n Surname:{Surname}\n Age:{Age}\n Nationality:{Nationality}\nAbout:{About}");
         }
    }
}
