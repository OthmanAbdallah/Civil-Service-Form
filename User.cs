using System;

public class User
{
    public string National_Number
    {
        private set;
        get;

    }
    public string Password
    {

        get;
        private set;
    }
    string Phone_Number;
    public User(string national_Number, string password)
    {
        National_Number = national_Number;
        Password = password;

    }
}
