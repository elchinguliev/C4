using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44444
{
    internal class Post
    {
       
        public int Id { get; set; } 
        public int LikeCount { get; set; }
        public int ViewCount { get; set; }

        public override string ToString()
        {
            return $"ID : {Id}\nLike Count : {LikeCount}\nView Count : {ViewCount}";
        }
      



        public static void CreationDateTime()
{
    DateTime currentDsteTime = DateTime.Now;
    Console.WriteLine(currentDsteTime+"\n");

}

    }


    }

