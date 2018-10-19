namespace TestWebsite.Models
{
    using System;

    public class LoginModel
    {
        public int ID { get; set; }

        public string AuthCode { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}