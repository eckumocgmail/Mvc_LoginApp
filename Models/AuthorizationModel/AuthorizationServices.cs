using ApplicationDb.Entities;

using Microsoft.Extensions.Logging;

using System.Collections.Generic;
using System.Threading.Tasks;

public interface IAuthorizationServices
{
    /// <summary>
    /// Сведения о экземляре службы, к котороый выполняется запрос/
    /// т.е. Service==localhost
    /// </summary>    
    Service GetServiceLocator();

    /// <summary>
    /// Сведения о экземляре службы, к котороый выполняется запрос/
    /// т.е. Service==localhost
    /// </summary>    
    IEnumerable<Service> GetProviders();

    /// <summary>
    /// Описатели услуг
    /// </summary>    
    IDictionary<Service, object> Discovery();


    /// <summary>
    /// На указанный сервис передаётся запрос с адресом 
    /// для получения обратного сообщения, который будет действителен в течении
    /// заданного диапазона
    /// </summary>
    /// <param name="service"></param>
    /// <param name="returlUrl"></param>
    /// <param name="timeout"></param>
    /// <returns></returns>
    Task<object> Request(Service service, string returlUrl, long timeout);
}

public class AuthorizationServices : AuthorizationCollection<Service>, IAuthorizationServices
{
    private List<string> URLS = new List<string>();
    private AuthorizationOptions _options{get;set;}
    public AuthorizationServices(
        ILogger<AuthorizationCollection<Service>> logger, 
        AuthorizationOptions options) : base(logger, options)
    {
        this._options = options;


    }

    public Service GetServiceLocator()
    {
        throw new System.NotImplementedException();
    }

    public IEnumerable<Service> GetProviders()
    {
        throw new System.NotImplementedException();
    }

    public IDictionary<Service, object> Discovery()
    {
        throw new System.NotImplementedException();
    }

    public Task<object> Request(Service service, string returlUrl, long timeout)
    {
        throw new System.NotImplementedException();
    }
}