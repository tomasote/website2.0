using Microsoft.Extensions.Options;

namespace Website2._0
{
    public class MailModel
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Message { get; set; }

        public bool Validate()
        {
            if (string.IsNullOrEmpty(Name)) return false;
            if (string.IsNullOrEmpty(Message)) return false;
            if (!IsValidEmail(Email)) return false;
            return true;
        }
        private bool IsValidEmail(string? email)
        {
            if (string.IsNullOrEmpty(email)) return false;
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; 
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

    }
}
