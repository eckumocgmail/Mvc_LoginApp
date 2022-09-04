 
using ApplicationDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using static pickpoint_delivery_service.CustomerGenerator;

namespace LibsDb { }

public partial class AuthDbContext : DbContext
{
    public static string DefaultConnectionString = "app";
      //  "Server=127.0.0.1;" +        
    //    $"Database=SpbPublicLibs;" +
    //    "user id=sa;" +
    //    "pwd=Gye*34FRtw;" +        
     //   "MultipleActiveResultSets=True";

    public virtual DbSet<Message> Messages { get; set; }
    public virtual DbSet<Account> Accounts { get; set; }
    public virtual DbSet<File> StoredImages { get; set; }
    
    public void Execute(string sql)
    {
        throw new NotImplementedException();
    }
    
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Person> Persons { get; set; }

    public void CreateUserAccount(string Email, string Password)
    {
        Account acc = null;
        this.Accounts.Add(acc=new Account() { 
            Email = Email,
            Password = Password
        });
        this.SaveChanges();
        this.Users.Add(new User() {
            Account = acc
        });
    }

    public virtual DbSet<Settings> Settings { get; set; }
    public virtual DbSet<Role> Roles { get; set; }
    public virtual DbSet<Group> Groups { get; set; }

    public object List(Type entity)
    {
        return GetType().GetProperties().Where(p => p.PropertyType == typeof(DbSet<>).MakeGenericType(entity)).First();
    }

    public virtual DbSet<UserGroups> UserGroups { get; set; }
 
    public virtual DbSet<Resource> Resources { get; set; }
    public virtual DbSet<Calendar> Calendars { get; set; }
    public virtual DbSet<News> News { get; set; }
    public virtual DbSet<Service> Services { get; set; }



    // факты 
    public virtual DbSet<Login> LoginFacts { get; set; }

    public AuthDbContext( ) : base() { }

    public AuthDbContext(
            DbContextOptions<AuthDbContext> options) : base(options) { }


    /// <summary>
    /// Настройка конфигурации контекста данных
    /// </summary>
    /// <param name="optionsBuilder"></param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        System.Console.WriteLine($"Установка свойств контекста данных");
        
        if (!optionsBuilder.IsConfigured)
        {
            System.Console.WriteLine($"\t {DefaultConnectionString}");
            //System.IO.File.Create(Naming.ToCapitalStyle(GetType().Name) + ".db");
            optionsBuilder.UseInMemoryDatabase("DataSource="+Naming.ToCapitalStyle(GetType().Name)+".db");



        }
    }

    public new void SaveChanges()
    {
        base.SaveChanges();
    }

   

    public IEnumerable<INavigation> GetNavigationPropertiesForType(Type type)
    {
        throw new NotImplementedException();
    }
}

