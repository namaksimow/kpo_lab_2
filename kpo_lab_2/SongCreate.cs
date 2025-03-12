using kpo_lab_2.Models;

namespace kpo_lab_2;

public partial class SongCreate : Form
{
    private readonly ApplicationContext _context;
    
    public SongCreate(ApplicationContext context)
    {
        _context = context;
        InitializeComponent();
    }

    private void btnSongCreateCancel_Click(object sender, EventArgs e)
    {
        Close();
    }


    private void btnSongCreateAdd_Click(object sender, EventArgs e)
    {
        string title = txtBoxSongCreateTitle.Text;
        string lyrics = txtBoxSongCreateLyrics.Text;

        if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(lyrics))
        {
            MessageBox.Show(@"Invalid song data");
            return;
        }
        
        var songExist = _context.Songs.FirstOrDefault(s => s.Title == title && s.Lyrics == lyrics);
        if (songExist != null)
        {
            MessageBox.Show(@"Song already exist");
            return;
        }
        
        string songTitleFromAlbum = MainForm.tvData.SelectedNode.Text;
        Console.WriteLine(songTitleFromAlbum);
        var albumFromNode = _context.Albums.FirstOrDefault(a => a.Title == songTitleFromAlbum);
        if (albumFromNode != null)
        {
            Song song = new Song(title, albumFromNode.Id, lyrics);
            _context.Songs.Add(song);
            _context.SaveChanges();
            MainForm.AddSongInTree(albumFromNode.Title, song);
            MessageBox.Show("Song created");
            Close();    
        }
        else
        {
            var songFromNode = _context.Songs.FirstOrDefault(s => s.Title == songTitleFromAlbum);
            int albumId = songFromNode.AlbumId;
            var albumExist = _context.Albums.FirstOrDefault(a => a.Id == albumId);

            Song song = new Song(title, albumId, lyrics);
            _context.Songs.Add(song);
            _context.SaveChanges();
            MainForm.AddSongInTree(albumExist.Title, song);
            MessageBox.Show("Song created");
            Close();    
        }
    }
}