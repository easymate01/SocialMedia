namespace SocialMedia.Service.Post
{
    public class Post
    {
        public string Title { get; }
        public string Message { get; }
        public int ID { get; set; }
        public DateTime CreatedDate { get; }

        public Page.Page PageId { get; }

        public List<Comment.Comment> Comments { get; }


        public Post(string title, string message, int id, DateTime createdDate, Page.Page pageId)
        {
            Title = title;
            Message = message;
            ID = id;
            CreatedDate = createdDate;
            PageId = pageId;
            Comments = new List<Comment.Comment>();

        }

    }
}
