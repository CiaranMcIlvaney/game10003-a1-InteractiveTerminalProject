/* 
 * Name: Ciaran McIlvaney 
 * Date: September 18th 2024
 */

// Ask for users car preference 
Console.Write("Please enter the name of the car you would like to be driving in this game: ");
string userCar = Console.ReadLine();

// Explain the story
Console.WriteLine($"\nYou just got off your shift at work. As you walk out, you realize is it very dark and foggy outside. You " +
    $"realize you are going to have a rough time getting home as you are not 100% confident driving in the dark. You get " +
    $"inside your {userCar} and begin your drive home. ");

Console.WriteLine("\nAs you being your drive home you see a sign that says \"Detour Ahead Turn Right\". You sigh as you are already " +
    "having trouble driving down the road due to the foggyness. As you continue driving you realize you haven't seen a Detour sign in a " +
    "while. \"Did I miss it?\" \"Am I going the right way?\". These thoughts are starting to creep through your mind. After a while you " +
    "begin to accept your fate that you are lost. You pull out your phone. No signal. Your gonna have to drive blind until you get a signal. ");

// Users first decision 
Console.Write("\nAfter driving for a while you meet a fork in the road. You can turn \"Left\" or \"Right\". Which way do you choose: ");
string userFirstChoice = Console.ReadLine();

// If statement for users first decision
if (userFirstChoice == "Left")
{
    // Users second decision
    Console.Write($"\nYou turned {userFirstChoice}. After driving for a while you s1ee another fork in the road, this time you can either " +
        $"go \"Straight\" or \"Left\". Which way do you choose: ");
    string userSecondChoice = Console.ReadLine();

    // If statement for users second decision
    if (userSecondChoice == "Straight")
    {
        // Users third decision 
        Console.Write($"\nYou kept {userSecondChoice}. As you continue drive You see a young looking man with his thumb pointed up. He is a " +
            $"hitchiker. Do you pick him up? \"Yes\" or \"No\": ");
        string userThirdChoice = Console.ReadLine();

        // If statement for users third decision
        if (userThirdChoice == "Yes")
        {
            // Users fourth decision
            Console.Write("\nYou pick up the hitchicker, he only wants to be driven for around 3 minutes then asks to be taken out. You let him " +
                "out and continue on your drive. After a couple minutes you reach yet another fork. You can go \"Right\" or \"Left\". Which way do you " +
                "go: ");
            string userFourthChoice = Console.ReadLine();

            // If statement for users fourth decision
            if (userFourthChoice == "Right")
            {
                // Users fifth decision
                Console.Write($"\nYou chose to go {userFourthChoice}. You continue driving as normal then reach another fork in the road. \"Left\" or " +
                    $"\"Right\". Which way do you choose: ");
                string usersFifthChoice = Console.ReadLine();

                // If statement for users fifth decision 
                if (usersFifthChoice == "Right")
                {
                    // Users sixth decision
                    Console.Write($"\nYou went {usersFifthChoice}. You drive by around 5 random people on the end of the road. Signaling for you to stop. Do " +
                        $"you stop? \"Yes\" or \"No\": ");
                    string usersSixthChoice = Console.ReadLine();

                    // If statement for users sixth decision
                    if (usersSixthChoice == "Yes")
                    {
                        // Users seventh decision
                        Console.Write("\nYou stop and see what they wan't. They are demanding you give them some money. Otherwise something bad might happen. How " +
                            "much money are you giving them: ");
                        string userMoneyInput = Console.ReadLine();

                        // Converting input string to an integer 
                        int usersSeventhChoice = int.Parse(userMoneyInput);

                        // If statement for users seventh decision
                        if (usersSeventhChoice >= 50)
                        {
                            // Inform user they made it out safely
                            Console.WriteLine($"\nYou give them {usersSeventhChoice} which they are happy with. They let you go and you continue to drive. You start to notice " +
                                $"that the fog is starting to clear up a little bit and it is becoming easier to see. Up ahead to see a sign that says \"End Detour\", As you go " +
                                $"past the sign you become familiar with the surroundings you are in. You continue driving and then get home safely with nothing else " +
                                $"abnormal happening in your ride.");
                            Console.WriteLine("\nYOU WON!");
                        }
                        else if (usersSeventhChoice < 50)
                        {
                            Console.WriteLine("\nThey were looking for more money. They all get angry and start kicking and punching your car. As well as slashing your tires. " +
                                "You lost.");
                        }
                        else
                        {
                            // Informs user they put an invalid input 
                            Console.WriteLine("\nInvalid Input");
                        }

                    }
                    else if (usersSixthChoice == "No")
                    {
                        Console.WriteLine("\nYou drive by the strangers but they shoot your car wheels. All your tires are flat and you can't drive. They robbed " +
                            "you for everything you had on you. You lost.");
                    }
                    else
                    {
                        // Informs user they put an invalid input 
                        Console.WriteLine("\nInvalid Input");
                    }
                }
                else if (usersFifthChoice == "Left")
                {
                    Console.WriteLine("\nA animal comes out from nowhere and bangs into your car. Your front end of the car is destroyed. You lost. ");
                }
                else
                {
                    // Informs user they put an invalid input 
                    Console.WriteLine("\nInvalid Input");
                }
            }
            else if (userFourthChoice == "Left")
            {
                // Informs user they lost 
                Console.WriteLine("\nYou continue on driving. But then fall into a massive hole. You never stop falling. You are falling down this " +
                    "hole forever. You lost.");
            }
            else
            {
                // Informs user they put an invalid input 
                Console.WriteLine("\nInvalid Input");
            }
        }
        else if (userThirdChoice == "No")
        {
            // Informs user they lost
            Console.WriteLine("\n" +
                "You drive by the hitchicker. You check your rear mirror and see his face and body start to distort. He turns into " +
                "a massive monster and starts chasing your car. He catches up and swallows the car. You lost.");
        }
        else
        {
            // Informs user they put an invalid input 
            Console.WriteLine("\nInvalid Input");
        }

    }
    else if (userSecondChoice == "Left")
    {
        // Informs user they lost
        Console.WriteLine("\nYou realized you turned into a dead end. But as you reverse to turn around you realize both directions are dead ends. You " +
            "are stuck in this loop forever. You lost");
    }
    else
    {
        // Informs user they put an invalid input 
        Console.WriteLine("\nInvalid Input");
    }
}
else if (userFirstChoice == "Right")
{
    // Informs user they lost 
    Console.WriteLine("\nAfter driving for a long time you still can't see much, but then you see headlights up ahead. They are coming at you really quickly. " +
        "You try to swerve out of the way but with no luck. You lost. ");
}
else
{
    // Informs users they put an invalid input 
    Console.WriteLine("\nInvalid Input");
}
