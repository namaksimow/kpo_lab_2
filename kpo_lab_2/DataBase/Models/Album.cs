namespace kpo_lab_2.DataBase.Models;

public class Album
{
    public int Id { get; set; }
    
    public string? Title { get; set; }
    
    public int PerformerId { get; set; }

    public Album(string title, int performerId)
    {
        Title = title;
        PerformerId = performerId;
    }
}