using System;
public class CLient
{
    public string ClientID {  get; set; }
    public string ClientName { get; set; }
    public string ClientMail { get; set; }
    public string ClientPassword { get; set; }
    public CLient()
    {
    }
    public void login()
    {
        Console.WriteLine("Enter Your Name");
        string n = Console.ReadLine();
        ClientName = n;
        Console.WriteLine("enter your mail");
        string email = Console.ReadLine();
        ClientMail = email;
        Console.WriteLine("enter your password");
        string password = Console.ReadLine();
        ClientPassword = password;
        Console.WriteLine($"welcome back to tayarni {ClientName}");
    }
    public void signin()
    {
        Console.WriteLine("Enter Your Name");
        string n = Console.ReadLine();
        ClientName = n;
        Console.WriteLine("enter your mail");
        string email = Console.ReadLine();
        ClientMail = email;
        Console.WriteLine("enter your password\n password must contains letters and numbers");
        string password = Console.ReadLine();
        ClientPassword = password;
        Console.WriteLine("enter your national id \n it must contain 14 numbers");
        string NationalId =Console.ReadLine();
        ClientID = NationalId;
        Console.WriteLine($"welcome to tayarni {ClientName}");
    }
}