public interface IUserLogout
{

    public bool Signout();


}

public class UserLogout : IUserLogout
{
    private readonly ITokenProvider _provider;

    public AuthorizationUsers _users { get; }

    public UserLogout(AuthorizationUsers users, ITokenProvider provider)
    {
        _provider = provider;
        _users = users;
    }

    public bool Signout()
    {
        string token = _provider.Get();
        if (_users.Has(token))
        {
            _users.Remove(token);
            return true;
        }
        else
        {
            return false;
        }
        
    }
}