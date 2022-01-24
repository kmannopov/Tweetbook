using Tweetbook.Domain;

namespace Tweetbook.Services;

public interface IPostService
{
    List<Post> GetPosts();

    Post GetPostById(Guid postId);

    bool UpdatePost(Post post);

    bool DeletePost(Guid postId);
}
