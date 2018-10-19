namespace TestWebsite
{
    using System;

    public class Authenticator
    {
        public bool Authenticate(string authCode)
        {
            var loginDal = new LoginDal();
            var dbCode = loginDal.GetAuthCode();

            return authCode.Equals(dbCode, StringComparison.OrdinalIgnoreCase);
        }
    }
}