
// See https://aka.ms/new-console-template for more information

using ADVENT1;

Console.WriteLine("*******************************************");
Console.WriteLine("*          Advent of code 2024            *");
Console.WriteLine("*******************************************");
Console.WriteLine();
Console.Write("Choose a day from 1 - 24 or 0 to quit: ");
int choice = int.Parse(Console.ReadLine()); 
while (choice != 0) 
{ 
    switch (choice) 
    { 
        case 1: 
            new Day1().Run(); 
            break; 
        case 2: 
            new Day2().Run(); 
            break; 
        case 3:
            new Day3().Run();
            break;
        case 0: 
            Console.WriteLine("Quitting");
            break; 
        default: 
            Console.WriteLine("Invalid choice, please try again."); 
            break; 
            } 
    Console.WriteLine(); 
    Console.Write("Choose day with day number or 0 to quit: "); 
    choice = int.Parse(Console.ReadLine()); 
}