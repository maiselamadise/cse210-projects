using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video v1 = new Video("How to Cook Pasta", "Chef Mario", 480);
        v1.AddComment(new Comment("Anna", "This looks delicious!"));
        v1.AddComment(new Comment("John", "I tried it and it works great."));
        v1.AddComment(new Comment("Lisa", "Thanks for the clear instructions!"));
        videos.Add(v1);

        // Video 2
        Video v2 = new Video("Learning C# Classes", "TechTeacher", 620);
        v2.AddComment(new Comment("Mark", "Very helpful explanation!"));
        v2.AddComment(new Comment("Sarah", "Now abstraction makes sense."));
        v2.AddComment(new Comment("David", "Thank you for this lesson."));
        videos.Add(v2);

        // Video 3
        Video v3 = new Video("Funny Cat Compilation", "CatWorld", 300);
        v3.AddComment(new Comment("Emily", "I laughed so hard!"));
        v3.AddComment(new Comment("Alex", "Cats are the best."));
        v3.AddComment(new Comment("Noah", "I watched this 3 times!"));
        videos.Add(v3);

        // Display videos
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}
