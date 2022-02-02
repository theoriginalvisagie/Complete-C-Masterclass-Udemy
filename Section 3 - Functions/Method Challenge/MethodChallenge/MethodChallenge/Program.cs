using System;

/*
 *Challenge:
 *Create GreetFriend Method that writes onto console when called
 *Name in greeting needs to be replaced with argument
 */
namespace MethodChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetFriend("Nathan");
            GreetFriend("Dylan");
            GreetFriend("Schalk");
        }

        public static void GreetFriend(string myFriendName)
        {
            Console.WriteLine($"Hi {myFriendName}, how are you?");
        }
    }
}
