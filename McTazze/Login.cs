﻿using System;
using System.Threading.Tasks;

namespace McTazze
{
    public class Login
    {
        public static void Main(string[] args)
        {
            // Run async task and wait for result (discarded). This block of code avoids main from being async.
            Task.Run(async() =>
            {
                var accountsEngine = new webRequest.McThread(Users.users);
                _ = await accountsEngine.Thread();
            }).GetAwaiter().GetResult();

            // Save result
            Console.WriteLine("Accounts recharged!");
            Users.Output();
        }
    }
}
