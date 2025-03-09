namespace kpo_lab_2;

public partial class SongCreate : Form
{
    private readonly ApplicationContext _context;
    
    public SongCreate(ApplicationContext context)
    {
        _context = context;
        InitializeComponent();
    }
}