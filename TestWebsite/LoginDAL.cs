namespace TestWebsite
{
    using System.Data.Entity;

    public class LoginDAL : DbContext
    {
        public string GetAuthCode()
        {
            return "123456";
        }
    }
}