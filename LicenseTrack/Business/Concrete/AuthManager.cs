using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Hashing;
using Core.Utilities.JWT;
using DataAccess.Concrete;

public class AuthManager : IAuthService
{
    private IUserService _userService;
    private ITokenHelper _tokenHelper;

    public AuthManager(IUserService userService, ITokenHelper tokenHelper)
    {
        _userService = userService;
        _tokenHelper = tokenHelper;
    }

    public AccessToken Login(string email, string password)
    {
        var user = _userService.GetByMail(email);
        if (user == null) return null;

        if (!HashingHelper.VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
            return null;

        var claims = _userService.GetClaims(user);
        var accessToken = _tokenHelper.CreateToken(user, claims);

        return accessToken;
    }

    public bool Register(string firstName, string lastName, string email, string password)
    {
        if (_userService.GetByMail(email) != null)
        {
            return false; 
        }

        byte[] passwordHash, passwordSalt;
        HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);

        var user = new User
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            PasswordHash = passwordHash,
            PasswordSalt = passwordSalt,
            Status = true
        };

        _userService.Add(user);
        using (var context = new LicenseTrackContext())
        {
            var addedUser = context.Users.FirstOrDefault(u => u.Email == email);
            if (addedUser != null)
            {
                context.UserOperationClaims.Add(new UserOperationClaims
                {
                    UserId = addedUser.Id,
                    OperationClaimId = 2 
                });
                context.SaveChanges();
            }
        }
        return true;
    }
}
