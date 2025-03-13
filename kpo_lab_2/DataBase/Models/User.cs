namespace kpo_lab_2.DataBase.Models;

public class User
{
    public int Id { get; set; }
    
    public string? Name { get; set; }
    
    public string? Password { get; set; }

    public User(string name, string password)
    {
        Name = name;
        Password = password;
    }
}