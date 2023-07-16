using System;

class Program
{
    static void Main(string[] args)
    {
        //First video and comments
        List<Video> videos = new List<Video>();
        Video video1 = new Video("Top 5, best bands", "Watchmojo", 600);
        //Comments
        Comment commentvideo1 = new Comment("Juan", "Wow I love that first band! ");
        Comment commentvideo12 = new Comment(
            "Pedro",
            "I think that the last one should be the first"
        );
        Comment commentvideo13 = new Comment("Manuel", "I love the beatles");
        video1.comments.Add(commentvideo1);
        video1.comments.Add(commentvideo12);
        video1.comments.Add(commentvideo13);
        //Second video  and comments
        Video video2 = new Video("Top 5, best videogames", "Watchmojo", 500);
        //Comments
        Comment commentVideo2 = new Comment("Juan", "Wow I love that first videogame! ");
        Comment commentVideo21 = new Comment(
            "Pedro",
            "I think that the last one should be the first"
        );
        Comment commentVideo23 = new Comment("Ana", "I love Dark Souls! ");
        video2.comments.Add(commentVideo2);
        video2.comments.Add(commentVideo21);
        video2.comments.Add(commentVideo23);
        //Third video
        Video video3 = new Video("Top 5, best churches", "Watchmojo", 200);
        //Comments
        Comment commentVideo3 = new Comment(
            "Pablo",
            "I love being part of the Church of Jesus Christ! "
        );
        Comment commentVideo32 = new Comment("Juana", "I don't like this kind of content.");
        Comment commentVideo33 = new Comment("Frabricio", "That was weird ");
        Comment commentVideo34 = new Comment("Francisco", "I like being catholic");
        video3.comments.Add(commentVideo3);
        video3.comments.Add(commentVideo32);
        video3.comments.Add(commentVideo33);
        video3.comments.Add(commentVideo34);

        //Add videos and display
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        foreach (Video vid in videos)
        {
            vid.Display();
            vid.NumOfComments();
        }
    }
}
