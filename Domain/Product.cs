namespace Domain
{
    public class Product
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool isDeleted { get; set; }

        //public DateTime creationDate { get; set; }

        //public User creatorUserId { get; set; }

        //public Category productCategory { get; set; }

        public string imageUrl { get; set; }
    }
}