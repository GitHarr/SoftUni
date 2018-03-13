using Forum.App.UserInterface.ViewModels;
using Forum.Data;
using Forum.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forum.App.Services
{
    internal static class PostService
    {
        public static Category GetCategory(int id)
        {
            var forumData = new ForumData();
            var category = forumData.Categories.SingleOrDefault(c => c.Id == id);
            return category;
        }

        public static IList<ReplyViewModel> GetPostReplies(int postId)
        {
            var forumData = new ForumData();
            var post = forumData.Posts.Find(p => p.Id == postId);

            var replies = new List<ReplyViewModel>();

            foreach (var replyId in post.ReplyIds)
            {
                var reply = forumData.Replies.Find(r => r.Id == replyId);
                replies.Add(new ReplyViewModel(reply));
            }
            return replies;
        }

        public static string[] GetAllCategoryNames()
        {
            var forumData = new ForumData();
            return forumData.Categories.Select(c => c.Name).ToArray();
        }

        public static IEnumerable<Post> GetPostsByCategory(int categoryId)
        {
            var forumData = new ForumData();
            var category = forumData.Categories.First(c => c.Id == categoryId);
            return forumData.Posts.Where(p => category.PostIds.Contains(p.Id)).ToList();
        }

        public static PostViewModel GetPostViewModel(int postId)
        {
            var forumData = new ForumData();
            var post = forumData.Posts.Find(p => p.Id == postId);
            return new PostViewModel(post);
        }

        private static Category EnsureCategory(PostViewModel postViewModel, ForumData forumData)
        {
            var category = forumData.Categories.FirstOrDefault(c => c.Name == postViewModel.Category);

            if (category == null)
            {
                var id = forumData.Categories.LastOrDefault()?.Id + 1 ?? 1;
                category = new Category(id, postViewModel.Category, new List<int>());
                forumData.Categories.Add(category);
                forumData.SaveChanges();
            }
            return category;
        }

        public static bool TrySavePost(PostViewModel postViewModel)
        {
            var isTitleValid = !string.IsNullOrWhiteSpace(postViewModel.Title);
            var isContentValid = postViewModel.Content.Any();
            var isCategoryValid = !string.IsNullOrWhiteSpace(postViewModel.Category);

            if (!isTitleValid || !isContentValid || !isCategoryValid)
            {
                return false;
            }

            var forumData = new ForumData();
            var category = EnsureCategory(postViewModel, forumData);

            var postId = forumData.Posts.LastOrDefault()?.Id + 1 ?? 1;
            var author = UsersService.GetUser(postViewModel.Author, forumData);
            var content = string.Join("", postViewModel.Content);
            var post = new Post(postId, postViewModel.Title, content, category.Id, author.Id, new List<int>());
            forumData.Posts.Add(post);
            category.PostIds.Add(postId);
            author.PostIds.Add(postId);
            forumData.SaveChanges();
            postViewModel.PostId = postId;
            return true; 
        }

        public static bool TrySaveReply(ReplyViewModel replyViewModel, int postId)
        {
            if (!replyViewModel.Content.Any())
            {
                return false;
            }

            var forumData = new ForumData();
            var author = UsersService.GetUser(replyViewModel.Author, forumData);
            var post = forumData.Posts.Single(p => p.Id == postId);
            var replyId = forumData.Replies.LastOrDefault()?.Id + 1 ?? 1;
            var content = string.Join("", replyViewModel.Content);
            var reply = new Reply(replyId, content, author.Id, postId);
            forumData.Replies.Add(reply);

            forumData.Replies.Add(reply);
            post.ReplyIds.Add(replyId);
            forumData.SaveChanges();
            return true;
        }
    }
}
