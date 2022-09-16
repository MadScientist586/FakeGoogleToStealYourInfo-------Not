Console.WriteLine("welcome to Google! Please enter your name:");
var name = (Console.ReadLine());
Console.WriteLine($"Hello, {name}! How old are you?");
var age = Convert.ToInt32(Console.ReadLine());
if (age <= 100 && age > 10)
{
    Console.WriteLine($"{age} is a good age to be!");
    Console.WriteLine("What is your favorite color?");
    var favColor = Console.ReadLine();
    Console.WriteLine($"{favColor} is a good color!");
    Console.WriteLine("What is your dream car?");
    var dreamCar = Console.ReadLine();  
    Console.WriteLine($"{dreamCar}s are nice cars!");
    Console.WriteLine("Last question. What is your favorite brand of computer?");
    var favBrand = Console.ReadLine();
    Console.WriteLine($"{favBrand} is the best computer brand!");
    Console.WriteLine("Press enter to continue...");
    var enter = Console.ReadLine();
    Console.WriteLine("Computer error... Would you like to resolve the error?");
    var resolveError = Console.ReadLine();
    if (resolveError == "yes" || resolveError == "Yes")
    {
        Console.WriteLine("Resolving error......");
        Console.WriteLine("Hmmm the error is persistent.");
        Console.WriteLine("To fix this you have to give me your computer info. Will you give it to me?");
        var cpuInfo = Console.ReadLine();
        if (cpuInfo == "Yes" || cpuInfo == "yes")
        {

            Console.WriteLine("Thank you! resolving error......");

            Console.WriteLine("Would you like to continue?");
            var Continue = Console.ReadLine();
            if (Continue == "yes" || Continue == "Yes")
            {
                Console.WriteLine("Thanks! Now I have your address, social security number, bank info, computer info, and your license plate!");
            }


            else
            {
                Console.WriteLine("You don't have a choice! Now I have your address, social security number, bank info, computer info, and your license plate!");
            }

        }
        else
        {
            Console.WriteLine("Hmmm I'm going to take it anyways. resolving error......");

            Console.WriteLine("Would you like to continue?");
            var Continue = Console.ReadLine();
            if (Continue == "yes" || Continue == "Yes")
            {
                Console.WriteLine("Thanks for being slightly cooperative! Now I have your address, social security number, bank info, computer info, and your license plate!");
            }

            else
            {
                Console.WriteLine("You don't have a choice! Thanks! Now I have your address, social security number, bank info, computer info, and your license plate!");
            }

        }
    }
   
  else
    {
        Console.WriteLine("I'm going to have to resolve it anyways. Resolving error......");
        Console.WriteLine("Hmmm the error is persistent.");
        Console.WriteLine("To fix this you have to give me your computer info. Will you give it to me?");
        var cpuInfo = Console.ReadLine();
        if (cpuInfo == "Yes" || cpuInfo == "yes")
        {

            Console.WriteLine("Thank you! resolving error......");

            Console.WriteLine("Would you like to continue?");
            var Continue = Console.ReadLine();
            if (Continue == "yes" || Continue == "Yes")
            {
                Console.WriteLine("Thanks! Now I have your address, social security number, bank info, computer info, and your license plate!");
            }


            else
            {
                Console.WriteLine("You don't have a choice! Now I have your address, social security number, bank info, computer info, and your license plate!");
            }

        }
        else
        {
            Console.WriteLine("Hmmm I'm going to take it anyways. resolving error......");

            Console.WriteLine("Would you like to continue?");
            var Continue = Console.ReadLine();
            if (Continue == "yes" || Continue == "Yes")
            {
                Console.WriteLine("Thanks for being slightly cooperative! Now I have your address, social security number, bank info, computer info, and your license plate!");
            }

            else
            {
                Console.WriteLine("You don't have a choice! Thanks! Now I have your address, social security number, bank info, computer info, and your license plate!");
            }

        }
    }


}
else if (age > 100)
{
    Console.WriteLine("You are too old for this website, but thanks for your bank information!");
}
else
{
    Console.WriteLine("You are too young for this website. Goodbye.");
}









