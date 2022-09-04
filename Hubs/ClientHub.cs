using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.SignalR;

using System;
using System.Threading.Tasks;


public class ClientHub : Hub
{
    protected readonly AuthorizationContext _appContext;
    protected readonly IHttpContextAccessor _accessor;

    public IUserLogin _login { get; }

    public ClientHub(
        IUserLogin login, 
        AuthorizationContext appContext,
        IHttpContextAccessor accessor)
    {
        _appContext = appContext;
        _accessor = accessor;
        _login = login;
    }
    public async Task<string> Signin(string username,string password)
    {
        Console.WriteLine($"Signin({username},{password})");
        await Task.CompletedTask;
        return _login.Signin(username, password);
        
    }
    public async Task OnTimeUpdate()
    {
        Console.WriteLine("OnTimeUpdate()");
        await Task.CompletedTask;
    }
    public override async Task OnConnectedAsync()
    {
        await Task.CompletedTask;
        await _appContext.OnConnectedAsync(this.Context.ConnectionId);
    }

    public override async Task OnDisconnectedAsync(Exception? exception)
    {
        await Task.CompletedTask;
        await _appContext.OnDisconnectedAsync(this.Context.ConnectionId);

    }

}