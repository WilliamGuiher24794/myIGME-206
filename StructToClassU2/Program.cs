﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructToClass
{
    public class Friend
    {
        public string name = null;
        public string greeting = null;
        public DateTime birthdate;
        public string address = null;

        
    }

    class Program
    {

        static void Main(string[] args)
        {
            Friend friend = new Friend();
            Friend enemy = new Friend();

            // create my friend Charlie Sheen
            friend.name = "Charlie Sheen";
            friend.greeting = "Dear Charlie";
            friend.birthdate = DateTime.Parse("1967-12-25");
            friend.address = "123 Any Street, NY NY 12202";

            // now he has become my enemy
            enemy.name = friend.name = "Charlie Sheen";
            enemy.greeting = friend.greeting = "Dear Charlie";
            enemy.birthdate = friend.birthdate = DateTime.Parse("1967-12-25");
            enemy.address = friend.address = "123 Any Street, NY NY 12202";

            // set the enemy greeting and address without changing the friend variable
            enemy.greeting = "Sorry Charlie";
            enemy.address = "Return to sender.  Address unknown.";

            Console.WriteLine($"friend.greeting => enemy.greeting: {friend.greeting} => {enemy.greeting}");
            Console.WriteLine($"friend.address => enemy.address: {friend.address} => {enemy.address}");
        }
    }
}

