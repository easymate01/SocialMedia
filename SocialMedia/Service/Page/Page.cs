namespace SocialMedia.Service.Page
{
    class Page
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int ID { get; set; }
        public List<Post.Post> Posts { get; set; }

        public List<Comment.Comment> GetModeratedComments(Post.Post post)
        {
            List<Comment.Comment> moderatedComments = new List<Comment.Comment>();

            foreach (var comment in post.Comments)
            {
                if (comment.IsModerated)
                {
                    moderatedComments.Add(comment);
                }
            }

            return moderatedComments;
        }


    }

}
