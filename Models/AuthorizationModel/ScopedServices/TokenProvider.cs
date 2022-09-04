using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Microsoft.JSInterop;

public interface ITokenProvider
{
    public string Get();
    public Task Set(string token);

}
public class TokenProvider : ITokenProvider
{
    private readonly HttpContext _http;

    public TokenProvider(HttpContext http)
    {
        _http = http;
    }

    public string Get()
    {
        _http.Request.Cookies.TryGetValue("Authorization",out var token); 
        return token;
    }

    public async Task Set(string token)
    {
        _http.Response.Cookies.Append("Authorization",  token);
        await Task.CompletedTask;
    }

  
}