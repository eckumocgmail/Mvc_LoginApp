using System;
using ApplicationDb.Entities;

public interface IUserLogin
{
    public string Signin(string Email, string Password);
    public User GetUserByEmail(string email);
    //public string GetUserPasswordByEmail(string email);
}
 
public class UserLogin : IUserLogin
{
    private readonly AuthorizationUsers _users;

    public UserLogin(AuthorizationUsers users)
    {
        _users = users;
        if(System.IO.Directory.Exists(System.IO.Path.Combine(
                System.IO.Directory.GetCurrentDirectory(), "users").ToLower()) == false)
        {
            System.IO.Directory.CreateDirectory(System.IO.Path.Combine(
                System.IO.Directory.GetCurrentDirectory(), "users").ToLower());
        }        
    }

    public string Signin(string Email, string Password)
    {
        try
        {
            if (System.IO.File.Exists(System.IO.Path.Combine(
                System.IO.Directory.GetCurrentDirectory(), "users", Email, "password.txt").ToLower()) == false)
            {
                return null;
            }
            else
            {
                if (Password == System.IO.File.ReadAllText(System.IO.Path.Combine(
                    System.IO.Directory.GetCurrentDirectory(), "users", Email, "password.txt").ToLower()))
                {
                    User user = this.GetUserByEmail(Email);
                    string token = _users.Put(user);
                    return token;
                }
                else
                {
                    return null;
                }
            }

        }catch (Exception ex)
        {
            return null;
        }
    }

    public User GetUserByEmail(string email)
    {
        var user = new User();
        user.Account = new UserAccount();
        user.Account.Email = email;
     
        return user;
    }

 
    
}