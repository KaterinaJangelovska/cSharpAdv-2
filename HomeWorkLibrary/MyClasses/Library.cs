using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class Library
    {
        public List<IBook> Books = new List<IBook>();

        public void ShowBooks(string input)
        {
            List<IBook> Knigi = new List<IBook>();

            if(input == "Book")
            {
                Knigi = Books;
            }
            else
            {
                Knigi = Books.Where(b => b.GetTypeOfBook() == input).ToList();
            }


            foreach (var book in Knigi)
            {
                Console.WriteLine(book);  // ova e od ToString metodata
            }
        }
    }
}
