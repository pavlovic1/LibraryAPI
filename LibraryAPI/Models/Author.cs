﻿namespace LibraryAPI.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string? Name { get; set; }
        public string? Bio { get; set; }
        public List<Book>? Books { get; set; }
    }
}
