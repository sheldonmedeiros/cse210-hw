class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create videos
        Video video1 = new Video("Video 1", "Author 1", 120);
        video1.Comments.Add(new Comment("User1", "Great video!"));
        video1.Comments.Add(new Comment("User2", "I learned a lot from this."));
        video1.Comments.Add(new Comment("User3", "Could you make a follow-up video?"));
        videos.Add(video1);

        Video video2 = new Video("Video 2", "Author 2", 180);
        video2.Comments.Add(new Comment("User4", "Interesting topic."));
        video2.Comments.Add(new Comment("User5", "I have a question regarding the content."));
        videos.Add(video2);

        Video video3 = new Video("Video 3", "Author 3", 150);
        video3.Comments.Add(new Comment("User6", "This video is too short."));
        video3.Comments.Add(new Comment("User7", "Not very informative."));
        videos.Add(video3);

        // Display information for each video
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length (seconds): " + video.Length);
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine("- Commenter: " + comment.Commenter);
                Console.WriteLine("  Text: " + comment.Text);
            }
            Console.WriteLine();
        }
    }
}