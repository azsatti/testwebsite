namespace TestWebsite
{
    using System;
    using System.Collections.Generic;
    using Models;

    public class DbInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<AuthenticationContext>
    {
        protected override void Seed(AuthenticationContext context)
        {
            var loginList = new List<LoginModel>
            {
                new LoginModel { AuthCode = "123456", CreatedOn = DateTime.Parse("01-01-2017"), IsActive = false },
                new LoginModel { AuthCode = "abc123", CreatedOn = DateTime.Parse("01-01-2018"), IsActive = true }
            };

            loginList.ForEach(s => context.AuthCodes.Add(s));
            context.SaveChanges();
        }
    }
}