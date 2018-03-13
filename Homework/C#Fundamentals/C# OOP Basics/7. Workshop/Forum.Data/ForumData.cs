﻿using Forum.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Data
{
    public class ForumData
    {
        public List<User> Users { get; set; }

        public List<Category> Categories { get; set; }

        public List<Reply> Replies { get; set; }

        public List<Post> Posts { get; set; }

        public ForumData()
        {
            this.Users = DataMapper.LoadUsers();
            this.Categories = DataMapper.LoadCategories();
            this.Replies = DataMapper.LoadReplies();
            this.Posts = DataMapper.LoadPosts();
        }

        public void SaveChanges()
        {
            DataMapper.SaveUser(Users);
            DataMapper.SaveCategories(Categories);
            DataMapper.SavePost(Posts);
            DataMapper.SaveReplies(Replies);
        }
    }
}
