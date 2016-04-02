using System;
using System.Runtime.InteropServices;

namespace Stack_Post
{
    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Creation => DateTime.Now;
       
        public int CurrentVote { get; private set; }

       

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
        }

        public int UpVote(int voteCount)
        {
            this.CurrentVote = voteCount++;
            return voteCount;
        }

        public int DownVote(int voteCount)
        {
            this.CurrentVote = voteCount--;
            return voteCount;
        }

        public void DisplayVote(Post p)
        {
            var timeStamp = Creation;
             Console.WriteLine("Post: {0} \ncreated on {1} {2}\nCurrent Vote: {3}", p.Title, timeStamp.ToShortDateString(),timeStamp.ToShortTimeString(),this.CurrentVote.ToString());
             
        }
        

    }
}