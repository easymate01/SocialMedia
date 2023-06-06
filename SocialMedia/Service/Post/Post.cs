namespace SocialMedia.Service.Post
{
    abstract class Post
    {
        public string Title { get; }
        public string Message { get; }
        public int ID { get; }
        public DateTime CreatedDate { get; }
        public Page.Page BelongsToPage { get; }
        public List<Comment.Comment> Comments { get; }

        public Post(string title, string message, int id, DateTime createdDate, Page.Page page)
        {
            Title = title;
            Message = message;
            ID = id;
            CreatedDate = createdDate;
            BelongsToPage = page;
            Comments = new List<Comment.Comment>();
        }
    }


}
