﻿namespace AppApi.Models
{
    public class Book:BaseEntity
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Description { get; set; }
    }
}
