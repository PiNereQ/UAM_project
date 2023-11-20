using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Comment
    {
        public Guid Id { get; set; }

        public Product Product { get; set; }

        public string Description { get; set; }

        public DateTime creationDate { get; set; }

        public bool isDeleted { get; set; }

        //public User creatorUserId { get; set; }
    }
}