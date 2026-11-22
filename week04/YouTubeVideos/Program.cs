
using System;
using System.Collections.Generic;

namespace YouTubeVideos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the first video
            Video video1 = new Video(
                "How to Learn Python",
                "Programming with Alex",
                600
            );

            video1.AddComment(new Comment("John", "This tutorial was very helpful!"));
            video1.AddComment(new Comment("Mary", "I finally understand Python."));
            video1.AddComment(new Comment("David", "Great explanation for beginners."));

            // Create the second video
            Video video2 = new Video(
                "Introduction to Web Development",
                "Tech Academy",
                900
            );

            video2.AddComment(new Comment("Peter", "I enjoyed this lesson."));
            video2.AddComment(new Comment("Grace", "Very clear and informative."));
            video2.AddComment(new Comment("James", "Looking forward to more videos."));

            // Create the third video
            Video video3 = new Video(
                "Understanding Data Analysis",
                "Data Science Hub",
                750
            );

            video3.AddComment(new Comment("Sarah", "Excellent introduction to data analysis."));
            video3.AddComment(new Comment("Michael", "This made the topic easier to understand."));
            video3.AddComment(new Comment("Daniel", "Thank you for sharing this."));

            // Create the fourth video
            Video video4 = new Video(
                "Introduction to Cloud Computing",
                "Cloud Learning",
                840
            );

            video4.AddComment(new Comment("Esther", "Very useful information."));
            video4.AddComment(new Comment("Samuel", "I learned something new today."));
            video4.AddComment(new Comment("Rebecca", "Please make more tutorials like this."));

            // Store all videos in a list
            List<Video> videos = new List<Video>
            {
                video1,
                video2,
                video3,
                video4
            };

            // Display information about each video
            foreach (Video video in videos)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"Title: {video.GetTitle()}");
                Console.WriteLine($"Author: {video.GetAuthor()}");
                Console.WriteLine($"Length: {video.GetLength()} seconds");
                Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

                Console.WriteLine("Comments:");

                foreach (Comment comment in video.GetComments())
                {
                    Console.WriteLine(
                        $"{comment.GetCommenterName()}: {comment.GetText()}"
                    );
                }

                Console.WriteLine();
            }
        }
    }
}
