namespace SocialMedia.Service.Page
{
    public class Page
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int ID { get; set; }

        public List<Post.Post> Posts { get; set; }

    }
}
