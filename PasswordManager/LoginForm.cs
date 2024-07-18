using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string input_username = loginUsername.Text;
            string input_password = loginPasswd.Text;

            using (var context = new PasswordManagerContext())
            {
                var user = context.Users.FirstOrDefault(u => u.LoginUsername == input_username);
                if (user != null)
                {
                    string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                    string folderPath = Path.Combine(appDataPath, "PasswordManager");
                    string filePath = Path.Combine(folderPath, $"{user.UserId}.txt");

                    if (!File.Exists(filePath))
                    {
                        MessageBox.Show("Encryption key file not found.");
                        return;
                    }

                    try
                    {
                        string encryptedKey = File.ReadAllText(filePath);

                        string decryptedKey = Encrypting.Decrypt(encryptedKey, input_password);

                        string decryptedPassword = Encrypting.Decrypt(user.LoginPassword, decryptedKey);

                        if (decryptedPassword == input_password)
                        {
                            MainForm form1 = new MainForm(user, decryptedKey);
                            form1.Show();
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect password.");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Incorrect password.");

                    }
                }
                else
                {
                    MessageBox.Show("The specified user does not exist or you entered incorrect information.");
                }
            }

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string input_username = loginUsername.Text;
            string input_password = loginPasswd.Text;

            using (var context = new PasswordManagerContext())
            {
                if (context.Users.Any(u => u.LoginUsername == input_username))
                {
                    MessageBox.Show("Username already exists");
                }
                else
                {
                    string encryptionKey = Encrypting.GenerateKey();

                    string encryptedKey = Encrypting.Encrypt(encryptionKey, input_password);

                    string encryptedPassword = Encrypting.Encrypt(input_password, encryptionKey);

                    var newUser = new User
                    {
                        LoginUsername = input_username,
                        LoginPassword = encryptedPassword,
                    };
                    context.Users.Add(newUser);
                    context.SaveChanges();

                    string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

                    string folderPath = Path.Combine(appDataPath, "PasswordManager");

                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }
                    string filePath = Path.Combine(folderPath, $"{newUser.UserId}.txt");
                    File.WriteAllText(filePath, encryptedKey);
                    MessageBox.Show("User registered successfully!");

                }
            }

        }

        private void Activate_Buttons(object sender, EventArgs e)
        {
            if (loginPasswd.Text.Length != 0 && loginUsername.Text.Length != 0)
            {
                btnCreate.Enabled = true;
                btnLogin.Enabled = true;

            }
            else
            {
                btnCreate.Enabled = false;
                btnLogin.Enabled = false;
            }
        }
    }
}
