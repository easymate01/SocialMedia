
using SocialMedia.Action.Announcement;
using SocialMedia.Action.RegularPost;
using SocialMedia.Service.Page;
using SocialMedia.Service.Post;

var currentPageId = 0;
var page1 = new Page()
{
    Title = "Page 01",
    Description = "Welcome to my social media page!",
    ID = currentPageId++,
    Posts = new List<Post>()
};

var currentPostId = 0;
//Create Posts
var Announcement = new Announcement("New Announcement - (POST-1)", "Check out the latest news!", currentPostId++, DateTime.Now, page1);
var RegularPost = new RegularPost("New Post - (POST-2)", "Just sharing some thoughts...", currentPostId++, DateTime.Now, page1);

page1.Posts.Add(Announcement);
page1.Posts.Add(RegularPost);

Console.WriteLine($"Page Title: {page1.Title}");
Console.WriteLine($"Page Description: {page1.Description}");

Console.WriteLine("Posts:");
Console.WriteLine("----------------------");

foreach (var post in page1.Posts)
{
    Console.WriteLine($"Post ID: {post.ID}");
    Console.WriteLine($"Post TITLE: {post.Title}");
    Console.WriteLine($"Post MESSAGE: {post.Message}");
    Console.WriteLine($"Post Created at: {post.CreatedDate}");
    Console.WriteLine("----------------------");

}