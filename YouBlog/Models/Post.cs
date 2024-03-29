﻿using YouBlog.DAL.Interfaces;

namespace YouBlog.Models
{
    public class Post : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime UpdatedDate { get; set; } = DateTime.Now;
        public int UserId { get; set; }
        public User? User { get; set; }
        public List<Tag> Tags { get; set; } = new();
    }
}
