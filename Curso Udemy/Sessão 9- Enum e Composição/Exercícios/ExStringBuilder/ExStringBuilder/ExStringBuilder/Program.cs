using ExStringBuilder.Entities;
using System;

namespace ExStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice day.");
            Comment c2 = new Comment("Wow that's awesome!");
            Post p1 = new Post(DateTime.Parse("21/06/2020 13:05:15"), "Traveling to New Zeland", "I'm going to visit this wonderful country!", 55);

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the force be with you");
            Post p2 = new Post(DateTime.Parse("03/07/2020 22:08:47"), "Good night guys", "See you tomorrow", 23);

            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
