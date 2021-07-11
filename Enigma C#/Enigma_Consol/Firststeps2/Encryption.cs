using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace EncryptionSoftware
{
    public class Encryption
    {

        public static char[] characters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' ', '.', ',', ':', ';', '?', '!', '-', '_','+', '"', '*', '#', '%', '&', '/', '(', ')', '=', '$', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '\'' };
        static int[] key = { 37, 17, 49, 8, 29, 12, 33, 55, 26, 4, 47, 16, 50, 31, 14, 42, 34, 48 };

        public static string encrypt_message(string Message_In)
        {
            List<int> Arr1 = new List<int>();
            List<char> Arr2 = new List<char>();
            string Message_Encrypted = "";
            string encrypted_message_out = "";

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

            return encrypted_message_out = Message_Encrypted;
            //Console.WriteLine("Message Encrypted: " + Message_Encrypted);
            //Console.Write("Message Encrypted: ");

            //for (int y = 0; y < Arr2.Count; y++)
            //{
            //    for (int z = 0; z < characters.Length; z++)
            //    {
            //        Console.Write(characters[z]);
            //        if (characters[z] == Arr2[y])
            //        {
            //            break;
            //        }
            //        System.Threading.Thread.Sleep((2000 / (Message_Encrypted.Length)) / characters.Length);
            //        Console.Write("\b"); // Move the cursor one unit to the left
            //                             //Console.Write("\x1B[1P"); // Delete the character

            //    }

            //}
            //Console.WriteLine();

        }



        public static string decrypt_message(string Message_In)
        {
            List<int> Arr1 = new List<int>();
            List<char> Arr2 = new List<char>();
            string Message_Encrypted = "";
            string decrypted_message_out = "";

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

            return decrypted_message_out = Message_Encrypted;

            ////Console.WriteLine("Message Decrypted: " + Message_Encrypted);
            //Console.Write("Message Decrypted: ");

            //for (int y = 0; y < Arr2.Count; y++)
            //{
            //    for (int z = 0; z < characters.Length; z++)
            //    {
            //        Console.Write(characters[z]);
            //        if (characters[z] == Arr2[y])
            //        {
            //            break;
            //        }
            //        System.Threading.Thread.Sleep((2000 / (Message_Encrypted.Length)) / characters.Length);
            //        Console.Write("\b"); // Move the cursor one unit to the left
            //                             //Console.Write("\x1B[1P"); // Delete the character

            //    }

            //}
            //Console.WriteLine();
        }
    }
}
