using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Post
{
    class Program
    {
        static void Main(string[] args)
        {
            var myPost = new Post("Excercise Section 2 Lecture 15", "StackOverFlow Post");
            myPost.UpVote(3);
            myPost.UpVote(3);
            myPost.DownVote(2);
            myPost.DisplayVote(myPost);
        }
    }
}
