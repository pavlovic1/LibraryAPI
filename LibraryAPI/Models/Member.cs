public class Member
{
    public int MemberId { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;

    // One-to-one relationship with User
    public User? User { get; set; }  // Navigation property
}
