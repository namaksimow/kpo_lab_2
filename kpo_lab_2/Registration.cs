using System.Security.Cryptography;
using System.Text;
using kpo_lab_2.DataBase.Models;
using ApplicationContext = kpo_lab_2.DataBase.ApplicationContext;

namespace kpo_lab_2;

public partial class Registration : Form
{
    private readonly ApplicationContext _context;
    
    public Registration(ApplicationContext context)
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
    
    private void btbRegistrationRegistration_Click(object sender, EventArgs e)
    {
        string login = txtBoxRegistrationUsername.Text;
        string password = txtBoxRegistrationPassword.Text;

        if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
        {
            MessageBox.Show("Please enter login and password");
            return;
        }

        var userExist = _context.Users.FirstOrDefault(u => u.Name == login);

        if (userExist != null)
        {
            MessageBox.Show("User already exist");
            return;
        }
        
        string passwordHash = GetPasswordHash(password);
        User user = new User(login, passwordHash);
        _context.Users.Add(user);
        _context.SaveChanges();
        MessageBox.Show("Registration success");
        Close();
    }
}