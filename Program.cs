
// See https://aka.ms/new-console-template for more information

using ADVENT1;

menu();
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
        case 4:
            new Day4().Run();
            break;
        case 0: 
            Console.WriteLine("Quitting");
            break; 
        default: 
            Console.WriteLine("Invalid choice, please try again."); 
            break; 
            } 
    Console.WriteLine();
    Console.WriteLine("Press Return key to go back"); 
    Console.ReadKey();
    menu();    
    choice = int.Parse(Console.ReadLine()); 
}

void menu()
{
    Console.Clear();
    Console.WriteLine("*******************************************");
    Console.WriteLine("*          Advent of code 2024            *");
    Console.WriteLine("*******************************************");
    Console.WriteLine();
    Console.Write("Choose a day from 1 - 24 or 0 to quit: ");
}