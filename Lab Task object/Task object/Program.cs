using System;

namespace Task_object
{
    class Program
    {
        static void Main(string[] args)
        {
            //Human human = new Human("Sherlock", "Holmes", 30, "Amerian")
            //{

            //};
            //human.ShowFullName();
            //human.ShowInfo();

            //Author author = new Author("Sherlock", "Holmes", 30, "Amerian")
            //{
            //    About = "salam"
            //};
            //author.ShowInfo();
            //author.ShowFullName();
            Book [] books = new Book[2];

            Book newbook =new Book ( "Torpagin Bereketi", "Roman",10);
            Book newbook2 = new Book("Acliq", "Roman", 23);

            Author author = new Author("Knut", "Hamsun",30,"Norwegian");

            author.Books = books;
               
        }
    }
}
