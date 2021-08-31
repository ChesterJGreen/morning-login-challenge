using System;
using System.Collections.Generic;
using user_login.Models;

namespace morning_login_challenge
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Dictionary<String, User> users = new Dictionary<string, User>();
      //Make some users
      User jake = new User("Jake", "IHeartCode!");
      User jbalvin = new User("JBalvin", "IHeartRocketMortgage!");
      User mark = new User("Mark", "C0deRox?");
      User seej = new User("Seej", "MyPasswordDude");

      users.Add(jake.Name, jake);
      users.Add(jbalvin.Name, jbalvin);
      users.Add(mark.Name, mark);
      users.Add(seej.Name, seej);

      bool authenticated = false;
      while (!authenticated)
      {


        Console.WriteLine("Welcome, please enter the following information");
        Console.WriteLine("Username: ?");
        string user = Console.ReadLine();
        Console.WriteLine("Password: ?");
        string pWord = Console.ReadLine();
        if (users.ContainsKey(user) && users[user].ValidatePassword(pWord))
        {
          Console.WriteLine("Successfully Logged in");
          Console.WriteLine("Welcome " + user);
          authenticated = true;


        }
        else
        {
          Console.WriteLine("Invalid username or password...");
        }

      }
    }
  }
}
