using System;
class Program
{
    static void Main(string[] args)
    {
        //First video and comments
        Video video1 = new Video("Top 5, best bands", "Watchmojo", 40);
        //Comments
        Comment commentvideo1 = new Comment("Juan", "Wow I love that first band! ");
        Comment commentvideo12 = new Comment(
            "Pedro",
            "I think that the last one should be the first"
        );
        video1.comments.Add(commentvideo1);
        video1.comments.Add(commentvideo12);
        video1.Display();
        video1.NumOfComments();

        //Second video  and comments
        Video video2 = new Video("Top 5, best videogames", "Watchmojo", 40);
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
        video2.Display();
        video2.NumOfComments();
    }
}

