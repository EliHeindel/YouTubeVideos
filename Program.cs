using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Video
            Video video1 = new Video("Understanding C#", "Eli", 300);
            Video video2 = new Video("Advanced C#", "Robert", 600);
            Video video3 = new Video("C# Tips and Tricks", "Heindel", 450);

            // Create instances of Comment and add to videos
            List<Comment> commentsForVideo1 = new List<Comment>
            {
                new Comment("Sean", "Great video!"),
                new Comment("Stafford", "Very informative."),
                new Comment("Donald", "Thanks for sharing.")
            };

            List<Comment> commentsForVideo2 = new List<Comment>
            {
                new Comment("Eli", "Excellent explanation!"),
                new Comment("Andrew", "I learned a lot."),
                new Comment("Byron", "Could you make a video on ASP.NET?")
            };

            List<Comment> commentsForVideo3 = new List<Comment>
            {
                new Comment("Aaron", "Very useful tips!"),
                new Comment("Matthew", "Loved the tricks!"),
                new Comment("Cooper", "Please make more videos like this.")
            };

            foreach (var comment in commentsForVideo1)
            {
                video1.AddComment(comment);
            }

            foreach (var comment in commentsForVideo2)
            {
                video2.AddComment(comment);
            }

            foreach (var comment in commentsForVideo3)
            {
                video3.AddComment(comment);
            }

            // Store videos in a list
            List<Video> videos = new List<Video> { video1, video2, video3 };

            // Iterate through the list and display information about each video
            foreach (var video in videos)
            {
                Console.WriteLine(video);
            }
        }
    }
}
