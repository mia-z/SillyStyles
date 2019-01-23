using System;
using System.ComponentModel.DataAnnotations;

namespace SillyStyles.Domain.Entities
{
    public class Review
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime PostDate { get; set; }
        public string Description { get; set; }

        public Review(string name, DateTime postDate, string description)
        {
            Name = name;
            PostDate = postDate;
            Description = description;
        }
    }
}