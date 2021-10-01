using System;

Console.Title = "Interactive Story";

string townname = "test";
Random rnd = new Random();

int loop = 1;
int leftwall = rnd.Next(19);
int rightwall = rnd.Next(19);


bool townsquare = false;
bool outskirts  = false;

bool LeftChestOpen = false;
bool RightChestOpen = false;

bool LeftGuardConvo = false;
bool FirstConversation = true;
bool WeaponQuest = false;

string location; 

string LeftGuard = "Guard";


Console.WriteLine("Welcome traveller! What is your name?");
string name = Console.ReadLine();
Console.WriteLine($"Welcome to {townname}, {name}. Feel free to take a look around");

while(true) {
    if(loop == 1) {
        location = "Town Entrance";
        Console.WriteLine();
        Console.WriteLine("What do you wanna do next? Options:");
        Console.WriteLine("'Go left', 'Go right', 'Go straight' or 'Leave town'");
        Console.WriteLine("Tip: You can almost always check your location by typing 'Location'");
        string action = Console.ReadLine();
        action = action.ToLower();
        if(action == "go left") {
            if(leftwall < 5) {
                if(LeftChestOpen == false) {
                    Console.WriteLine("You have discovered a chest!");
                    Console.WriteLine("Do you wanna open it? Yes or No");
                    action = Console.ReadLine().ToLower();
                    if(action == "yes") {
                        LeftChestOpen = true;
                        Console.WriteLine($"You got {rnd.Next(1,4)} materials");
                    }
                    else {
                        Console.WriteLine("You went back to the Town Entrance");
                        loop = 1;
                    }
                }
                else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have already opened the chest!");
                    Console.ResetColor();
                }
            }
            else if(leftwall > 4) {
                Console.WriteLine("You see a tower");
                Console.WriteLine("Do you wanna enter the tower? Yes or No");
                action = Console.ReadLine().ToLower();
                if(action == "yes") {
                    Console.WriteLine("You entered the tower!");
                    loop = 4;
                }
                else {
                    Console.WriteLine("You went back to the Town Entrance");
                    loop = 1;
                }
            }
        }
        else if(action == "go right") {
            if(leftwall < 5) {
                if(RightChestOpen == false) {
                    Console.WriteLine("You have discovered a chest!");
                    Console.WriteLine("Do you wanna open it? Yes or No");
                    action = Console.ReadLine().ToLower();
                    if(action == "yes") {
                        RightChestOpen = true;
                        Console.WriteLine($"You got {rnd.Next(1,4)} materials");
                    }
                    else {
                        Console.WriteLine("You went back to the Town Entrance");
                        loop = 1;
                    }
                }
                else {
                    Console.WriteLine("You have already opened the chest!");
                }
            }
            else if(leftwall > 4 && leftwall < 7) {
                Console.WriteLine("You found a tunnel");
                Console.WriteLine("Do you wanna go down it? Yes or No");
                action = Console.ReadLine().ToLower();
            }
            else if(leftwall > 6) {
                Console.WriteLine("You see a tower");
                Console.WriteLine("Do you wanna enter the tower? Yes or No");
                action = Console.ReadLine().ToLower();
                if(action == "yes") {
                    Console.WriteLine("You entered the tower!");

                }
                else {
                    Console.WriteLine("You went back to the Town Entrance");
                    loop = 1;
                }
            }
        }
        else if(action == "go straight") {
            loop = 2;
        }
        else if(action == "leave town") {
            loop = 3;
        }
        else if(action == "location") {
            Console.WriteLine("You are at:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(location);
            Console.ResetColor();
            loop = 1;
        }
        else {  
            loop = 1;
        }
    }
    
    else if(loop == 2) {
        if(townsquare == false) {
            townsquare = true;
            Console.WriteLine("New place discovered:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Town Square");
            Console.ResetColor();
        }
        else {
            loop = 2;
        }
        location = "Town Square";
        Console.WriteLine();
        Console.WriteLine("What do you wanna do next? Options:");
        Console.WriteLine("'Go back'");
        string action = Console.ReadLine();
        action = action.ToLower();
        
        if(action == "go back") {
            loop = 1;
        }
        else if(action == "location") {
            Console.WriteLine("You are at:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(location);
            Console.ResetColor();
        }
        else {
            loop = 2;
        }
    }

    else if(loop == 3) {
        if(outskirts == false) {
            outskirts = true;
            Console.WriteLine("New place discovered:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Outskirts");
            Console.ResetColor();
        }
        else {
            loop = 3;
        }
        location = "Outskirts";
        Console.WriteLine();
        Console.WriteLine("What do you wanna do next? Options:");
        Console.WriteLine("'Go back'");
        string action = Console.ReadLine();
        action = action.ToLower();
        
        if(action == "go back") {
            loop = 1;
        }
        else if(action == "location") {
            Console.WriteLine("You are at:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(location);
            Console.ResetColor();
        }
        else {
            loop = 3;
        }
    }
    else if(loop == 4) {
        loop = 0;
        Console.WriteLine("You see a guard, the guard approaches you.");
        if(LeftGuardConvo == false) {
            LeftGuardConvo = true;
        Console.WriteLine($"{LeftGuard}: Hello {name}, I have heard stuff about you.");
        if(FirstConversation == true) {
            FirstConversation = false;
            Console.WriteLine("To choose a response, you need to write the number before the sentence");
        }
        Console.WriteLine("Choose a reponse:");
        Console.WriteLine("1. What have you heard about me?");
        Console.WriteLine("2. Who are you?");
        string action = Console.ReadLine().ToLower();
        if(action == "1") {
            Console.WriteLine("You: What have you heard about me?");
            Console.WriteLine($"{LeftGuard}: Let me introduce myself first");
            Console.WriteLine($"{LeftGuard}: I am Gregori, I work and live here");
            LeftGuard = "Gregori";
            Console.WriteLine($"{LeftGuard}: We haven't seen a traveller since the summer of '69");
            Console.WriteLine("You think for a bit, they haven't seen a single traveller for about 20 years?!");
        }
        else if(action == "2") {
            Console.WriteLine("You: Who are you?");
            Console.WriteLine($"{LeftGuard}: I am Gregori, one of the many guards here");
            LeftGuard = "Gregori";
        }
        else {
            Console.WriteLine("You decided to say nothing");
            Console.WriteLine($"{LeftGuard}: You a quiet guy? I will introduce myself.");
            Console.WriteLine($"{LeftGuard}: My name is Gregori, I am a guard here.");
            LeftGuard = "Gregori";
        }
        if(WeaponQuest == false) {
        Console.WriteLine();
        Console.WriteLine("I have a quest for you.");
        Console.WriteLine("We have a lack of weapons, can you bring me:");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("1 Stone Sword, 1 Iron Sword, 1 Bow & 10 Arrows.");
        Console.ResetColor();
        Console.WriteLine("Very easy job, but I have no time.");
        Console.WriteLine("Can you do it for me? Yes or No");
        action = Console.ReadLine().ToLower();
        if(action == "yes") {
            WeaponQuest = true;
            Console.WriteLine("Thank you, come back when you have the stuff.");
            Console.WriteLine("You went back to the Town Entrance");
            loop = 1;
        }
        else {
            Console.WriteLine("Ok, come back when you have changed your mind.");
            Console.WriteLine("You went back to the Town Entrance");
            loop = 1;
        }
        }
        else {
            
        }
        }
        else {
            if(WeaponQuest == false) {
            Console.WriteLine("Have you changed your mind?");
            Console.WriteLine("You will have to bring me:");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("1 Stone Sword, 1 Iron Sword, 1 Bow & 10 Arrows.");
            Console.ResetColor();
            Console.WriteLine("Do you accept the quest? Yes or No");
            string action = Console.ReadLine().ToLower();
            if(action == "yes") {
            WeaponQuest = true;
            Console.WriteLine("Thank you, come back when you have the stuff.");
            Console.WriteLine("You went back to the Town Entrance");
            loop = 1;
        }
        else {
            Console.WriteLine("Ok, come back when you have changed your mind.");
            Console.WriteLine("You went back to the Town Entrance");
            loop = 1;
        }
    }
    else {
        Console.WriteLine("Do you have the stuff?");
    }
    }
        
    }

    else {
        
    }
}