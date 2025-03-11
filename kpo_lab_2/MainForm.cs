using kpo_lab_2.Models;

namespace kpo_lab_2;

public partial class MainForm : Form
{
    private static ApplicationContext _context;
    
    public MainForm(ApplicationContext context)
    {
        _context = context;
        InitializeComponent();
    }

    #region btnLoad
    
    private void btnLoad_LoadData(object sender, EventArgs e)
    {
        LoadPerformers();
    }

    private void LoadPerformers()
    {        
        var performers = _context.Performers.ToList();

        int performersCount = performers.Count;

        for (int i = 0; i < performersCount; i++)
        {
            Performer performer = performers[i];
            bool nodeExists = tvData.Nodes.Cast<TreeNode>()
                .Any(n => n.Text == performer.Nickname);
            if (!nodeExists)
            {
                TreeNode node = new TreeNode($"{performer.Nickname}", 0, 0);
                tvData.Nodes.Add(node);    
                LoadAlbums(performer.Id, node);
                node.ContextMenuStrip = contextMenuStrip;
            }
            
        }
    }

    private void LoadAlbums(int performerId, TreeNode parentNode)
    {
        var albums = _context.Albums.Where(element => element.PerformerId == performerId).ToList();
        
        int albumsCount = albums.Count;

        for (int i = 0; i < albumsCount; i++)
        {
            Album album = albums[i];
            bool nodeExists = tvData.Nodes.Cast<TreeNode>()
                .Any(n => n.Text == album.Title);
            if (!nodeExists)
            {
                var node = new TreeNode($"{album.Title}", 1, 1);
                parentNode.Nodes.Add(node);
                LoadSongs(album.Id, node);    
            }
        }
    }

    private void LoadSongs(int albumId, TreeNode parentNode)
    {
        var songs = _context.Songs.Where(element => element.AlbumId == albumId).ToList();
        
        int songsCount = songs.Count;

        for (int i = 0; i < songsCount; i++)
        {
            Song song = songs[i];
            bool nodeExists = tvData.Nodes.Cast<TreeNode>()
                .Any(n => n.Text == song.Title);
            if (!nodeExists)
            {
                var node = new TreeNode($"{song.Title}", 2, 2);
                parentNode.Nodes.Add(node);    
            }
        }
    }
    
    #endregion

    private void ContextMenuItemAdd(object sender, EventArgs e)
    {
        if (tvData.SelectedNode == null)
        {
            return;
        }

        string tableContent = tvData.SelectedNode.Text;

        var isPerformer = _context.Performers.FirstOrDefault(p => p.Nickname == tableContent);
        if (isPerformer != null)
        {
            PerformerCreate createForm = new PerformerCreate(_context);
            createForm.Show();    
        }

        var isAlbum = _context.Albums.FirstOrDefault(a => a.Title == tableContent);
        if (isAlbum != null)
        {
            AlbumCreate createForm = new AlbumCreate(_context);
            createForm.Show();
        }
        
        var isSong = _context.Songs.FirstOrDefault(s => s.Title == tableContent);
        if (isSong != null)
        {
            SongCreate createForm = new SongCreate(_context);
            createForm.Show();
        }
        
    }

    private void ContextMenuItemUpdate(object sender, EventArgs e)
    {
        if (tvData.SelectedNode == null)
        {
            return;
        }

        string tableContent = tvData.SelectedNode.Text;

        Update updateForm = new Update(_context, tableContent);
        updateForm.Show();
    }

    private void ContextMenuItemDelete(object sender, EventArgs e)
    {
        if (tvData.SelectedNode == null)
        {
            return;
        }
        
        string tableContent = tvData.SelectedNode.Text;
        var isPerformer = _context.Performers.FirstOrDefault(p => p.Nickname == tableContent);
        if (isPerformer != null)
        {
            RemovePerformerFromTree(isPerformer);
            _context.Performers.Remove(isPerformer);
            _context.SaveChanges();
        }

        var isAlbum = _context.Albums.FirstOrDefault(a => a.Title == tableContent);
        if (isAlbum != null)
        {
            var performer = _context.Performers.FirstOrDefault(p => p.Id == isAlbum.PerformerId);
            
            RemoveAlbumFromTree(performer.Nickname, isAlbum);
            _context.Albums.Remove(isAlbum);
            _context.SaveChanges();
        }
        
        var isSong = _context.Songs.FirstOrDefault(s => s.Title == tableContent);
        if (isSong != null)
        {
            RemoveSongFromTree(isSong);
            _context.Songs.Remove(isSong);
            _context.SaveChanges();
        }
    }
    
    public void RemovePerformerFromTree(Performer performer)
    {
        TreeNode? nodeToRemove = tvData.Nodes.Cast<TreeNode>()
            .FirstOrDefault(n => n.Text == performer.Nickname);

        if (nodeToRemove != null)
        {
            tvData.Nodes.Remove(nodeToRemove);
        }
    }
    
    public static void UpdatePerformerInTree(string oldNickname, string newNickname)
    {
        TreeNode? existingNode = tvData.Nodes.Cast<TreeNode>()
            .FirstOrDefault(n => n.Text == oldNickname); 

        if (existingNode != null)
        {
            existingNode.Text = newNickname; 
        }
        else
        {
            TreeNode newNode = new TreeNode(newNickname, 0, 0);
            newNode.ContextMenuStrip = contextMenuStrip;
            tvData.Nodes.Add(newNode);
        }
    }
    
