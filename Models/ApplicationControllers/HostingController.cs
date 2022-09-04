using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;


public class AppContext: ApplicationDb.Types.ActiveObject
{
  
    public int Port { get; set; }
    public Process Process { get; set; }    
    public CancellationToken Token { get; set; }
    public int ProcessID { get; set; }
}
public interface IHosting
{
    public Task<IEnumerable<string>> ListApps( );
    public Task<IEnumerable<AppContext>> ListHosting();
    public Task<AppContext> StartApp(string Application, int Port);

}
public class HostingService: AuthorizationCollection<AppContext>
{
    public HostingService(
        ILogger<AuthorizationCollection<AppContext>> logger,
        AuthorizationOptions options) : base(logger, options)
    {
    }

    public static string ROOT = @"D:\Projects";

    public async Task<IEnumerable<string>> ListApps()
    {
        await Task.CompletedTask;
        return System.IO.Directory.GetDirectories(ROOT);
    }

    public async Task<IEnumerable<AppContext>> ListHosting()
    {
        await Task.CompletedTask;
        return this.GetAll();        
    }

    public async Task<AppContext> StartApp(string Application, int Port, string Username, string Password)
    {
        await Task.CompletedTask;
        Process process = Process.Start(new ProcessStartInfo($"{ROOT.Substring(0,2)} && cd \""+$"{Path.Combine(ROOT, Application)}"+"\" && dotnet run")
        {
            UseShellExecute = true,
            RedirectStandardOutput = true,
            CreateNoWindow = false,
            UserName = Username,
            PasswordInClearText = Password
        });
        AppContext appContext = new AppContext()
        {
            LastActive = DateTimeOffset.Now.ToUnixTimeMilliseconds(),
            IsActive = true,
            ProcessID = process.Id
        };

        var token = this.Put(appContext);       
        appContext.SecretKey = token;
        return appContext;
    }    
}
public class HostingController: Controller
{




}
 