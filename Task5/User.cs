namespace Domain;
public class User
{
    private int userId;
    private string username;
    private string password;
    public User( int _userId, string _username, string _password )
    {
        userId = _userId;
        username = _username;
        password = _password;
    }
    public void GetUserInfo()
    {
        System.Console.WriteLine($"{userId}, {username}, {password}");
    }
}