using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

public interface IUserContext
{
    public ConcurrentDictionary<string, object> GetSession();
    public T Get<T>();
    

}

public class UserContext: IUserContext
{
    private readonly AuthorizationUsers users;
    private readonly ITokenProvider provider;

    public UserContext(AuthorizationUsers users, ITokenProvider provider)
    {
        this.users = users;
        this.provider = provider;
    }

    public ConcurrentDictionary<string, object> GetSession()
        => users.GetSession(provider.Get());


    public IEnumerable<string> GetFunctions()
    {
        return new List<string>()
        {
            "Заявки на оплату","Жалобы","Предложения"
        };
    }

    public T Get<T>()
    {
        var session = GetSession();
        string key = typeof(T).FullName;
        if (session.ContainsKey(key) == false)
        {
            session[key] = typeof(T).GetConstructors().Where(c => c.GetParameters().Count() == 0).First().Invoke(new object[0]);
        }
        return (T)session[key];
    }
}
