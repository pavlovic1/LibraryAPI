﻿namespace LibraryAPI.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int BookId { get; set; }
        public int MemberId { get; set; }
        public int Rating { get; set; }
        public string? Comment { get; set; }
        public DateTime ReviewDate { get; set; }
        public Book? Book { get; set; }
        public Member? Member { get; set; }
    }
}
