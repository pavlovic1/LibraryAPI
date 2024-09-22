namespace LibraryAPI.DTOs
{
    public class LoginRequest
    {
        public string Username { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
    }
}
