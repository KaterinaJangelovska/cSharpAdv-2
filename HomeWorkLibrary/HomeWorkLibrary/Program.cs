using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClasses;

namespace HomeWorkLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = InitializeLibrary();

            while(true)
            {
                Console.WriteLine("1 - Show all books, 2- Novels, 3- Story collection, 4 - Anthology");
                int input = Convert.ToInt32(Console.ReadLine());
                if( input == 1)
                {
                    library.ShowBooks("Book");
                }
                else if( input == 2)
                {
                    library.ShowBooks("Novels");
                }
                else if (input == 3)
                {
                    library.ShowBooks("Story collections");
                }
                else if (input == 4)
                {
                    library.ShowBooks("Anthology");
                }
                else
                {
                    Console.WriteLine("Wrong input");
                }

            }

        }

        public static Library InitializeLibrary()
        {
            var story1 = new Story("Story1", StoryType.Novella, true, "Petko");
            var story2 = new Story("Story2", StoryType.ShortStory, false, "Stanko");
            var story3 = new Story("Story3", StoryType.Novellette, true, "Cvetko");
            var story4 = new Story("Story4", StoryType.ShortStory, true, "Petko");
            var story5 = new Story("Story5", StoryType.Novella, false, "Author1");
            var story6 = new Story("Story6", StoryType.Novellette, true, "Petko");
            var story7 = new Story("Story7", StoryType.Novella, false, "Author1");

            var novel1 = new Novel("AuthorN", "Novel1", TypeOfEdition.EBook, 400);
            var novel2 = new Novel("AuthorN2", "Novel2", TypeOfEdition.Paperback, 270) { Series = "Novel", SeriesNumber = 2 };

            var storyCollection1 = new StoryCollection("Petko", "Zbirka1", TypeOfEdition.Hardcover, 832);
            var storyCollection2 = new StoryCollection("Author1", "Zbirka2", TypeOfEdition.EBook, 327);

            storyCollection1.Stories.Add(story1);
            storyCollection1.Stories.Add(story4);
            storyCollection1.Stories.Add(story6);

            storyCollection2.Stories.Add(story5);
            storyCollection2.Stories.Add(story7);

            var anthology = new Anthology("Editorce", "Anthology", TypeOfEdition.Audiobook, 432);
            var anthology2 = new Anthology("Editor2", "Anthology2", TypeOfEdition.EBook, 385);

            anthology.Stories.Add(story3);
            anthology.Stories.Add(story1);
            anthology2.Stories.Add(story2);
            anthology2.Stories.Add(story1);
            anthology2.Stories.Add(story6);
            Library library = new Library();
            library.Books = new List<IBook> { novel1, novel2, storyCollection1, storyCollection2, anthology, anthology2 };
            return library;
 

            //throw new NotImplementedException();
        }
    }
}
