using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SillyStyles
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Slug { get; set; }

        public List<Review> Reviews { get; set; } = new List<Review>();

        public Product(string title, string imageUrl, decimal price, string description)
        {
            Title = title;
            ImageUrl = imageUrl;
            Price = price;
            Description = description;
            Slug = Title.ToLower().Replace( ' ' , '-' );
        }
    }
}