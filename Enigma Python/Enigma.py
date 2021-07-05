import sys

Characters = ["a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"," ",".",",","?","!","-","1","2","3","4","5","6","7","8","9","0","\""]
key = [1,17,63,8,2,19,22,1,45,2,4,6,2,0,17,5,1,48]
Arr1 = []
Arr2 = []


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
    
    

def decrypt_message(Message_In):

    Message_In_arr = list(Message_In)

    for x in range(len(Message_In)):
        
        for i in range(len(Characters)):
            lookingfor = Characters[i]
            if Message_In_arr[x] == lookingfor:
                Arr1.append(i)

    #numbers in arr
    for y in range(len(Message_In)):
        Arr1[y] = (Arr1[y] - key[y%len(key)])

    #build encrypted message
    for y in range(len(Arr1)):
        Arr2.append(Characters[Arr1[y]%len(Characters)])

    Message_Decrypted = ""

    for i in Arr2:
        Message_Decrypted += i

    print("Message Encrypted:",Message_Decrypted)
    Message_In = ""
    Arr1.clear()
    Arr2.clear()

#main setup

sys.stderr.write("\x1b[2J\x1b[H")



#main loop

while True: # generiert infinity loop
    print("Encrypt or Decrypt Message?")
    print("1 for Encrypt or 2 for Decrypt:")
    Choice = input("So what do u want? ")

    if Choice == "1":
        print("Rules: only use lowercase  letters, NO capital letter!")
        encrypt_message(Message_In = input("Input Message: "))
        endclear = True
    elif Choice == "2":
        print("Rules: only use lowercase  letters, NO capital letter!")
        decrypt_message(Message_In = input("Input Message: "))
        endclear = True
    else:
        print("Invalid choice! try again...")
        endclear = True

    while endclear == True:
        if input("Press \"Enter\" to continue") == "":
            sys.stderr.write("\x1b[2J\x1b[H")
            endclear = False


"""
https://stackoverflow.com/questions/35116496/python-print-specific-character-from-string



modulo "%" 
teilt y durch len(key)
Arr1[y] = (Arr1[y] + key[y%len(key)])

"""


