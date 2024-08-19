namespace buoi1.Models
{
    public class user
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public user() { }

        public user(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }


    }
}
