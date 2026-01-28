/*
YouTube Video Program

Brandon Arroyo
1/28/2025
*/

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Learn C#", "Codecademy", 600);
        video1.AddComment(new Comment("Jordan", "Well Done!"));
        video1.AddComment(new Comment("Mark", "Very simple to understand."));
        video1.AddComment(new Comment("Tom", "Could be more specific on OOP."));
        videos.Add(video1);

        Video video2 = new Video("Lionel Messi Skills", "RandomGuy123", 720);
        video2.AddComment(new Comment("Neymar", "Incredible!"));
        video2.AddComment(new Comment("Brandon", "Still gives me goosebumps."));
        video2.AddComment(new Comment("Lamine", "My idol."));
        videos.Add(video2);

        Video video3 = new Video("Learn to play guitar", "Music Mark", 1800);
        video3.AddComment(new Comment("Jacob", "Well Done!"));
        video3.AddComment(new Comment("Leondro", "Very simple to understand."));
        video3.AddComment(new Comment("Mikel", "Love how easy it is to understand the chords."));
        videos.Add(video3);

        Video video4 = new Video("Jack Johnson - Shot Reverse Shot (Official Video)", "jackjohnsonmusic", 190);
        video4.AddComment(new Comment("Guellermo", "Perfect balance of calming and peppy!"));
        video4.AddComment(new Comment("Eric", "Love the symbolism."));
        video4.AddComment(new Comment("Aiden", "Killer view of the ocean!"));
        videos.Add(video4);


        foreach(Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()} comments");
            Console.WriteLine("Comments: ");

            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"    {comment._fullName}: {comment._text}");
            }
            Console.WriteLine();
        }
    }
}