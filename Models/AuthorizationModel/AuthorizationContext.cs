using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks;

public class AuthorizationContext
{
    private readonly AuthorizationUsers _users;
    private readonly AuthorizationServices services;
    private readonly IServiceProvider serviceProvider;

    public AuthorizationContext(
        IServiceProvider serviceProvider,
        AuthorizationUsers users, 

        AuthorizationServices services)
    {
        this._users = users;
        this.services = services;
        this.serviceProvider = serviceProvider;
        this.ImportFromFiles();
    }

    public async Task OnConnectedAsync(string connectionId)
    {      
        await Task.CompletedTask;
    }

 
    public void DoCheck(){
        _users.DoCheck();
    }

    public async Task OnDisconnectedAsync(string connectionId)
    {
        await Task.CompletedTask;
    }

    public void ImportFromFiles()
    {
        using (var authdb=new AuthDbContext())
        {
            foreach (var dir in System.IO.Directory.GetDirectories(System.IO.Path.Combine(
                System.IO.Directory.GetCurrentDirectory(), "users").ToLower()))
            {
                authdb.CreateUserAccount(dir.Substring(dir.LastIndexOf("\\")+1), "");
            }
        }
    }
}