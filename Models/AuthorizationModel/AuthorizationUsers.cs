using ApplicationDb.Entities;

using Microsoft.Extensions.Logging;

public interface IAuthorizationUsers
{
    public bool ValidateUserToken( string token );
}

public class AuthorizationUsers : AuthorizationCollection<User>, IAuthorizationUsers
{
    public AuthorizationUsers( ILogger<AuthorizationCollection<User>> logger, AuthorizationOptions options) : base(logger, options)
    {
    }

    public bool ValidateUserToken(string token)
        => this._memory.ContainsKey(token);
}