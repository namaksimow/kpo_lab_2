using kpo_lab_2.Models;

namespace kpo_lab_2;

public partial class PerformerCreate : Form
{
    private readonly ApplicationContext _context;
    
    public PerformerCreate(ApplicationContext context)
    {
        _context = context;
        InitializeComponent();
    }
    
    private void btnCancelPerformer_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void btnAddPerformer_Click(object sender, EventArgs e)
    {
        string name = txtBoxName.Text;
        string surname = txtBoxSurname.Text;
        string nickname = txtBoxNickname.Text;

        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(nickname))
        {
            MessageBox.Show(@"Invalid performer data");
            return;
        }

        var performerExist = _context.Performers
            .FirstOrDefault(p => p.Name == name &&
                                 p.Surname == surname &&
                                 p.Nickname == nickname);

        if (performerExist != null)
        {
            MessageBox.Show(@"This performer already exists");
            return;
        }
        
        Performer performer = new Performer(name, surname, nickname);
        
        _context.Performers.Add(performer);
        _context.SaveChanges();
        MainForm.AddPerformerInTree(performer);
        MessageBox.Show(@"Performer added");
    }
}