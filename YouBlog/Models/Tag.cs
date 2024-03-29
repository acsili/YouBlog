﻿using YouBlog.DAL.Interfaces;

namespace YouBlog.Models
{
    public class Tag : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Post> Posts { get; set; } = new();
    }
}
