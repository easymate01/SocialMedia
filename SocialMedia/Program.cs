// Create a page
using SocialMedia.Action.Announcement;
using SocialMedia.Action.RegularPost;
using SocialMedia.Service.Comment;
using SocialMedia.Service.Page;
using SocialMedia.Service.Post;


var page = new Page
{
    Title = "My Social Media Page",
    Description = "Welcome to my social media page!",
    ID = 1,
    Posts = new List<Post>()
};

// Create a post
var announcement = new Announcement("New Announcement - (POST-1)", "Check out the latest news!", 1, DateTime.Now, page);
var regularPost = new RegularPost("Regular Post - (POST-2)", "Just sharing some thoughts...", 2, DateTime.Now, page);

// Add posts to the page
page.Posts.Add(announcement);
page.Posts.Add(regularPost);

// Create comments
var comment1 = new Comment("Great announcement!", 1, DateTime.Now, announcement);
var comment2 = new Comment("Interesting post!", 2, DateTime.Now, regularPost);

// Add comments to the posts
announcement.Comments.Add(comment1);
regularPost.Comments.Add(comment2);

// Moderate comments
comment1.IsModerated = true;
comment2.IsModerated = true;

//// Get moderated comments for a post
//var moderatedComments = page.GetModeratedComments(regularPost);
//Console.WriteLine("Moderated comments for Regular Post:");
//foreach (var comment in moderatedComments)
//{
//    Console.WriteLine(comment.Message);
//}



// Assuming you have created a 'page' object

Console.WriteLine($"Page Title: {page.Title}");
Console.WriteLine($"Page Description: {page.Description}");

Console.WriteLine("Posts:");
Console.WriteLine("----------------------");

foreach (var post in page.Posts)
{
    Console.WriteLine($"Post ID: {post.ID}");
    Console.WriteLine($"Post Title: {post.Title}");
    Console.WriteLine($"Post Message: {post.Message}");
    Console.WriteLine($"Post Created Date: {post.CreatedDate}");

    Console.WriteLine("Comments:");
    Console.WriteLine("----------");
    foreach (var comment in post.Comments)
    {
        Console.WriteLine($"Comment ID: {comment.ID}");
        Console.WriteLine($"Comment Message: {comment.Message}");
        Console.WriteLine($"Comment Created Date: {comment.CreatedDate}");
        Console.WriteLine($"Is Moderated: {comment.IsModerated}");
        Console.WriteLine("----------------------");

    }

}
Console.WriteLine();
