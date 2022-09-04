public interface ITokenValidation
{
    public bool IsValid(string token);
}
public class TokenValidation: ITokenValidation
{
    private readonly AuthorizationUsers _users;

    public TokenValidation(AuthorizationUsers users)
    {
        _users = users;
    }

    public bool IsValid(string token) => 
        _users.Has(token);
}
 