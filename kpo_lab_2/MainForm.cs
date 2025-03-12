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
        Console.WriteLine(tableContent);
        
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

    private void ContextMenuItemAddIn(object sender, EventArgs e)
    {
        if (tvData.SelectedNode == null)
        {
            return;
        }
        
        string tableContent = tvData.SelectedNode.Text;
        
        var isPerformer = _context.Performers.FirstOrDefault(p => p.Nickname == tableContent);
        if (isPerformer != null)
        {
            AlbumCreate createForm = new AlbumCreate(_context);
            createForm.Show();
            return;
        }
        
        var isAlbum = _context.Albums.FirstOrDefault(a => a.Title == tableContent);
        if (isAlbum != null)
        {
            SongCreate createForm = new SongCreate(_context);
            createForm.Show();
            return;
        }

        MessageBox.Show(@"Songs dont have dependency's");
    }
    
    public static void RemovePerformerFromTree(Performer performer)
    {
        TreeNode? nodePerformer = tvData.Nodes.Cast<TreeNode>()
            .FirstOrDefault(n => n.Text == performer.Nickname);
    
        if (nodePerformer == null)
            return;
    
        foreach (TreeNode albumNode in nodePerformer.Nodes.Cast<TreeNode>().ToList())
        {
            var album = _context.Albums.FirstOrDefault(a => a.Title == albumNode.Text);
            if (album != null)
            {
                RemoveAlbumFromTree(performer.Nickname, album);
                _context.Albums.Remove(album);
                _context.SaveChanges();
            }
        }
        tvData.Nodes.Remove(nodePerformer);
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
    
        if (nodePerformer == null)
            return;
    
        TreeNode? nodeToRemove = nodePerformer.Nodes.Cast<TreeNode>()
            .FirstOrDefault(n => n.Text == album.Title);
    
        if (nodeToRemove != null)
        {
            foreach (TreeNode songNode in nodeToRemove.Nodes.Cast<TreeNode>().ToList())
            {
                var song = _context.Songs.FirstOrDefault(s => s.Title == songNode.Text && s.AlbumId == album.Id);
                if (song != null)
                {
                    RemoveSongFromTree(song);
                    _context.Songs.Remove(song);
                    _context.SaveChanges();
                }
            }
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

    private void tvData_ItemDrag(object sender, ItemDragEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }
    }
    
    private void tvData_DragEnter(object sender, DragEventArgs e)
    {
        e.Effect = e.AllowedEffect;
    }

    private void tvData_DragDrop(object sender, DragEventArgs e)
    {
        bool isRightMove = false;
        
        Point targetPoint = tvData.PointToClient(new Point(e.X, e.Y));

        TreeNode targetNode = tvData.GetNodeAt(targetPoint);
        
        TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));

        Console.WriteLine(targetNode.Text);
        Console.WriteLine(draggedNode.Text);
        
        var targetIsPerformer = _context.Performers.FirstOrDefault(p => p.Nickname == targetNode.Text);
        var draggedIsAlbum = _context.Albums.FirstOrDefault(a => a.Title == draggedNode.Text);
        
        if (targetIsPerformer != null && draggedIsAlbum != null)
        {
            List<Song> songs = _context.Songs.Where(s => s.AlbumId == draggedIsAlbum.Id).ToList();
            
            int newPerformerId = targetIsPerformer.Id;
            draggedIsAlbum.PerformerId = newPerformerId;

            if (songs != null)
            {
                foreach (Song song in songs)
                {
                    song.AlbumId = draggedIsAlbum.Id;
                }
            }
            
            _context.SaveChanges();
            isRightMove = true;
        }

        var targetIsAlbum = _context.Albums.FirstOrDefault(a => a.Title == targetNode.Text);
        var draggedIsSong =  _context.Songs.FirstOrDefault(p => p.Title == draggedNode.Text);
        
        if (targetIsAlbum != null && draggedIsSong != null)
        {
            int newAlbumId = targetIsAlbum.Id;
            draggedIsSong.AlbumId = newAlbumId;
            _context.SaveChanges();
            isRightMove = true;
        }
        
        if (!draggedNode.Equals(targetNode) && !ContainsNode(draggedNode, targetNode) && isRightMove)
        {
            if (e.Effect == DragDropEffects.Move)
            {
                draggedNode.Remove();
                targetNode.Nodes.Add(draggedNode);
            }
            
            else if (e.Effect == DragDropEffects.Copy)
            {
                targetNode.Nodes.Add((TreeNode)draggedNode.Clone());
            }
            
            targetNode.Expand();
        }
    }

    private void tvData_DragOver(object sender, DragEventArgs e)
    {
        Point targetPoint = tvData.PointToClient(new Point(e.X, e.Y));
        
        tvData.SelectedNode = tvData.GetNodeAt(targetPoint);
    }
    
    private bool ContainsNode(TreeNode node1, TreeNode node2)
    {
        if (node2.Parent == null) return false;
        if (node2.Parent.Equals(node1)) return true;
        
        return ContainsNode(node1, node2.Parent);
    }
}