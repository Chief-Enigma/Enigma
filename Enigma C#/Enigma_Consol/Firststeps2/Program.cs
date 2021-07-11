using System;
using System.Collections.Generic;
using System.Diagnostics;
using EncryptionSoftware;

class Program
{
    static void Main()
    {
        Console.Title = "Encryption Software";
        char[] characters = EncryptionSoftware.Encryption.characters;
        Console.WriteLine(characters);

        while (true)
        {
            print_label();
            Console.WriteLine("Encrypt or Decrypt Message?");
            Console.WriteLine("1 for Encrypt or 2 for Decrypt:");
            Console.Write("So what do u want? ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string Message_Encrypted = "";
                Console.WriteLine("Rules: only use lowercase  letters, NO capital letter!");
                Console.Write("Input Message: ");
                //Console.WriteLine("Encrypted message: " + Encryption.encrypt_message(Console.ReadLine()));
                Message_Encrypted = Encryption.encrypt_message(Console.ReadLine());
                Console.Write("Message Encrypted: ");
                List<char> Arr2 = new List<char>(Message_Encrypted.ToCharArray());
                //Arr2 = Message_Encrypted.ToCharArray();
                for (int y = 0; y < Arr2.Count; y++)
                {
                    for (int z = 0; z < characters.Length; z++)
                    {
                        Console.Write(characters[z]);
                        if (characters[z] == Arr2[y])
                        {
                            break;
                        }
                        System.Threading.Thread.Sleep((2000 / (Message_Encrypted.Length)) / characters.Length);
                        Console.Write("\b"); // Move the cursor one unit to the left
                    }

                }
                Console.WriteLine();
            }
            else if (choice == "2")
            {
                string Message_Decrypted = "";
                Console.WriteLine("Rules: only use lowercase  letters, NO capital letter!");
                Console.Write("Input encrypted Message: ");
                //Console.WriteLine("Message Decrypted: " + Encryption.decrypt_message(Console.ReadLine()));
                Message_Decrypted = Encryption.decrypt_message(Console.ReadLine());
                Console.Write("Message Decrypted: ");
                List<char> Arr2 = new List<char>(Message_Decrypted.ToCharArray());
                //Arr2 = Message_Encrypted.ToCharArray();
                for (int y = 0; y < Arr2.Count; y++)
                {
                    for (int z = 0; z < characters.Length; z++)
                    {
                        Console.Write(characters[z]);
                        if (characters[z] == Arr2[y])
                        {
                            break;
                        }
                        System.Threading.Thread.Sleep((2000 / (Message_Decrypted.Length)) / characters.Length);
                        Console.Write("\b"); // Move the cursor one unit to the left
                    }

                }
                Console.WriteLine();
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
        Console.WriteLine("This is a lock and NOTHING ELSE!!!\n\n");
    }
}





/*
https://www.codegrepper.com/code-examples/python/python+get+linux+command+output

https://www.youtube.com/watch?v=4uHTSknGJaY&t=9s


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