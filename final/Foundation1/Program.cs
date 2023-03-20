using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a list of videos
        List<Video> videos = new List<Video>();

        // Create some videos and add them to the list
        videos.Add(new Video("Video 1", "Author 1", 60));
        videos.Add(new Video("Video 2", "Author 2", 120));
        videos.Add(new Video("Video 3", "Author 3", 180));

        // Add comments to each video
        videos[0].AddComment("Commenter 1", "Comment 1");
        videos[0].AddComment("Commenter 2", "Comment 2");
        videos[1].AddComment("Commenter 3", "Comment 3");
        videos[2].AddComment("Commenter 4", "Comment 4");
        videos[2].AddComment("Commenter 5", "Comment 5");

        // Iterate through the list of videos and display information about each one
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video._title);
            Console.WriteLine("Author: " + video._author);
            Console.WriteLine("Length: " + video._length + " seconds");
            Console.WriteLine("Number of comments: " + video.GetCommentCount());

            // Iterate through the comments for this video and display each one
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine("Comment by " + comment._commenter + ": " + comment._text);
            }

            Console.WriteLine(); 
        }

        Console.ReadLine(); 
    }
}