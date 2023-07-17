using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();
        
        Video video01 = new Video("C sharp intro","Michael Jackson","5:23");
        videos.Add(video01);
        video01.AddComment("Pedro","Fantastic");
        video01.AddComment("Peter","Terrible");
        video01.AddComment("Robert","I love it!");

        Video video02 = new Video("C Sharp Abstraction","Arnold Shwazeneger","10:31");
        videos.Add(video02);
        video02.AddComment("Anna","I recommend it");
        video02.AddComment("Leia","You need speak more slow");
        video02.AddComment("Luke","Great explanation");
        video02.AddComment("Helen","You win a follower");

        Video video03 = new Video("C Sharp Polymorphism","Lionel Messi","10:31");
        videos.Add(video03);
        video03.AddComment("Matt","You need more practice.");
        video03.AddComment("Stephen","Wow! icredible see you trying it.");
        video03.AddComment("Michael","for the best world soccer player.");

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title:\"{video.GetTitle()}\",Author: {video.GetAuthor()}, Length: {video.GetLenght()}, Comments: {video.GetCommentsNumber()}");
            video.GetComments();
            Console.WriteLine();
        }
    }
}