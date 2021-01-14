using System;

namespace StackPost
{
    class Program
    {
        static void Main(string[] args)
        {
            var post = new Post
            {
                Title = "Post Exercise",
                Description = "Description."
            };

            Console.WriteLine(post.Title);
            Console.WriteLine(post.Description);
            Console.WriteLine(post.FirstPostDateTime);

            post.UpVote();
            post.UpVote();
            post.DownVote();

            post.DisplayVotes();
        }
    }
}
