using System.ComponentModel;
using kpo_lab_2.Models;

namespace kpo_lab_2;

public partial class MainForm : Form
{
    private readonly ApplicationContext _context;
    
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
                node.ContextMenuStrip = performerContextMenuStrip;
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

    private void PerformerContextMenuItemCreate(object sender, EventArgs e)
    {
        if (tvData.SelectedNode == null)
        {
            return;
        }
        
        PerformerCreate createForm = new PerformerCreate(_context);
        createForm.Show();
    }

    private void PerformerContextMenuItemUpdate(object sender, EventArgs e)
    {
        if (tvData.SelectedNode == null)
        {
            return;
        }

        string performerNickname = tvData.SelectedNode.Text;

        PerformerUpdate updateForm = new PerformerUpdate(_context, performerNickname);
        updateForm.Show();
    }

    private void PerformerContextMenuItemDelete(object sender, EventArgs e)
    {
        if (tvData.SelectedNode == null)
        {
            return;
        }

        string nickname = tvData.SelectedNode.Text;
        Performer? performer = _context.Performers.FirstOrDefault(element => element.Nickname == nickname);
        _context.Performers.Remove(performer);
        _context.SaveChanges();
        
        RemovePerformerFromTree(performer);
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
            newNode.ContextMenuStrip = performerContextMenuStrip;
            tvData.Nodes.Add(newNode);
        }
    }
    
    public static void UpdatePerformerInTree(Performer performer)
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
            newNode.ContextMenuStrip = performerContextMenuStrip;
            tvData.Nodes.Add(newNode);
        }
    }
}