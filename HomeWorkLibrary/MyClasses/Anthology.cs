using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class Anthology : Book, IBook
    {
        public string Editor { get; set; }
        public string Theme { get; set; }
        public List<Story> Stories { get; set; } = new List<Story>();

        public Anthology(string editor, string title, TypeOfEdition typeOfEdition, int numberOfPages) : base(title, typeOfEdition, numberOfPages)
        {
            Editor = editor;
          //  Theme = theme;
        }
        public override string GetTypeOfBook()
        {
            return "Anthology";
        }

        public override string ToString()
        {
            return $"{Title}, {Editor}, {Stories.Count}";
        }
    }
}
