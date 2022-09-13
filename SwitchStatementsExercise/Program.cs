//Ask user for their favorite school subject


Console.WriteLine("What is your favorite school subject");
var userInput = (Console.ReadLine());

switch (userInput)
{
    case "math":
        Console.WriteLine("Math is fun and useful!");
        break;
    case "science":
        Console.WriteLine("Science can be exciting, especially when you do experients!");
        break;
    case "english":
        Console.WriteLine("English will be helpful for proper grammer.");
        break;
    case "reading":
        Console.WriteLine("Reading is a good thing to practice.");
        break;
    case "PE":
        Console.WriteLine("PE is good for your health!");
        break;
    default:
        Console.WriteLine("Keep working hard in school!");
        break;

}