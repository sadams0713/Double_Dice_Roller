class Program
{
    static int firstRoll;
    static int secondRoll;
    static int dieTotal;
    static int diceType;
    public static void Main()
    {
        while (true)
        {
            try
            {
                diceType = int.Parse(GetUserInput("What kind of dice are you using? Please enter the number of sides it has"));

                if (diceType <= 1)
                {
                    Console.WriteLine("That's not a dice. That's air. \nYou're trying to roll air. Please enter a minimum of 3 sides.");
                    continue;
                }
                else if (diceType == 2)
                {
                    Console.WriteLine("Dude. That's a coin. Just flip it.");
                    continue;
                }
            }
            catch
            {
                Console.WriteLine("Not a valid input");
                continue;
            }
            while (true)
            {
                Rollem();
                bool check = OneMoreTime();
                if (check == false)
                {
                    break;
                }
            }
            break;
        }
    }


    public static string GetUserInput(string prompt)
    {
        Console.WriteLine(prompt);
        string output = Console.ReadLine();
        return output;
    }

    public static bool OneMoreTime()
    {
        string input = GetUserInput("Want to try your luck again? Please enter  Y/N");

        if (input == "y" || input == "yes" || input == "Y" || input == "Yes")
        {
            return true;
        }
        else if (input == "n" || input == "no" || input =="N" || input =="No")
        {
            Console.WriteLine("Thanks for playing!");
            return false;
        }
        else
        {
            Console.WriteLine("Sorry I didn't catch that. Let's try again.");
            return OneMoreTime();
        }
    }

    public static void Rollem()
    {
        Random dice = new();

        firstRoll = dice.Next(1, diceType + 1);
        secondRoll = dice.Next(1, diceType + 1);
        dieTotal = firstRoll + secondRoll;
        if (diceType == 6)
        {
            StandardDie();
        }
        else if(diceType == 20)
        {
            DND();
        }
        Console.WriteLine($"You rolled a {firstRoll} and a {secondRoll}.\n That's {dieTotal} all together.");
    }

    public static void DND()
    {
        if(firstRoll == 1 || secondRoll == 1)
        {
            Console.WriteLine(" Whoa Crit Fail! This is gonna be bad");
        }
        else if(firstRoll==20 || secondRoll==20)
        {
            Console.WriteLine("Nat 20 Baby! Here's all the good things");
        }
        else if (firstRoll == 1 && secondRoll == 20)
        {
            Console.WriteLine("Critical Crit. I'm not sure what happens here. Maybe they cancel out? \nWhy are you always rolling with advantage or disadvantage anyway? You're either really lucky or extremely bad.");
        }
    }

    public static void StandardDie()
    {
        if (firstRoll == 1 && secondRoll == 1)
        {
            Console.WriteLine("Snake eyes!");
        }
       
        if (firstRoll == 6 && secondRoll == 6)
        {
            Console.WriteLine("Boxcar (Children)!");
        }
        if (dieTotal == 7 || dieTotal == 11)
        {
            Console.WriteLine("Craps Stuff I Think! I Guess it Wins! ");
        }
        if(dieTotal==3)
        {
            Console.WriteLine("Another Craps Thing! \nI don't know if it's good or bad, but it's happening");
        }
    }

}


       

            