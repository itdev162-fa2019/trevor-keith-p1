using System;

namespace Domain
{
    public class Post
    {
        public int posterId { get; set; }

        public int threadId {get; set; }

        public string postContent { get; set; }

        public DateTime creationDT { get; private set; }

        public Post() {
            creationDT = DateTime.Now;

        }

    }
    
}