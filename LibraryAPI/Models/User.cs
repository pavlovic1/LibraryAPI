﻿using LibraryAPI.Models;

public class User
{
    public int UserId { get; set; }
    public string Username { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
    public string Role { get; set; } = null!;


    // Foreign key relationship
    public int MemberId { get; set; }
    public Member Member { get; set; } = null!;  // Navigation property
}
