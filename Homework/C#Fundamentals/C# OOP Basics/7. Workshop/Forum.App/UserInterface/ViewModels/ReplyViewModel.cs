namespace Forum.App.UserInterface.ViewModels
{
    using Forum.App.Services;
    using Forum.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ReplyViewModel
    {
        private const int LINE_LENGHT = 37;

        public ReplyViewModel()
        {
            Content = new List<string>();
        }

        public ReplyViewModel(Reply reply)
        {
            Author = UsersService.GetUser(reply.AuthorId).Username;
            Content = GetLines(reply.Content);
        }

        public string Author { get; set; }

        public IList<string> Content { get; set; }

        private IList<string> GetLines(string content)
        {
            var contentChars = content.ToCharArray();
            var contentLines = new List<string>();
            for (int lineCounter = 0; lineCounter < contentChars.Length; lineCounter += LINE_LENGHT)
            {
                var rowCharacters = contentChars.Skip(lineCounter).Take(lineCounter + LINE_LENGHT);
                var line = string.Join("", rowCharacters);
                contentLines.Add(line);
            }
            return contentLines;
        }
    }
}