﻿using Tweetbook.Domain;

namespace Tweetbook.Services;

public interface IPostService
{
    List<Post> GetPosts();

    Post GetPostById(Guid postId);
}
