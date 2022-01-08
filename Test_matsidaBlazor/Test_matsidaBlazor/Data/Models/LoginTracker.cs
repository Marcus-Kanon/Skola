namespace Test_matsidaBlazor.Data.Models
{
    public class LoginTracker
    {
        public int Id { get; set; }
        public string Key { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public DateTime Created { get; set; }
        public DateTime LastUsed { get; set; }
    }
}
