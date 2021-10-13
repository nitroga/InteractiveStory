using System;

Console.Title = "Interactive Story";

string townname = "test";
Random rnd = new Random();

int loop = 1;
int leftwall = rnd.Next(20);
int rightwall = rnd.Next(20);
int countryside = 0;

int wood = 0;
int stone = 0;
int iron = 0;
int coins = 10;


bool townsquare = false;
bool outskirts = false;

bool LeftChestOpen = false;
bool RightChestOpen = false;

bool LeftGuardConvo = false;
bool WeaponQuest = false;

string LeftGuard = "Guard";

Console.WriteLine("Welcome traveller! What is your name?");
string name = Console.ReadLine();
Console.WriteLine($"Welcome to {townname}, {name}. Feel free to take a look around");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"To choose an action to do, type the number before the action\n");
Console.ResetColor();

while (true)
{
    if (loop == 1)
    {
        countryside = 0;
        Console.WriteLine("You are at the Town Entrance\n");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("(1) Go left\n(2) Go right\n(3) Go straight\n(4) Leave Town");
        Console.ResetColor();
        string action = Console.ReadLine().ToLower();
        if (action == "1")
        {
            Console.Clear();
            if (leftwall < 5)
            {
                if (LeftChestOpen == false)
                {
                    Console.WriteLine("You have discovered a chest!");
                    Console.WriteLine("Do you wanna open it? Yes or No");
                    action = Console.ReadLine().ToLower();
                    if (action == "yes")
                    {
                        LeftChestOpen = true;
                        coins = coins + rnd.Next(3,13);
                        wood = wood + rnd.Next(2,6);
                        stone = stone + rnd.Next(1,4);
                        iron = iron + rnd.Next(3);
                        Console.WriteLine("You now have:");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"{coins} Coins");
                        Console.WriteLine($"{wood} Wood");
                        Console.WriteLine($"{stone} Stones");
                        Console.WriteLine($"{iron} Iron pieces");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("You went back to the Town Entrance");
                        loop = 1;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have already opened the chest!");
                    Console.ResetColor();
                }
            }
            else if (leftwall > 4)
            {
                Console.WriteLine("You see a tower");
                Console.WriteLine("Do you wanna enter the tower? Yes or No");
                action = Console.ReadLine().ToLower();
                if (action == "yes")
                {
                    Console.WriteLine("You entered the tower!");
                    loop = 4;
                }
                else
                {
                    Console.WriteLine("You went back to the Town Entrance");
                    loop = 1;
                }
            }
        }
        else if (action == "2")
        {
            Console.Clear();
            if (leftwall < 5)
            {
                if (RightChestOpen == false)
                {
                    Console.WriteLine("You have discovered a chest!");
                    Console.WriteLine("Do you wanna open it? Yes or No");
                    action = Console.ReadLine().ToLower();
                    if (action == "yes")
                    {
                        RightChestOpen = true;
                        coins = coins + rnd.Next(3,13);
                        wood = wood + rnd.Next(2,6);
                        stone = stone + rnd.Next(1,4);
                        iron = iron + rnd.Next(3);
                        Console.WriteLine("You now have:");
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"{coins} Coins");
                        Console.WriteLine($"{wood} Wood");
                        Console.WriteLine($"{stone} Stones");
                        Console.WriteLine($"{iron} Iron pieces");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("You went back to the Town Entrance");
                        loop = 1;
                    }
                }
                else
                {
                    Console.WriteLine("You have already opened the chest!");
                }
            }
            else if (leftwall > 4 && leftwall < 7)
            {
                Console.WriteLine("You found a tunnel");
                Console.WriteLine("Do you wanna go down it? Yes or No");
                action = Console.ReadLine().ToLower();
            }
            else if (leftwall > 6)
            {
                Console.WriteLine("You see a tower");
                Console.WriteLine("Do you wanna enter the tower? Yes or No");
                action = Console.ReadLine().ToLower();
                if (action == "yes")
                {
                    Console.WriteLine("You entered the tower!");

                }
                else
                {
                    Console.WriteLine("You went back to the Town Entrance");
                    loop = 1;
                }
            }
        }
        else if (action == "3")
        {
            Console.Clear();
            loop = 2;
        }
        else if (action == "4")
        {
            countryside = 1;
            Console.Clear();
            loop = 3;
        }

        else
        {
            Console.Clear();
            loop = 1;
        }
    }

    else if (loop == 2)
    {
        if (townsquare == false)
        {
            townsquare = true;
            Console.WriteLine("New place discovered:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Town Square\n");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("You are at the Town Square");
            loop = 2;
        }
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n(4) Go back");
        Console.ResetColor();
        string action = Console.ReadLine().ToLower();

        if (action == "4")
        {
            loop = 1;
        }

        else
        {
            loop = 2;
        }
    }

    else if (loop == 3)
    {
        if (outskirts == false)
        {
            outskirts = true;
            Console.WriteLine("New place discovered:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Outskirts");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("You stand by the road connecting the town and the countryside");
            loop = 3;
        }
        if(countryside == 4) {
            Console.Clear();
            Console.WriteLine("You see a farm\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("(1) Enter the farm\n(2) Go further from town\n(3) Go towards town");
            Console.ResetColor();                
        }
        else if(countryside == 0) {
            Console.Clear();
            loop = 1;
        }
        else {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n(1) Hitchhike\n(2) Go further into the countryside\n(3) Go towards town");
            Console.ResetColor();
        }
        string action = Console.ReadLine().ToLower();

        if (action == "1")
        {
            Console.Clear();
            int hitchhike = rnd.Next(4);
            if(hitchhike == 0) {
                Console.WriteLine("A vehicle appeared\nDriver: Where do you wanna go?\n");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("(1) To the farm\n(2) To the town");
                Console.ResetColor();
                action = Console.ReadLine();
                if(action == "1") {
                    Console.Clear();
                    countryside = 4;
                }
                else {
                    Console.Clear();
                    loop = 1;
                }
                
            }
            else if(hitchhike == 1) {
                Console.WriteLine("A vehicle appeared, but ignored you");
            }
            else {
                Console.WriteLine("No vehicle appeared");
            }
        }
        else if(action == "2") 
        {
            Console.Clear();
            countryside++;
        }

        else
        {
            Console.Clear();
            countryside--;
        }
        
    }
    else if (loop == 4)
    {
        loop = 0;
        Console.WriteLine("You see a guard, the guard approaches you.");
        if (LeftGuardConvo == false)
        {
            LeftGuardConvo = true;
            Console.WriteLine($"{LeftGuard}: Hello {name}, I have heard stuff about you.");
            Console.WriteLine("(1) What have you heard about me?\n(2) Who are you");
            string action = Console.ReadLine().ToLower();
            if (action == "1")
            {
                Console.WriteLine("You: What have you heard about me?");
                Console.WriteLine($"{LeftGuard}: Let me introduce myself first");
                Console.WriteLine($"{LeftGuard}: I am Gregori, I work and live here");
                LeftGuard = "Gregori";
                Console.WriteLine($"{LeftGuard}: We haven't seen a traveller since the summer of '69");
                Console.WriteLine("You think for a bit, they haven't seen a single traveller for about 20 years?!");
            }
            else if (action == "2")
            {
                Console.WriteLine("You: Who are you?");
                Console.WriteLine($"{LeftGuard}: I am Gregori, one of the many guards here");
                LeftGuard = "Gregori";
            }
            else
            {
                Console.WriteLine("You decided to say nothing");
                Console.WriteLine($"{LeftGuard}: You a quiet guy? I will introduce myself.");
                Console.WriteLine($"{LeftGuard}: My name is Gregori, I am a guard here.");
                LeftGuard = "Gregori";
            }
            if (WeaponQuest == false)
            {
                Console.WriteLine("\nI have a quest for you.");
                Console.WriteLine("We have a lack of weapons, can you bring me:");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("1 Stone Sword, 1 Iron Sword, 1 Bow & 10 Arrows.");
                Console.ResetColor();
                Console.WriteLine("Very easy job, but I have no time.");
                Console.WriteLine("Can you do it for me? Yes or No");
                action = Console.ReadLine().ToLower();
                if (action == "yes")
                {
                    WeaponQuest = true;
                    Console.WriteLine("Thank you, come back when you have the stuff.");
                    Console.WriteLine("You went back to the Town Entrance");
                    loop = 1;
                }
                else
                {
                    Console.WriteLine("Ok, come back when you have changed your mind.");
                    Console.WriteLine("You went back to the Town Entrance");
                    loop = 1;
                }
            }
            else
            {

            }
        }
        else
        {
            if (WeaponQuest == false)
            {
                Console.WriteLine("Have you changed your mind?");
                Console.WriteLine("You will have to bring me:");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("1 Stone Sword, 1 Iron Sword, 1 Bow & 10 Arrows.");
                Console.ResetColor();
                Console.WriteLine("Do you accept the quest? Yes or No");
                string action = Console.ReadLine().ToLower();
                if (action == "yes")
                {
                    WeaponQuest = true;
                    Console.WriteLine("Thank you, come back when you have the stuff.");
                    Console.WriteLine("You went back to the Town Entrance");
                    loop = 1;
                }
                else
                {
                    Console.WriteLine("Ok, come back when you have changed your mind.");
                    Console.WriteLine("You went back to the Town Entrance");
                    loop = 1;
                }
            }
            else
            {
                Console.WriteLine("Do you have the stuff?");
            }
        }

    }

    else
    {
    Console.WriteLine("We are no strangers to love\nYou know the rules and so do I\nA full commitments what I am thinking of\nYou would not get this from any other guy\nI just wanna tell you how I am feeling\nGotta make you understand\nNever gonna give you up\nNever gonna let you down\nNever gonna run around and desert you\nNever gonna make you cry\nNever gonna say goodbye\nNever gonna tell a lie and hurt you\nWe have known each other for so long\nYour heart has been aching but you are too shy to say it\nInside we both know whats been going on\nWe know the game and we are gonna play it\nAnd if you ask me how I am feeling\nDo not tell me you are too blind to see\nNever gonna give you up\nNever gonna let you down\nNever gonna run around and desert you\nNever gonna make you cry\nNever gonna say goodbye\nNever gonna tell a lie and hurt you\nNever gonna give you up\nNever gonna let you down\nNever gonna run around and desert you\nNever gonna make you cry\nNever gonna say goodbye\nNever gonna tell a lie and hurt you\nNever gonna give never gonna give\n(Give you up)\nWe have known each other for so long\nYour hearts been aching but you are too shy to say it\nInside we both know what has been going on\nWe know the game and we are gonna play it\nI just wanna tell you how I am feeling\nGotta make you understand\nNever gonna give you up\nNever gonna let you down\nNever gonna run around and desert you\nNever gonna make you cry\nNever gonna say goodbye\nNever gonna tell a lie and hurt you\nNever gonna give you up\nNever gonna let you down\nNever gonna run around and desert you\nNever gonna make you cry\nNever gonna say goodbye\nNever gonna tell a lie and hurt you\nNever gonna give you up\nNever gonna let you down\nNever gonna run around and desert you\nNever gonna make you cry\nNever gonna say goodbye");
    Console.ReadLine();
    }
}