using SocialMedia.Service.Page;
using SocialMedia.Service.Post;

namespace SocialMedia.Action.Announcement
{
    class Announcement : Post
    {
        public Announcement(string title, string message, int id, DateTime createdDate, Page page)
            : base(title, message, id, createdDate, page)
        {
        }
    }
}
