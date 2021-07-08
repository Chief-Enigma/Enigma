using System;
using System.Collections.Generic;
using System.Diagnostics;
using EncryptionSoftware;

class Program
{
    static char[] characters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' ', '.', ',', '?', '!', '-', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '\'' };
    static int[] key = { 1, 17, 63, 8, 2, 19, 22, 1, 45, 2, 4, 6, 2, 0, 17, 5, 1, 48 };



    static void Main()
    {

        while (true)
        {
            print_label();
            Console.WriteLine("Encrypt or Decrypt Message?");
            Console.WriteLine("1 for Encrypt or 2 for Decrypt:");
            Console.Write("So what do u want? ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Rules: only use lowercase  letters, NO capital letter!");
                Console.Write("Input Message: ");
                Console.WriteLine("Encrypted message: " + Encryption.encrypt_message(Console.ReadLine()));
            }
            else if (choice == "2")
            {
                Console.WriteLine("Rules: only use lowercase  letters, NO capital letter!");
                Console.Write("Input encrypted Message: ");

                Console.WriteLine("Decrypted message: " + Encryption.decrypt_message(Console.ReadLine()));
                
            }
            else
            {
                Console.WriteLine("Invalid choice! try again...");
            }
            Console.WriteLine("Press any key to contniue");
            Console.ReadKey();
            Console.Clear();
        }

    }

    static void print_label()
    {

        Console.WriteLine("        .-\"\"-.                                       _   _                            __ _");
        Console.WriteLine("       / .--. \\      ___ _ __   ___ _ __ _   _ _ __ | |_(_) ___  _ __      ___  ___  / _| |___      ____ _ _ __ ___ ");
        Console.WriteLine("      / /    \\ \\    / _ \\ '_ \\ / __| '__| | | | '_ \\| __| |/ _ \\| '_ \\    / __|/ _ \\| |_| __\\ \\ /\\ / / _` | '__/ _ \\");
        Console.WriteLine("      | |    | |   |  __/ | | | (__| |  | |_| | |_) | |_| | (_) | | | |   \\__ \\ (_) |  _| |_ \\ V  V / (_| | | |  __/");
        Console.WriteLine("      | |.-\"\"-.|    \\___|_| |_|\\___|_|   \\__, | .__/ \\__|_|\\___/|_| |_|   |___/\\___/|_|  \\__| \\_/\\_/ \\__,_|_|  \\___|");
        Console.WriteLine("     ///`.::::.`\\                        |___/|_|");
        Console.WriteLine("    ||| ::/  \\:: ;"); 
        Console.WriteLine("    ||; ::\\__/:: ;"); 
        Console.WriteLine("     \\\\\\ '::::' /"); 
        Console.WriteLine("      `=':-..-'`");
        Console.WriteLine("\n\n");
    }


    static void cmd2()
    {
        Process.Start("cmd", "start chrome");

    }


}





/*


                                  _   _             
  ___ _ __   ___ _ __ _   _ _ __ | |_(_) ___  _ __  
 / _ \ '_ \ / __| '__| | | | '_ \| __| |/ _ \| '_ \ 
|  __/ | | | (__| |  | |_| | |_) | |_| | (_) | | | |
 \___|_| |_|\___|_|   \__, | .__/ \__|_|\___/|_| |_|
                      |___/|_|                      


            __ _                          
 ___  ___  / _| |___      ____ _ _ __ ___ 
/ __|/ _ \| |_| __\ \ /\ / / _` | '__/ _ \
\__ \ (_) |  _| |_ \ V  V / (_| | | |  __/
|___/\___/|_|  \__| \_/\_/ \__,_|_|  \___|
                                          



 */