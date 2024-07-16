using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PasswordManager
{
    public partial class MainForm : Form
    {

        int CurrentId;
        private List<Accounts> list_of_accounts = new List<Accounts>();
        private List<Accounts> loaded_accounts = new List<Accounts>();
        private bool passwordVisibility = false;
        private string userKey;
        private User loggedUser;
        public MainForm(User user, string encryptKey)
        {
            InitializeComponent();
            loggedUser = user;
            userKey = encryptKey;
            loadData();
            InitializeTooltips();
            listView1.SelectedIndexChanged += ListView1_SelectedIndexChanged;
        }

        private void loadData()
        {
            CurrentId = 0;
            list_of_accounts.Clear();
            loaded_accounts.Clear();
            using (var context = new PasswordManagerContext())
            {
                foreach (var account in context.Accounts)
                {
                    if (account.UserId == loggedUser.UserId)
                    {
                        account.Password = Encrypting.Decrypt(account.Password,userKey);
                        list_of_accounts.Add(account);
                    }
                    else
                    {
                        loaded_accounts.Add(account);

                    }

                }
            }
            update_ListView();

        }

        private void saveData()
        {
            using (var context = new PasswordManagerContext())
            {

                var allAccounts = context.Accounts.ToList();
                context.Accounts.RemoveRange(allAccounts);
                context.Database.ExecuteSqlCommand("DBCC CHECKIDENT ('Accounts', RESEED, 0);");
                foreach (var account in list_of_accounts)
                {
                    account.Password = Encrypting.Encrypt(account.Password,userKey);
                    context.Accounts.Add(account);
                }
                foreach (var account in loaded_accounts)
                {
                    context.Accounts.Add(account);
                }
                context.SaveChanges();
            }
            loadData();

        }




        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEye.Visible = !btnEye.Visible;
            btnUp.Visible = !btnUp.Visible;
            btnDown.Visible = !btnDown.Visible;
            btnEdit.Visible = !btnEdit.Visible;
            btnDelete.Visible = !btnDelete.Visible;
            btnCopy.Visible = !btnCopy.Visible;

            if (listView1.SelectedItems.Count > 0)
            {
                var selectedAccount = listView1.SelectedItems[0];
                var account = (Accounts)selectedAccount.Tag;
                passwordVisibility = selectedAccount.SubItems[4].Text != account.Password ? false : true;
                btnEye.Image = passwordVisibility ? Properties.Resources.eye_visible : Properties.Resources.eye_off;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnEye.Visible = false;
            btnUp.Visible = false;
            btnDown.Visible = false;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            btnCopy.Visible = false;

            CurrentId = list_of_accounts.Count + loaded_accounts.Count + 1;
            Accounts account = new Accounts(CurrentId, textDescription.Text, textUsername.Text, textMail.Text, textPassword.Text, loggedUser.UserId);
            list_of_accounts.Add(account);
            update_ListView();
        }

        private string MaskPassword(string password)
        {
            return new string('*', 10);
        }

        private void update_ListView()
        {
            listView1.Items.Clear();
            int accId = 0;
            foreach (var acc in list_of_accounts)
            {
                accId++;
                var element = new ListViewItem(accId.ToString());
                element.SubItems.Add(acc.Description);
                element.SubItems.Add(acc.Username);
                element.SubItems.Add(acc.Mail);
                element.SubItems.Add(MaskPassword(acc.Password));
                element.Tag = acc;
                listView1.Items.Add(element);
                element.Font = new Font(element.Font, FontStyle.Regular);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            var selectedAccount = listView1.SelectedItems[0];
            list_of_accounts.Remove((Accounts)selectedAccount.Tag);
            listView1.Items.Remove(selectedAccount);
            update_ListView();
            MessageBox.Show("Account deleted!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEye.Enabled = false;
            btnUp.Enabled = false;
            btnDown.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Visible = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnCopy.Enabled = false;
            btnSaveData.Enabled = false;

            var selectedAccount = listView1.SelectedItems[0];
            editDescription.Text = list_of_accounts[selectedAccount.Index].Description;
            editUsername.Text = list_of_accounts[selectedAccount.Index].Username;
            editMail.Text = list_of_accounts[selectedAccount.Index].Mail;
            editPassword.Text = list_of_accounts[selectedAccount.Index].Password;
        }

        private void btnConfirmEdit_Click(object sender, EventArgs e)
        {
            btnEye.Enabled = true;
            btnUp.Enabled = true;
            btnDown.Enabled = true;
            groupBox1.Enabled = true;
            groupBox2.Visible = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnCopy.Enabled = true;
            btnCopy.Visible = false;
            btnEye.Visible = false;
            btnUp.Visible = false;
            btnDown.Visible = false;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            btnSaveData.Enabled = true;

            var selectedAccount = listView1.SelectedItems[0];
            list_of_accounts[selectedAccount.Index].Description = editDescription.Text;
            list_of_accounts[selectedAccount.Index].Username = editUsername.Text;
            list_of_accounts[selectedAccount.Index].Mail = editMail.Text;
            list_of_accounts[selectedAccount.Index].Password = editPassword.Text;
            update_ListView();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems[0].Index > 0)
            {
                moveItems(1);
                ListView1_SelectedIndexChanged(sender, e);
            }
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems[0].Index < listView1.Items.Count - 1)
            {
                moveItems(-1);
                ListView1_SelectedIndexChanged(sender, e);

            }
        }

        private void moveItems(int direction)
        {
            var selectedAccount = listView1.SelectedItems[0];
            int selectedIndex = selectedAccount.Index;
            Accounts temp;
            int temp2;
            if (list_of_accounts[selectedIndex].AccountId > list_of_accounts[selectedIndex - direction].AccountId ||
                list_of_accounts[selectedIndex].AccountId < list_of_accounts[selectedIndex - direction].AccountId)
            {
                temp = list_of_accounts[selectedAccount.Index];
                list_of_accounts[selectedIndex] = list_of_accounts[selectedIndex - direction];
                list_of_accounts[selectedIndex - direction] = temp;

                temp2 = list_of_accounts[selectedIndex].AccountId;
                list_of_accounts[selectedIndex].AccountId = list_of_accounts[selectedIndex - direction].AccountId;
                list_of_accounts[selectedIndex - direction].AccountId = temp2;
                update_ListView();
                listView1.Items[selectedIndex - direction].Selected = true;

            }
        }


        private void btnEye_Click(object sender, EventArgs e)
        {
            var selectedAccount = listView1.SelectedItems[0];
            var account = (Accounts)selectedAccount.Tag;

            passwordVisibility = !passwordVisibility;

            selectedAccount.SubItems[4].Text = passwordVisibility ? account.Password : MaskPassword(account.Password);

            btnEye.Image = passwordVisibility ? Properties.Resources.eye_visible : Properties.Resources.eye_off;

        }

        private void InitializeTooltips()
        {
            toolTip1 = new ToolTip();
            toolTip1.SetToolTip(btnCopy, "Copy the password to the clipboard");
            toolTip1.SetToolTip(btnAdd, "Add new entry");
            toolTip1.SetToolTip(btnDelete, "Delete the selected entry");
            toolTip1.SetToolTip(btnEdit, "Edit the selected entry");
            toolTip1.SetToolTip(btnEye, "Show password");
            toolTip1.SetToolTip(btnUp, "Move the selected entry up");
            toolTip1.SetToolTip(btnDown, "Move the selected entry down");
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            var selectedAccount = listView1.SelectedItems[0];
            int selectedIndex = selectedAccount.Index;
            Clipboard.SetText(list_of_accounts[selectedIndex].Password);
            MessageBox.Show("Password copied!");
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            saveData();

            //Checking if any of functional buttons (in this case btnEdit) is currently visible
            //to avoid errors while using them
            if (btnEdit.Visible == true) //if true then change visibility status to false by using other function
            {
                ListView1_SelectedIndexChanged(sender, e);
            }
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void activate_confirmEditButton(object sender, EventArgs e)
        {
            btnConfirmEdit.Enabled = editPassword.Text.Length != 0 ? true : false;
        }
        private void activate_addButton(object sender, EventArgs e)
        {
            btnAdd.Enabled = textPassword.Text.Length != 0 ? true : false;
        }
    }
}
