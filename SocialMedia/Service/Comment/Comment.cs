namespace SocialMedia.Service.Comment
{
    class Comment
    {
        public string Message { get; }
        public int ID { get; }
        public DateTime CreatedDate { get; }
        public Post.Post BelongsToPost { get; }
        public bool IsModerated { get; set; }

        public Comment(string message, int id, DateTime createdDate, Post.Post post)
        {
            Message = message;
            ID = id;
            CreatedDate = createdDate;
            BelongsToPost = post;
            IsModerated = false;
        }
    }
}