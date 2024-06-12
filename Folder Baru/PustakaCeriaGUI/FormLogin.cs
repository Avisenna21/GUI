using Newtonsoft.Json.Linq;
using System.Security.Cryptography;
using System.Text;

namespace PustakaCeriaGUI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void buttonMasuk_Click(object sender, EventArgs e) 
        { 
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (ValidateLogin(username, password))
            {
                MessageBox.Show("Berhasil Masuk!");
                this.Hide();
                MainForm homePage = new MainForm();
                homePage.Show();
            }
            else
            {
                MessageBox.Show("Nama pengguna atau kata sandi salah!");
            }
        }

        private void buttonDaftar_Click(object sender, EventArgs e) 
        {
            FormRegister register = new FormRegister();
            this.Hide();
            register.ShowDialog();
            this.Show();
        }

        private bool ValidateLogin(string username, string password)
        {
            if (File.Exists("users.json"))
            {
                var json = File.ReadAllText("users.json");
                var users = JArray.Parse(json);

                foreach (var user in users)
                {
                    if (user["username"].ToString() == username && VerifyPassword(password, user["password"].ToString()))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool VerifyPassword(string enteredPassword, string storedHashedPassword)
        {
            using (var sha256 = SHA256.Create())
            {
                var enteredPasswordBytes = Encoding.UTF8.GetBytes(enteredPassword);
                var enteredPasswordHash = sha256.ComputeHash(enteredPasswordBytes);
                var enteredPasswordHashString = Convert.ToBase64String(enteredPasswordHash);

                return enteredPasswordHashString == storedHashedPassword;
            }
        }
    }
}
