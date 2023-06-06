namespace SocialMedia.Service.Comment
{
    public class Comment
    {
        public string Message { get; set; }
        public int ID { get; set; }

        public DateTime Created { get; set; }

        public Post.Post BelongsToPost { get; set; }

        public bool isModerated { get; set; }

        public Comment(string message, int iD, DateTime created, Post.Post belongsTo, bool isModerated)
        {
            Message = message;
            ID = iD;
            Created = created;
            BelongsToPost = belongsTo;
            this.isModerated = isModerated;
        }
    }
}
