using System.ComponentModel.DataAnnotations;

namespace PasswordManager
{

    internal class Accounts
    {
        [Key]
        public int AccountId { get; set; }
        public string Description { get; set; }
        public string Username { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public Accounts()
        {
            
        }

        public Accounts(int AccountId, string Description, string Username, string Mail, string Password,int UserId)
        {
            this.AccountId = AccountId;
            this.Description = Description;
            this.Username = Username;
            this.Mail = Mail;
            this.Password = Password;
            this.UserId = UserId;
        }
    }
}
