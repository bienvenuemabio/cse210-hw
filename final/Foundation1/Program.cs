using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        Video video1 = new Video("fundamentals","Microsoft Developer",6000);
        Video video2= new Video("Formation Deep learning","Machine Learnia",4000);
        Video video3= new Video("Mix","Microsoft Developer",8000);
        Video video4= new Video("Best of efy","Joshua Poter",12000);

        video1.DisplayVideo();

        Comment comment1 = new Comment("Peter","This is the nice program to watch");

        comment1.DisplayComment();

        List<Video> _videos = new List<Video>();
        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);
        _videos.Add(video4);

        foreach (Video video in _videos)
        {
            video.DisplayVideo();

        }

        
    }
}