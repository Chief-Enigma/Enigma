using System;
using System.Collections.Generic;
using System.Diagnostics;

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
                encrypt_message(Console.ReadLine());
            }
            else if (choice == "2")
            {
                Console.WriteLine("Rules: only use lowercase  letters, NO capital letter!");
                Console.Write("Input encrypted Message: ");
                decrypt_message(Console.ReadLine());
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

    static void encrypt_message(string Message_In)
    {
        List<int> Arr1 = new List<int>();
        List<char> Arr2 = new List<char>();
        string Message_Encrypted = "";

        char[] Message_In_arr = Message_In.ToCharArray();
        

        for (int x = 0; x < Message_In.Length; x++)
        {
            for (int y = 0; y < characters.Length; y++)
            {
                char lookingfor = characters[y];
                if (Message_In_arr[x] == lookingfor)
                {
                    Arr1.Add(y);
                }
            }
        }
        //numbers in arr
        for (int y = 0; y < Message_In.Length; y++)
        {
            Arr1[y] = (Arr1[y] + key[y % key.Length]);
        }
        //build encrypted message
        for (int y = 0; y < Arr1.Count; y++)
        {
            //Arr2.append(characters[Arr1[y] % characters.Length]);
            Arr2.Add(characters[Arr1[y] % characters.Length]);
        }

        for (int y = 0; y < Arr2.Count; y++)
        {
            Message_Encrypted += Arr2[y];
        }

        //Console.WriteLine("Message Encrypted: " + Message_Encrypted);
        Console.Write("Message Encrypted: ");

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
                //Console.Write("\x1B[1P"); // Delete the character
                
            }
        
        }
        Console.WriteLine();

    }



    static void decrypt_message(string Message_In)
    {
        List<int> Arr1 = new List<int>();
        List<char> Arr2 = new List<char>();
        string Message_Encrypted = "";

        char[] Message_In_arr = Message_In.ToCharArray();

        for (int x = 0; x < Message_In.Length; x++)
        {
            for (int y = 0; y < characters.Length; y++)
            {
                char lookingfor = characters[y];
                if (Message_In_arr[x] == lookingfor)
                {
                    Arr1.Add(y);
                }
            }
        }
        //numbers in arr
        for (int y = 0; y < Message_In.Length; y++)
        {
            Arr1[y] = (Arr1[y] - key[y % key.Length]);
        }
        //build encrypted message
        for (int y = 0; y < Arr1.Count; y++)
        {
            //Arr2.append(characters[Arr1[y] % characters.Length]);
            int index = Arr1[y] % characters.Length;
            if (index < 0)
            {
                index = characters.Length + index;
            }
            Arr2.Add(characters[index]);

        }

        for (int y = 0; y < Arr2.Count; y++)
        {
            Message_Encrypted += Arr2[y];
        }

        //Console.WriteLine("Message Decrypted: " + Message_Encrypted);
        Console.Write("Message Decrypted: ");

        for (int y = 0; y < Arr2.Count; y++)
        {
            for (int z = 0; z < characters.Length; z++)
            {
                Console.Write(characters[z]);
                if (characters[z] == Arr2[y])
                {
                    break;
                }
                System.Threading.Thread.Sleep((2000 / (Message_Encrypted.Length))/characters.Length);
                Console.Write("\b"); // Move the cursor one unit to the left
                //Console.Write("\x1B[1P"); // Delete the character

            }

        }
        Console.WriteLine();
    }

    static void print_label()
    {

        Console.WriteLine("        .-\"\"-.                                           _   _                            __ _");
        Console.WriteLine("       / .--. \\          ___ _ __   ___ _ __ _   _ _ __ | |_(_) ___  _ __      ___  ___  / _| |___      ____ _ _ __ ___ ");
        Console.WriteLine("      / /    \\ \\        / _ \\ '_ \\ / __| '__| | | | '_ \\| __| |/ _ \\| '_ \\    / __|/ _ \\| |_| __\\ \\ /\\ / / _` | '__/ _ \\");
        Console.WriteLine("      | |    | |       |  __/ | | | (__| |  | |_| | |_) | |_| | (_) | | | |   \\__ \\ (_) |  _| |_ \\ V  V / (_| | | |  __/");
        Console.WriteLine("      | |.-\"\"-.|        \\___|_| |_|\\___|_|   \\__, | .__/ \\__|_|\\___/|_| |_|   |___/\\___/|_|  \\__| \\_/\\_/ \\__,_|_|  \\___|");
        Console.WriteLine("     ///`.::::.`\\                            |___/|_|");
        Console.WriteLine("    ||| ::/  \\:: ;"); 
        Console.WriteLine("    ||; ::\\__/:: ;"); 
        Console.WriteLine("     \\\\\\ '::::' /"); 
        Console.WriteLine("      `=':-..-'`");
        Console.WriteLine();
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