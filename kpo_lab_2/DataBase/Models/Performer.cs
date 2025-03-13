namespace kpo_lab_2.DataBase.Models;

public class Performer
{
    public int Id { get; set; }
    
    public string? Name { get; set; }
    
    public string? Surname { get; set; }
    
    public string? Nickname { get; set; }

    public Performer(string name, string surname, string nickname)
    {
        Name = name;
        Surname = surname;
        Nickname = nickname;
    }
}