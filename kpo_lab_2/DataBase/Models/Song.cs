namespace kpo_lab_2.Models;

public class Song
{
    public int Id { get; set; }
    
    public string? Title { get; set; }
    
    public int AlbumId { get; set; }
    
    public string? Lyrics { get; set; }
}