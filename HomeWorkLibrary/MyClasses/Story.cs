using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClasses
{
    public class Story
    {
        public Story()
        {
        }

        public Story(string title, StoryType storyType, bool isOriginal, string author)
        {
            Title = title;
            StoryType = storyType;
            IsOriginal = isOriginal;
            Author = author;
        }

        public string Title { get; set; }
        public StoryType StoryType { get; set; }
        public bool IsOriginal { get; set; }
        public string Author { get; set; }
    }

    public enum StoryType
    {
        Novellette,
        Novella,
        ShortStory
    }
}
