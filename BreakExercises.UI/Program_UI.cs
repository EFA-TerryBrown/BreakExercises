using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Program_UI
{
    //make the methods here...
    //Freebie:
    public void Greeter(string userName)
    {
        if (userName != null)
            System.Console.WriteLine($"Hi, {userName}");
        else
            System.Console.WriteLine("Null Message!");
    }
}
