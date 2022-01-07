namespace Test_matsidaBlazor.Data.Models
{
    public class LoginTracker
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastUsed { get; set; }
    }
}
