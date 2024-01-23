// author: Rod Mastria
// program: Number Analyzer
// framework: .NET 8.0
// category: Day2 Lab1

Console.WriteLine("--- Number Analyzer Game ---");

bool runProgram = true;
while (runProgram)
{
    Console.WriteLine("To begin, enter a whole number 1 through 100");

    // assuming valid input
    int userNum = int.Parse(Console.ReadLine());
    

    // 2a
    if (userNum % 2 == 1 &&  userNum < 60)
    {
        Console.WriteLine("Odd and less than 60");
    } 
    // 2b
    else if (userNum % 2 == 0 && userNum <= 24 ) // redundant: && userNum >= 2)
    {
        Console.WriteLine("Even and less than 25");
    } 
    //2c
    else if (userNum % 2 == 0 && userNum <= 60 && userNum >= 26)
    {
        Console.WriteLine("Even and between 26 through 60");
    } 
    //2d
    else if (userNum % 2 == 0 && userNum > 60)
        {
        Console.WriteLine("Even and greater than 60");
    } 
    //2e
    else if (userNum % 2 == 1 && userNum > 60)
    {
        Console.WriteLine("Odd and greater than 60");
    }

    Console.WriteLine("Would you like to repeat the game? y/n");
    string choice = Console.ReadLine();
    if (choice != null && choice.ToLower().Trim().Contains("y"))
    {
        runProgram = true;
    }
    else
    {
        runProgram = false;
    }
}
