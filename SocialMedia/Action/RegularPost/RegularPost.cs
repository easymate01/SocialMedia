using SocialMedia.Service.Page;
using SocialMedia.Service.Post;

namespace SocialMedia.Action.RegularPost
{
    class RegularPost : Post
    {
        public RegularPost(string title, string message, int id, DateTime createdDate, Page page)
            : base(title, message, id, createdDate, page)
        {
        }
    }
}
