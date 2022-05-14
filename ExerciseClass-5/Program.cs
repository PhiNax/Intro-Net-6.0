Console.Title = "Class 5";
Console.ForegroundColor = ConsoleColor.Blue;

var userInput = "Y";

while (userInput.ToUpper() == "Y")
{
    Console.Clear();

    Console.WriteLine(
    "#################################\n" +
    "#                               #\n" +
    "#            Welcome            #\n" +
    "#                               #\n" +
    "#################################\n"
    );
    Console.Write("Please insert your name: " );
    var userName = Console.ReadLine();

    Console.ForegroundColor = ConsoleColor.Magenta;

    Console.WriteLine($"\nHello {userName}!\n");

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine(
        "Whould you like yo continue?\n" +
        "Please select Y (yes) or N (no):\n"
        );

    userInput = Console.ReadLine();
}

if (userInput.ToUpper() == "" || userInput.ToUpper() != "N")
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("\nOption not valid");
}
else
{
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("\nProgram completed successfully!");
}