using System;
using System.Collections.Generic;

namespace DesignPattern.Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            FacebookGroupMediator facebookMediator = new ConcreteFacebookGroupMediator();
            User Ram = new ConcreteUser(facebookMediator, "Ram");
            User Dave = new ConcreteUser(facebookMediator, "Dave");
            User Smith = new ConcreteUser(facebookMediator, "Smith");
            User Rajesh = new ConcreteUser(facebookMediator, "Rajesh");
            User Sam = new ConcreteUser(facebookMediator, "Sam");
            User Pam = new ConcreteUser(facebookMediator, "Pam");
            User Anurag = new ConcreteUser(facebookMediator, "Anurag");
            User John = new ConcreteUser(facebookMediator, "John");

            facebookMediator.RegisterUsers(new List<User>
            {
                Ram,
                Dave,
                Smith,
                Rajesh,
                Sam,
                Pam,
                Anurag,
                John
            });

            Dave.Send("dotnettutorials.net - this website is very good to learn Design Pattern");
            Console.WriteLine();
            Rajesh.Send("What is Design Patterns? Please explain ");

            Console.Read();
        }
    }
}
