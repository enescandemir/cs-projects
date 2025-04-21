using Core.Entities.Concrete;
using Core.Utilities.Hashing;
using DataAccess.Concrete;

namespace UserAdder
{
    internal class Program
    {
        private void btnAddTestUser_Click(object sender, EventArgs e)
        {
            var context = new LicenseTrackContext();

            string password = "12345";
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);

            var user = new User
            {
                FirstName = "Admin",
                LastName = "User",
                Email = "admin@example.com",
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };

            context.Users.Add(user);
            context.SaveChanges();
        }

    }
}
