using kpo_lab_2.DataBase.Models;
using ApplicationContext = kpo_lab_2.DataBase.ApplicationContext;

namespace kpo_lab_2;

public partial class AlbumCreate : Form
{
    private readonly ApplicationContext _context;
    
    public AlbumCreate(ApplicationContext context)
    {
        _context = context;
        InitializeComponent();
    }

    private void btnAlbumCreateCancel_Click(object sender, EventArgs e)
    {
        Close();
    }


    private void btnAlbumCreateAdd_Click(object sender, EventArgs e)
    {
        string albumTitle = txtBoxAlbumCreateAlbumTitle.Text;

        if (string.IsNullOrEmpty(albumTitle))
        {
            MessageBox.Show(@"Invalid album data");
            return;
        }
        
        var albumExist = _context.Albums.FirstOrDefault(a => a.Title == albumTitle);
        if (albumExist != null)
        {
            MessageBox.Show(@"Current album exist");
            return;
        }

        string performerAlbumTitle = MainForm.tvData.SelectedNode.Text;
        Console.WriteLine(performerAlbumTitle);
        var performerFromNode =  _context.Performers.FirstOrDefault(p => p.Nickname == performerAlbumTitle);
        if (performerFromNode != null)
        {
            int performerId = performerFromNode.Id;

            Album album = new Album(albumTitle, performerId);
            Console.WriteLine($"{album.Title} - {performerId}");
            _context.Albums.Add(album);
            _context.SaveChanges();
            MainForm.AddAlbumInTree(performerFromNode.Nickname, album);
            Close();    
        }
        else
        {
            var albumFromNode = _context.Albums.FirstOrDefault(a => a.Title == performerAlbumTitle);
            int performerIdFromNodeAlbum = albumFromNode.PerformerId;
            var performerExist = _context.Performers.FirstOrDefault(p => p.Id == performerIdFromNodeAlbum);
            int performerId = performerExist.Id;

            Album album = new Album(albumTitle, performerId);
            _context.Albums.Add(album);
            _context.SaveChanges();
            MainForm.AddAlbumInTree(performerExist.Nickname, album);
            Close();    
        }
        
    }
}