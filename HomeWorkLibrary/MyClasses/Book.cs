using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class Book : IBook
    {
    
        public int ID { get; set ; }
        public string Title { get; set; }
        public TypeOfEdition TypeOfEdition { get; set; }
        public int NumberOfPages { get; set; }
        public long ISBN { get; set; }

        public Book() { }

        public Book(string title, TypeOfEdition typeOfEdition, int numberOfPages)
        {
            Title = title;
            TypeOfEdition = typeOfEdition;
            NumberOfPages = numberOfPages;
            ISBN = GenerateISBN();
            ID = GenerateID();
        }

        public int GenerateID()
        {
            var rnd = new Random();
            return rnd.Next(10, 50);   
            //new Random().Next(10, 50);
            //throw new NotImplementedException();
        }

        public long GenerateISBN()
        {
            var num1 = new Random().Next(1000000, 9999999);
            var num2 = new Random().Next(100000, 999999);
            return Convert.ToInt64(num1.ToString() + num2.ToString());
            //throw new NotImplementedException();
        }

        public virtual string GetTypeOfBook()
        {
            return "Book";
        }
    }
}
