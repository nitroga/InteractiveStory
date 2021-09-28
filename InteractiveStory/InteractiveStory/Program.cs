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

string location; 


Console.WriteLine("Welcome traveller! What is your name?");
string name = Console.ReadLine();
Console.WriteLine($"Welcome to {townname}, {name}. Feel free to talk a look around");

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
            }
            else if(leftwall > 4) {
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

    else {
        
    }
}