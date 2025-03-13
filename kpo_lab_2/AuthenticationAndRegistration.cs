using System.Security.Cryptography;
using System.Text;
using ApplicationContext = kpo_lab_2.DataBase.ApplicationContext;

namespace kpo_lab_2;

public partial class AuthenticationAndRegistration : Form
{
    private readonly ApplicationContext _context;
    
    public AuthenticationAndRegistration(ApplicationContext context)
    {
        _context = context;
        InitializeComponent();
    }

    private string GetPasswordHash(string password)
    {
        using (SHA1 sha1Hash = SHA1.Create())
        {
            byte[] sourceBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = sha1Hash.ComputeHash(sourceBytes);
            string hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
            return hash;
        }
    }

    private void btnAuthAndRegLogin_Click(object sender, EventArgs e)
    {
        string login = txtBoxAuthAndRegLogin.Text;
        string password = txtBoxAuthAndRegPassword.Text;

        if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show("Please enter login and password");
            return;
        }
        
        string passwordHash = GetPasswordHash(password);
        var user = _context.Users.FirstOrDefault(u => u.Name == login);

        if (user == null)
        {
            MessageBox.Show(@"User not found");
            return;
        }

        if (user.Password != passwordHash)
        {
            MessageBox.Show(@"Wrong password");
            return;
        }

        DialogResult = DialogResult.OK;
        Close();
    }

    private void btnAuthAndRegRegistration_Click(object sender, EventArgs e)
    {
        Registration registration = new Registration(_context);
        registration.Show();
    }
}