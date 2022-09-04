using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using pickpoint_delivery_service;

using ReCaptcha;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using streaming;
using static pickpoint_delivery_service.CustomerGenerator;
using System.Reflection;
using System.Diagnostics;
using Mvc_LoginApp;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Routing;

public static class OpenIDConnect
{
    public static void AddOpenID(this IServiceCollection services, Action<object> todo)
    {

    }
}

public class MvcLoginAppStartup
{

    private static readonly ILogger<MvcLoginAppStartup> _logger = LoggerFactory
            .Create(options => options.AddConsole())
            .CreateLogger<MvcLoginAppStartup>();
    public IConfiguration Configuration { get; }

    public MvcLoginAppStartup(IConfiguration configuration)
    {
        Configuration = configuration;
        
        //var client = CreateHttpClient("https://localhost:5001", Assembly.GetExecutingAssembly());
        //Console.WriteLine(client);
    }


    public void ConfigureServices(IServiceCollection services)
        => ConfigureMvcLoginAppServicesServices(Configuration, services);

    public static MvcLoginAppInfo ConfigureMvcLoginAppInfo(IConfiguration Configuration, IServiceCollection services)
    {
        try
        {
            string Username = Configuration.GetSection("USERNAME").Get<string>();
            string Userdomain = Configuration.GetSection("USERDOMAIN").Get<string>();
            string Computername = Configuration.GetSection("COMPUTERNAME").Get<string>();
            List<string> Urls =
                Configuration.GetSection("URLS").Get<string>().Split(";").ToList();
            List<string> Libs =
                Configuration.GetSection("Libs").Get<List<string>>();
            string BaseUrl = Urls.Any(url => url.ToLower().StartsWith("https:")) ?
                Urls.First(url => url.ToLower().StartsWith("https:")) :
                 Urls.First(url => url.ToLower().StartsWith("http:"));

            return new MvcLoginAppInfo()
            {
                Url = BaseUrl,
                User = Username,
                Domain = Userdomain,
                Computer = Computername,
                Urls = Urls,
                Libs = Libs
            };
        }
        catch (Exception ex)
        {
            Console.WriteLine("ConfigureMvcLoginAppInfo(.,..) завершился с ошибкой " + ex.Message);
            throw;
        }
    }

    public static void ConfigureMvcLoginAppBackgrounndServices(HostBuilderContext context, IServiceCollection services)
    {

        services.AddSingleton<AuthorizationServices>();
        services.AddSingleton<AuthorizationUsers>();
        services.AddSingleton<AuthorizationContext>();
        services.AddSingleton(typeof(AuthorizationOptions), sp => {
            var options = context.Configuration.GetSection(nameof(AuthorizationOptions)).Get<AuthorizationOptions>();
            return options == null ? new AuthorizationOptions() : options;
        });
        services.AddHostedService<AuthorizationBackground>();
    }

    public static void ConfigureMvcLoginAppServicesServices(IConfiguration Configuration, IServiceCollection services)
    {

        var Info = ConfigureMvcLoginAppInfo(Configuration, services);
        var Libs = Info.Libs;
        services.AddSingleton(typeof(MvcLoginAppInfo),
           sp => Info);
        var mvcBuilder = services.AddControllersWithViews().AddRazorRuntimeCompilation();
        if (Libs != null)
        {
            foreach (string dir in Libs)
            {
                foreach (string file in System.IO.Directory.GetFiles(dir))
                {
                    try
                    {
                        var dll = Assembly.LoadFile(file);
                        dll.GetTypes().Where(t => t.GetMethods().Any(m => m.Name == "Main")).First()
                            .GetMethod("Main").Invoke(Process.GetCurrentProcess(), new string[] {
                            Process.GetCurrentProcess().ProcessName
                            });
                        mvcBuilder
                            .AddApplicationPart(dll)
                            .AddRazorRuntimeCompilation();
                        _logger.LogInformation("Подключение " +
                            $"динамической библиотеки классов из файла: {file} завершено");

                        var httpBuild = CreateHttpClient(Info.Url, dll);
                    }
                    catch (Exception ex)
                    {
                        _logger.LogError("Исключение при подключении " +
                            $"динамической библиотеки классов из файла: {file}", ex);
                    }
                }
            }
        }

            
        services.AddHttpClient();
        services.AddHttpContextAccessor();
        services.AddRazorPages().AddRazorRuntimeCompilation();            
        /*services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
        {
            options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
            options.SlidingExpiration = true;
            options.AccessDeniedPath = "/Home/Forbidden/";
        });*/
        services.AddDbContext<AppDbContext>( options => options.UseInMemoryDatabase(typeof(AppDbContext).Name) );
        services.AddDbContext<ResourcesDbContext>( options => options.UseInMemoryDatabase(typeof(ResourcesDbContext).Name) );
        services.AddDbContext<AuthDbContext>( options => options.UseInMemoryDatabase("Data Source="+""+  Naming.ToCapitalStyle(nameof(AuthDbContext)) + ".db") );
            
        services.AddScoped(typeof(IRequestCookieCollection), sp=> sp.GetService<IHttpContextAccessor>().HttpContext.Request.Cookies);
        services.AddScoped(typeof(HttpRequest), sp=> sp.GetService<IHttpContextAccessor>().HttpContext.Request);
        services.AddScoped(typeof(HttpContext), sp=> sp.GetService<IHttpContextAccessor>().HttpContext);
        services.AddTransient<IAccountRegistration, AccountRegistration>();
        services.AddTransient<ITokenProvider, TokenProvider>();
        services.AddTransient<ITokenValidation, TokenValidation>();
        services.AddTransient<IUserAuthentication, UserAuthentication>();
        services.AddTransient<IUserLogin, UserLogin>();
        services.AddTransient<IUserContext, UserContext>();
        services.AddTransient<IUserLogout, UserLogout>();
        services.AddTransient<IStoredImageRepository, StoredImageRepository>();

        services.AddRecaptcha();
        services.AddSignalR();
        DeliveryDbContext.ConfigureDeliveryServices(services, Configuration);
    }

    private static string CreateHttpClient(string baseUrl, Assembly dll)
    {
        string httpClientClass = "";
        foreach(var ctrl in dll.GetTypes().Where(ctrl => ctrl.Name.EndsWith("Controller")))
        {
            foreach(var met in ctrl.GetMethods().Where(m => m.IsPublic))
            {
                string paramstr = "";
                foreach(var par in met.GetParameters())
                {
                    paramstr += $"&{par.Name}={par.ParameterType.Name}";
                }
                paramstr = "?"+paramstr.Substring(1);
                string url = $"GET {baseUrl}/{ctrl.Name.Replace("Controller", "")}/{met.Name}"+paramstr;
                httpClientClass += url + "\n";
            }
        }
        return httpClientClass;
    }



    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseDeveloperExceptionPage();
 
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthentication();
        app.UseAuthorization();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapRazorPages();
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{area=}/{controller=Home}/{action=Index}/{id?}");
            MapLoginClients(endpoints);
            endpoints.MapFallbackToController("NotFound", "Home");
        });
    }

    public static void MapLoginClients(IEndpointRouteBuilder endpoints)
    {
        endpoints.MapHub<ClientHub>("/hubs/client");
        endpoints.MapHub<ClientVideoHub>("/hubs/client-video");
    }
} 