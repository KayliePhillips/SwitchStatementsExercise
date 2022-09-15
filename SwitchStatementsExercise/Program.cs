//Ask user for their favorite school subject


Console.WriteLine("What is your favorite school subject");
var userInput = (Console.ReadLine());


switch (userInput.ToLower())
{
    case "math":
    case "arithmetic":
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
    case "pe":
    case "gym":
        Console.WriteLine("Exercise is good for your health!");
        break;
    default:
        Console.WriteLine("Keep working hard in school!");
        break;

}