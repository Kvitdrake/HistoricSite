namespace HistoricSite.Models
{
    public class User
    {
        [Key]
        private protected string Id { get; set; }
        private protected string Name { get; set; }
        private protected int Age { get; set; }
        private protected string Email { get; set; }
        private protected string Password { get; set; }
        DateTime RegisterDate { get; set; }
        public User(string name, int age, string email, string passvord, DateTime registerDate)
        {
            Name = name;
            Age = age;
            Email = email;
            Password = passvord;
            RegisterDate = registerDate;
        }
    }
}
