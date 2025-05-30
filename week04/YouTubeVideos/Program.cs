using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video("Learn C# in 10 Minutes", "CodeAcademy", 600);
        Video video2 = new Video("Best Laptop 2025", "TechWorld", 420);
        Video video3 = new Video("Top 10 Travel Destinations", "Wanderlust", 520);
        Video video4 = new Video("How to Bake a Cake", "SweetBites", 300);

        // Add comments to video1
        video1.AddComment(new Comment("Alice", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Bob", "Great overview."));
        video1.AddComment(new Comment("Charlie", "You explained it so well!"));

        // Add comments to video2
        video2.AddComment(new Comment("Dave", "I'm buying this laptop!"));
        video2.AddComment(new Comment("Eve", "Could you compare with Mac?"));
        video2.AddComment(new Comment("Frank", "Awesome review."));

        // Add comments to video3
        video3.AddComment(new Comment("Grace", "I want to go to Bali now!"));
        video3.AddComment(new Comment("Heidi", "Italy is my favorite."));
        video3.AddComment(new Comment("Ivan", "Adding these to my bucket list."));

        // Add comments to video4
        video4.AddComment(new Comment("Judy", "Delicious! I tried it today."));
        video4.AddComment(new Comment("Karl", "Nice and simple steps."));
        video4.AddComment(new Comment("Liam", "Thanks for this recipe!"));

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3, video4 };

        // Display all video details
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.CommenterName}: {comment.Text}");
            }
            Console.WriteLine(new string('-', 40));
        }
    }
}