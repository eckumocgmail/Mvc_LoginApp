using ApplicationDb.Entities;

public interface IUserAuthentication
{
    public bool IsSigned();
    public User Authenticate();
    public Role GetRole();
}


public class UserAuthentication: IUserAuthentication
{
    private readonly ITokenProvider _provider;
    private readonly AuthorizationUsers _users;

    public UserAuthentication(AuthorizationUsers users, ITokenProvider provider)
    {
        _provider = provider;
        _users = users;
    }

    public User Authenticate()
    {
        string token = _provider.Get();
        return _users.Take(token);
    }

    public bool IsSigned()
        => Authenticate() != null;

    public Role GetRole()
        => Authenticate().Role;
}