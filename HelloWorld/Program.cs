using System;

/*
Console.WriteLine("Hello!");
string firstName = "Hayden ";
string lastName = "Orr";
string name = firstName + lastName;
Console.WriteLine("My name is " + name);
Console.WriteLine("I'm still new at this but I\'m here to learn!");
Console.WriteLine("Please tell me more about how I can help all of you!");
Console.WriteLine("Tell me!"); */

/*
Console.WriteLine("Bread is ready. \n Who is the bread for?");
string yourName = Console.ReadLine();
Console.WriteLine("Noted: " + yourName + " got bread."); */

//Ask user for description of the thing 
Console.WriteLine("What kind of thing are we talking about?");
string thing = Console.ReadLine();

//Ask user for the adjective
Console.WriteLine("How would you describe it? Big? Aure? Tattered?");
string adj = Console.ReadLine();

//Combine description with adjective and print
string closer = "of Doom 3000";

Console.WriteLine("The {0} {1} {2}!", adj, thing, closer);
Console.WriteLine("The " + adj + " " + thing + closer + "!");
