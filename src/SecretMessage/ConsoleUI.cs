using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretMessage
{
    class ConsoleUI
    {
        public static void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please select one of the following functions using the keyboard, then press Enter.");
                Console.WriteLine("Create a secret message (press 1)");
                Console.WriteLine("Decode a secret message (press 2)");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Please enter the message:");
                        string messageInput = Console.ReadLine();
                        Console.Write("Please enter the key:");
                        string keyInput = Console.ReadLine();
                        SecretCode sm = new SecretCode(messageInput, keyInput);
                        Console.WriteLine($"The created secret message:{sm.CreateSecreteMessage()}");
                        Console.WriteLine("Press any key to return to the menu.");
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("Please enter the encrypted message:");
                        string secretInput = Console.ReadLine();
                        Console.Write("Please enter the key:");
                        string keyInput_1 = Console.ReadLine();

                        SecretDecode sd = new SecretDecode(keyInput_1, secretInput);
                        Console.WriteLine($"The decoded message:{sd.Decode()}");
                        Console.WriteLine("Press any key to return to the menu.");
                        Console.ReadKey();
                        break;
                }
            }
        }

    }
}
