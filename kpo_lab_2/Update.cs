using kpo_lab_2.Models;

namespace kpo_lab_2;

public partial class Update : Form
{
    private readonly ApplicationContext _context;
    private string _oldData;
    private string _newData;
    private bool _isCheck;
    
    public Update(ApplicationContext context, string oldData)
    {
        _oldData = oldData;
        _context = context;
        InitializeComponent();
    }

    private void btnPerformerNewDataCheck_Click(object sender, EventArgs e)
    {
        string newNickname = txtBoxPerformerNewNickname.Text;

        if (string.IsNullOrEmpty(newNickname))
        {
            MessageBox.Show(@"invalid new data");
            return;
        }
        
        var performer = _context.Performers.FirstOrDefault(p => p.Nickname == newNickname);

        if (performer != null)
        {
            MessageBox.Show(@"This record already exists");
            return;
        }
        
        MessageBox.Show(@"Suitable data");
        _newData = newNickname;
        _isCheck = true;
    }

    private void btnPerformerNewDataCancel_Click(object sender, EventArgs e)
    {
        Close();
    }


    private void btnPerformerNewDataUpdate_Click(object sender, EventArgs e)
    {
        if (!_isCheck)
        {
            MessageBox.Show(@"Check data before update");
            return;
        }
        
        var performer = _context.Performers.FirstOrDefault(p => p.Nickname == _oldData);
        performer.Nickname = _newData; 

        _context.Performers.Update(performer);
        _context.SaveChanges();

        MainForm.UpdatePerformerInTree(_oldData, performer.Nickname); 

        MessageBox.Show(@"Performer changed");
        _oldData = "";
        _newData = "";
        _isCheck = false;
        Close();
    }
}