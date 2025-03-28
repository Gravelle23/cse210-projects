using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Comment comment1 = new Comment("Alice", "Great video! Really enjoyed it.");
        Comment comment2 = new Comment("Bob", "Nice explanation, thanks for sharing.");
        Comment comment3 = new Comment("Charlie", "This was helpful, but a bit too long.");
        Comment comment4 = new Comment("Dave", "Loved the visuals!");

        Video video1 = new Video("Introduction to Programming", "John Doe", 300);
        Video video2 = new Video("C# Advanced Topics", "Jane Smith", 600);
        Video video3 = new Video("Data Structures Explained", "Sam Green", 450);

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video2.AddComment(comment3);
        video2.AddComment(comment4);
        video3.AddComment(comment1);
        video3.AddComment(comment4);

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
