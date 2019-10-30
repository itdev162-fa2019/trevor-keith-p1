using System;

namespace Domain
{
    public class User
    {
        public string username { get; set; }

        public string userId { get; set; }

        public int[] posts { get; set; }

        public int[] replies { get; set; }

        public DateTime creationDate { get; set; }

        public User() {
            creationDate = DateTime.Now;

        }

    }

}