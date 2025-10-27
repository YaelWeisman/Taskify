namespace Taskify.Entities
{
    public class User
    {
        private int ID { get; set; }
        private string TZ { get; set; }
        private string Name { get; set; }
        private string Email { get; set; }
        private string Password { get; set; }
        private string Role { get; set; }
        private bool IsManager { get; set; }

        public User(string TZ, string name, string email, string password, string role, bool ismanger)
        {
            this.TZ = TZ;
            this.Name = name;
            this.Email = email;
            this.Password = password;
            this.Role = role;
            this.IsManager = ismanger;
        }

    }
}