    public static void AddPerformerInTree(Performer performer)
    {
        TreeNode? existingNode = tvData.Nodes.Cast<TreeNode>()
            .FirstOrDefault(n => n.Text == performer.Nickname);

        if (existingNode != null)
        {
            existingNode.Text = performer.Nickname;
        }
        else
        {
            TreeNode newNode = new TreeNode(performer.Nickname, 0, 0);
            newNode.ContextMenuStrip = contextMenuStrip;
            tvData.Nodes.Add(newNode);
        }
    }
    
    public static void AddAlbumInTree(string performerNickname, Album album)
    {
        TreeNode? existingNode = tvData.Nodes.Cast<TreeNode>()
            .FirstOrDefault(n => n.Text == performerNickname);

        if (existingNode != null)
        {
            TreeNode newNode = new TreeNode(album.Title, 1, 1);
            existingNode.Nodes.Add(newNode);
            newNode.ContextMenuStrip = contextMenuStrip;
        }
    }

    public static void RemoveAlbumFromTree(string performerNickname, Album album)
    {
        TreeNode? nodePerformer = tvData.Nodes.Cast<TreeNode>()
            .FirstOrDefault(n => n.Text == performerNickname);
        
        TreeNode? nodeToRemove = nodePerformer.Nodes.Cast<TreeNode>()
            .FirstOrDefault(n => n.Text == album.Title);

        if (nodeToRemove != null)
        {
            nodePerformer.Nodes.Remove(nodeToRemove);
        }
    }
    
    public static void UpdateAlbumInTree(string oldTitle, string newTitle)
    {
        var oldAlbum = _context.Albums.FirstOrDefault(a => a.Title == oldTitle);
        int oldAlbumPerformerId = oldAlbum.PerformerId;
        var performer = _context.Performers.FirstOrDefault(p => p.Id == oldAlbumPerformerId);
        
        TreeNode? parentNode = tvData.Nodes.Cast<TreeNode>()
            .FirstOrDefault(n => n.Text == performer.Nickname);
        
        TreeNode? nodeToChange = parentNode.Nodes.Cast<TreeNode>()
            .FirstOrDefault(n => n.Text == oldTitle);
        
        nodeToChange.Text = newTitle;
    }

    public static void AddSongInTree(string albumTitle, Song song)
    {
        var album =  _context.Albums.FirstOrDefault(a => a.Title == albumTitle);
        int albumPerformerId = album.PerformerId;
        var performer = _context.Performers.FirstOrDefault(p => p.Id == albumPerformerId);
        
        TreeNode? performerNode = tvData.Nodes.Cast<TreeNode>()
            .FirstOrDefault(n => n.Text == performer.Nickname);
        
        TreeNode? albumNode = performerNode.Nodes.Cast<TreeNode>()
            .FirstOrDefault(n => n.Text == albumTitle);
        
        TreeNode songNode = new TreeNode(song.Title, 2, 2);
        songNode.ContextMenuStrip = contextMenuStrip;
        albumNode.Nodes.Add(songNode);
    }

    public static void RemoveSongFromTree(Song song)
    {
        int albumId = song.AlbumId;
        var album = _context.Albums.FirstOrDefault(a => a.Id == albumId);
        var performer = _context.Performers.FirstOrDefault(p => p.Id == album.PerformerId);
        
        TreeNode? performerNode = tvData.Nodes.Cast<TreeNode>()
            .FirstOrDefault(n => n.Text == performer.Nickname);
        
        TreeNode? albumNode = performerNode.Nodes.Cast<TreeNode>()
            .FirstOrDefault(n => n.Text == album.Title);
        
        TreeNode? songNode = albumNode.Nodes.Cast<TreeNode>()
            .FirstOrDefault(n => n.Text == song.Title);
        
        albumNode.Nodes.Remove(songNode);
    }

    public static void UpdateSongInTree(string oldTitle, string newTitle)
    {
        Console.WriteLine($"{oldTitle} -> {newTitle}");
        var oldSong = _context.Songs.FirstOrDefault(s => s.Title == oldTitle);
        Console.WriteLine(oldSong.Title);
        int albumId = oldSong.AlbumId;
        Console.WriteLine(albumId);
        var currentAlbum = _context.Albums.FirstOrDefault(a => a.Id == albumId);
        Console.WriteLine(currentAlbum.Title);
        int performerId = currentAlbum.PerformerId;
        Console.WriteLine(performerId);
        var performer = _context.Performers.FirstOrDefault(p => p.Id == performerId);
        Console.WriteLine(performer.Nickname);
        
        TreeNode? performerNode = tvData.Nodes.Cast<TreeNode>()
            .FirstOrDefault(n => n.Text == performer.Nickname);
        
        TreeNode? albumNode = performerNode.Nodes.Cast<TreeNode>()
            .FirstOrDefault(n => n.Text == currentAlbum.Title);
        
        TreeNode? songNode = albumNode.Nodes.Cast<TreeNode>()
            .FirstOrDefault(n => n.Text == oldTitle);
        
        songNode.Text = newTitle;
    }
}