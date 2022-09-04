public interface IAccountRegistration
{
    public bool HasUserWithEmail(string Email);
    public bool IsEmail(string Email);
    public bool Signup( string Email, string Password );
}

public class AccountRegistration: IAccountRegistration
{
    public AccountRegistration()
    {
        if(System.IO.Directory.Exists(System.IO.Path.Combine(
                System.IO.Directory.GetCurrentDirectory(), "users").ToLower()) == false)
        {
            System.IO.Directory.CreateDirectory(System.IO.Path.Combine(
                System.IO.Directory.GetCurrentDirectory(), "users").ToLower());
        }
    }

    public bool HasUserWithEmail(string Email)
    {
        return System.IO.Directory.Exists(
            System.IO.Path.Combine(
                System.IO.Directory.GetCurrentDirectory(), "users", Email).ToLower());
    }

    public bool IsEmail(string Email)
    {
        if (Email.IndexOf("@") != Email.LastIndexOf("@"))
            return false;
        if (Email.IndexOf("@") == -1)
            return false;
        if (Email.IndexOf(".") != Email.LastIndexOf("."))
            return false;
        if (Email.IndexOf(".") == -1)
            return false;
        foreach(char ch in Email.ToLower())
        {
            if ((".@" + "qwertyuiopasdfghjklzxcvbnm" + "qwertyuiopasdfghjklzxcvbnm".ToUpper()).Contains(ch) == false)
                return false;
        }
        return true;
    }

    public bool Signup(string Email, string Password)
    {
        if(HasUserWithEmail(Email)==false){

            System.IO.Directory.CreateDirectory(System.IO.Path.Combine(
                    System.IO.Directory.GetCurrentDirectory(), "users", Email).ToLower());
            System.IO.File.WriteAllText(System.IO.Path.Combine(
                    System.IO.Directory.GetCurrentDirectory(), "users", Email, "password.txt").ToLower(), Password);
            return true;

        }else{
            return false;
        }

    }
}