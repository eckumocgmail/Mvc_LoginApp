using System.Collections.Generic;

/// <summary>
/// Параметры жизненого цикла обьектов сеанса
/// </summary>
public class AuthorizationOptions 
{
    /// <summary>
    /// Роль пользователя по умолчанию,
    /// присваивается пользователям после 
    /// проведеня процедуры регистрации
    /// </summary>
    public string PublicRole { get; set; } = "/Customers";
    public string PublicGroup { get; set; } = "/Customers";
    public string UserHome { get; set; } = "/User/Home/Index";
    public string ApplicationUrl { get; set; }
    public long SessionTimeout { get; set; }
    public int KeyLength { get; set; }
    public string UserCookie { get; set; }
    public string ServiceCookie { get; set; }
    public int CheckTimeout { get; set; }
        
    public AuthorizationOptions()
    {
        this.SessionTimeout = 1000 * 60*60;
        this.KeyLength = 32;
        this.UserCookie = "UserKey";
        this.ServiceCookie = "ServiceKey";
        this.CheckTimeout = 1000;
        this.PublicRole = "Reader";
        this.PublicGroup = "Reader";
        this.ApplicationUrl = "https://localhost:44392";
    }
    public List<ExtAuthConfiguration> Providers { get; set; } = new List<ExtAuthConfiguration>() 
    { 
        new ExtAuthConfiguration()
        {
            Scheme="Basic-Authentication",
            Provider = new Service()
            {
                URL = "https://localhost:5001"
            }
        }
    };
    public class ExtAuthConfiguration
    {
        public string Scheme { get; set; }
        public Service Provider { get; set; }
        public string ClientId { get; set; } // ид-приложения
        public byte[] ClientSecret { get; set; }
        public string SignAlgorithm { get; set; } // подписи
        public string HashAngorithm { get; set; } // хэширование
        public string Authority { get; set; } // УДЦ
    }
    public static IReadOnlyList<string> Options { get; } = new List<string>()
    {       
        "Basic-Authentication",
        "Identity"
    };
}