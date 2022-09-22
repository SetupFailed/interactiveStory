// fyi any other name will not trigger the main story other than "Thomas"

Console.WriteLine("<hey there, traveler. Whats your name?>");

string name = Console.ReadLine();
if (name == "Thomas")
{
    Console.WriteLine($"<Hey there, {name}. what brings you to these mountains?> [ENTER]");
    Console.ReadLine();

    Console.WriteLine("<i've come here to slay the dragon> or <that is none of your buisness>");
    Console.WriteLine("[1 or 2]");
    string choice = Console.ReadLine();


    if (choice == "1")
    {
        Console.WriteLine("<oh, so you're a brave one?>[ENTER]");
        Console.ReadLine();

        Console.WriteLine("<are you going to show me the way or are you going to keep talking> or <*stay silent*>");
        Console.WriteLine("1 or 2");
        
        choice = Console.ReadLine();
        
        if (choice == "1")
        {
            Console.WriteLine("<This way, young traveler and you have my and my villages sincere appreciation for taking on this beast.>");
            Console.ReadLine();
    
            
        }
        else if (choice == "2")
        {
            Console.WriteLine("<oh, i apologize. i shall leave it to you then>");
            Console.ReadLine();
        }
  
    }

    else if (choice == "2")
    {
        Console.WriteLine("<damn, anywayzzz. make sure to slay that dragon, thank you \n *mumbles* piece of shit");
        Console.ReadLine();
    }

}


else
{
    Console.WriteLine("<you are not whom i am looking for, get out!>");
    Console.WriteLine("press [ENTER] to exit");

    Console.ReadLine();
}

