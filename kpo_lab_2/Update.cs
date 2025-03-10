using kpo_lab_2.Models;

namespace kpo_lab_2;

public partial class Update : Form
{
    private readonly ApplicationContext _context;
    private string _oldData;
    private string _newData;
    
    public Update(ApplicationContext context, string oldData)
    {
        _oldData = oldData;
        _context = context;
        InitializeComponent();
    }

    private void btnNewDataCancel_Click(object sender, EventArgs e)
    {
        Close();
    }


    private void btnNewDataUpdate_Click(object sender, EventArgs e)
    {
        _newData = txtBoxNewData.Text;
        var isPerformer = _context.Performers.FirstOrDefault(p => p.Nickname == _oldData);
        if (isPerformer != null)
        {
            isPerformer.Nickname = _newData; 
            _context.Performers.Update(isPerformer);
            _context.SaveChanges();    
            MainForm.UpdatePerformerInTree(_oldData, isPerformer.Nickname);
            MessageBox.Show(@"Performer changed");
        }

        var isAlbum = _context.Albums.FirstOrDefault(a => a.Title == _oldData);
        if (isAlbum != null)
        {
            isAlbum.Title = _newData;
            MainForm.UpdateAlbumInTree(_oldData, isAlbum.Title);
            _context.Albums.Update(isAlbum);
            Console.WriteLine(isAlbum.Title);
            _context.SaveChanges();
            MessageBox.Show(@"Album changed");
        }
        
        _oldData = "";
        _newData = "";
        Close();
    }
}