﻿//int favoriteNumber = 2;

//var r = new Random();
//var favNumber = r.Next(1, 1000);
//var userInput = int.Parse(Console.ReadLine());

// The following code will allow the user to guess what your favorite number is:
Console.WriteLine("Enter a guess for my favorite number:");

var favNum = 2;
var userInput = int.Parse(Console.ReadLine());


 if (userInput < favNum)
{
    Console.WriteLine("Too low");
}
else if (userInput > favNum)
{
    Console.WriteLine("Too high");
}
else if (userInput == favNum)
{
    Console.WriteLine("You guessed it!");
}


 //Bonus - make it in a while loop. 

