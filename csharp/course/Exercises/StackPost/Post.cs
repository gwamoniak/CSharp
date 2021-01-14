using System;

namespace StackPost
{
    public class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public DateTime FirstPostDateTime { get; } = DateTime.UtcNow;

        public int upVote { get; private set; }
        public int downVote { get; private set; }

      
        public int Score => upVote - downVote;
    
        public void UpVote()
        {
            upVote++;
        }

        public void DownVote()
        {
            downVote++;
        }

        public void DisplayVotes()
        {
            Console.WriteLine("number of votes: " + Score);
        }
    }
}
