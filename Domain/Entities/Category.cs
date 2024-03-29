using System;

namespace SillyStyles.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Slug { get; set; }

        public Category(string categoryName)
        {
            CategoryName = categoryName;
            Slug = CategoryName.ToLower().Replace( ' ' , '-' );
        }
    }
}