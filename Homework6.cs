public class ProgramDaniel
{

    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the name of the program you wish to use.");
        Console.Write("\nCHARACTER for ShowCharacter, RETAIL for CalculateRetail, TEMPERATURE for Celsius, and PRIME for IsPrime: ");
        string userInput = Console.ReadLine();

        Console.Clear();
        switch (userInput.Trim().ToUpper())
        {
            case "CHARACTER":
                ShowCharacter();
                break;
            case "RETAIL":
                CalculateRetail();
                break;
            case "TEMPERATURE":
                Celsius();
                break;
            case "PRIME":
                IsPrime();
                break;
            default:
                Console.WriteLine("Bruh");
                break;
        }
    }

    static void ShowCharacter()
    {
        Console.Write("Please enter a name: ");
        string name = Console.ReadLine();
        name = name.Trim().ToUpper();

        Console.Write("\nPlease enter a position of a character: ");
        int pos = int.Parse(Console.ReadLine());
        var letter = name[pos - 1];

        Console.WriteLine($"\n\nThe #{pos} character position of {name} is {letter}.");
    }

    static void CalculateRetail()
    {
        Console.Write("Please enter the item's wholesale cost: ");
        double cost = double.Parse(Console.ReadLine());

        Console.Write("\nPlease enter the markup percentage: ");
        double percent = double.Parse(Console.ReadLine());

        var totalPrice = Math.Round((percent / 100 * cost) + cost, 2);

        Console.WriteLine($"\n\nGiven a ${cost} wholesale cost and {percent}% markup, the item's retail price is ${totalPrice}.");
    }

    static void Celsius()
    {
        Console.Write("Please enter a Fahrenheit temperature ranging from 80 to 100 degrees: ");
        double temp = double.Parse(Console.ReadLine());

        if (temp >= 80 && temp <= 100)
        {
            for (double num = 80; num <= 100; num++)
            {
                double celcius = Math.Round((num - 32) * 5 / 9, 1);
                Console.WriteLine($"{num} degrees Fahrenheit = {celcius} degrees Celcius");
            }
            double celcius1 = Math.Round((temp - 32) * 5 / 9, 1);
            Console.WriteLine($"\nAccording to the table above, {temp} degrees Fahrenheit is {celcius1} degrees Celcius when converted.");
        }
        else
        {
            Console.WriteLine("Invalid Temperature Entered.");
        }
    }

    static void IsPrime()
    {
        Console.Write("Please enter an integer: ");
        int prime1 = int.Parse(Console.ReadLine());

        bool isPrime = true;

        if (prime1 <= 1)
        {
            isPrime = false;
        }

        for (int div = 2; div < prime1; div++)
        {
            if (prime1 % div == 0)
            {
                isPrime = false;
            }
        }

        Console.WriteLine("\nThis number is " + isPrime);
    }
}