namespace TestWebsite
{
    using System.Linq;

    public class LoginDal
    {
        private readonly AuthenticationContext db = new AuthenticationContext();

        public string GetAuthCode()
        {
            var activeRecord = db.AuthCodes.OrderByDescending(x => x.CreatedOn).Single(x => x.IsActive);
            return activeRecord.AuthCode;
        }
    }
}