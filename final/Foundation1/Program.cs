using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        Video video1 = new Video("fundamentals","Microsoft Developer",6000);
        Comment comment1 = new Comment("Peter","This is the nice program to watch");
        Comment comment2 = new Comment("Malan","I can learn a lot of things");
        Comment comment3 = new Comment("john","wohou it is cool");
        video1.StoreComment(comment1);
        video1.StoreComment(comment2);
        video1.StoreComment(comment3);
        Console.WriteLine();
        

        Video video2= new Video("Formation Deep learning","Machine Learnia",4000);
        Comment commen1= new Comment("Ronald","ohh cool");
        Comment commen2= new Comment("Rose","Thank you for displaying this great leaning");
        Comment commen3= new Comment("Cloe","That is what i am looking for");
        video2.StoreComment(commen1);
        video2.StoreComment(commen2);
        video2.StoreComment(commen3);
        Console.WriteLine();

        Video video3= new Video("Mix","Microsoft Developer",8000);
        Comment comm1= new Comment("Brice","That is great");
        Comment comm2= new Comment("grace","Thank you for displaying this great");
        Comment comm3= new Comment("jacque","oh i see");
        video3.StoreComment(comm1);
        video3.StoreComment(comm2);
        video3.StoreComment(comm3);
        Console.WriteLine();

        Video video4= new Video("Best of efy","Joshua Poter",12000);
        Comment com1= new Comment("roland","ohh cool");
        Comment com2= new Comment("Marc","Thank you for displaying this great leaning");
        Comment com3= new Comment("feli","That is what i am looking for");
        video4.StoreComment(com1);
        video4.StoreComment(com2);
        video4.StoreComment(com3);
        Console.WriteLine();

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