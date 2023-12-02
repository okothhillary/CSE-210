using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Video and Comments tracker programme");

        Video myVideo = new Video("Introduction to C#", "Brother Paul", 300);
        Comment comment1 = new Comment("Alice", "Great video!");
        Comment comment2 = new Comment("Cheshire Cat", "I learned a lot.");

        myVideo.AddComment(comment1);
        myVideo.AddComment(comment2);

        myVideo.DisplayInfo();



        
    }
}