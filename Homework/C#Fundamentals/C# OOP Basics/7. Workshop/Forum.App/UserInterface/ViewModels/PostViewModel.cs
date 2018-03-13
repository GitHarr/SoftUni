namespace Forum.App.UserInterface.ViewModels
{
    using Forum.App.Services;
    using Forum.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PostViewModel
    {
        private const int LINE_LENGHT = 37;

        public PostViewModel()
        {
            Content = new List<string>();
        }

        public PostViewModel(Post post)
        {
            Author = UsersService.GetUser(post.AuthorId).Username;
            Category = PostService.GetCategory(post.CategoryId).Name;
            this.Title = post.Title;
            this.PostId = post.Id;
            Content = GetLines(post.Content);
            this.Replies = PostService.GetPostReplies(post.Id);
        }

        private IList<string> GetLines(string content)
        {
            var contentChars = content.ToCharArray();
            var contentLines = new List<string>();
            for (int lineCounter = 0; lineCounter < contentLines.Count; lineCounter+=LINE_LENGHT)
            {
                var rowCharacters = contentChars.Skip(lineCounter).Take(lineCounter + LINE_LENGHT);
                var line = string.Join("", rowCharacters);
                contentLines.Add(line);
            }
            return contentLines;
        }

        public int PostId { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Category { get; set; }

        public IList<string> Content { get; set; }

        public IList<ReplyViewModel> Replies { get; set; }
    }
}
