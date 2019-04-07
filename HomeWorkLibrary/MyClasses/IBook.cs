using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public interface IBook
    {
        int ID { get; set; }
        string Title { get; set; }
        TypeOfEdition TypeOfEdition { get; set; }
        int NumberOfPages { get; set; }
        long  ISBN { get; set; }

        long GenerateISBN();
        string GetTypeOfBook();
        int GenerateID();
    }

    public enum TypeOfEdition
    {
        Hardcover,
        Paperback,
        EBook,
        Audiobook
    }
}
