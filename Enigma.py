#!/usr/bin/python3

import os 
import time
from time import sleep

Message_Out = "No"
Characters = ["a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"," ",".",",","?","!","-","1","2","3","4","5","6","7","8","9","0","\""]
key = [1,3,3,8,2,19,7,1,0,12,4,6,2,0,17,5,1,8]
Arr1 = []
Arr2 = []
Message_Encrypted = ""



def encrypt_message(Message_In):
    
    Message_In_arr = list(Message_In)

    for x in range(len(Message_In)):
        
        for i in range(len(Characters)):
            lookingfor = Characters[i]
            if Message_In_arr[x] == lookingfor:
                Arr1.append(i)

#numbers in arr
    for y in range(len(Message_In)):
        Arr1[y] = (Arr1[y] + key[y%len(key)])

#build encrypted message
    for y in range(len(Arr1)):
        Arr2.append(Characters[Arr1[y]%len(Characters)])

    Message_Encrypted = ""

    for i in Arr2:
        Message_Encrypted += i

    print("Message Encrypted:",Message_Encrypted)
    Message_In = ""
    Arr1.clear()
    Arr2.clear()
    

    fjkasdh aggd
    sfd
    ghsdhg
    sghsdf
    hgsdg
    sdfghsd
    


while True:
    print("Rules: only use lowercase  letters, NO capital letter!")
    encrypt_message(Message_In = input("Input Message: "))



"""
https://stackoverflow.com/questions/35116496/python-print-specific-character-from-string



modulo "%" 
teilt y durch len(key)
Arr1[y] = (Arr1[y] + key[y%len(key)])

"""


