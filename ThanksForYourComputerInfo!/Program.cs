Console.WriteLine("welcome to Google! Please enter your name:");
var name = (Console.ReadLine());
Console.WriteLine($"Hello, {name}! How old are you?");
var age = Convert.ToInt32(Console.ReadLine());
if (age <= 100 && age > 10)
{
    Console.WriteLine($"{age} is a good age to be! Now, will you give me you bank information?");
    var bankInfo = Console.ReadLine();
    if (bankInfo == "Yes" || bankInfo == "yes")
    {
        
        Console.WriteLine("You dont't have a choice lol! Thanks for giving me your money!");
        
        Console.WriteLine("Now, will you give me your computer info?");
        var cpuInfo = Console.ReadLine();
        if (cpuInfo == "yes" || cpuInfo == "Yes")
        {
            Console.WriteLine("Thanks for being so cooperative! Goodbye!");
        }


        else
        {
            Console.WriteLine("You still don't have a choice lol! Thanks! Goodbye!"); 
        }
           
    }
    else
    {
        Console.WriteLine("You dont't have a choice lol! Thanks for giving me your money!");
        
        Console.WriteLine("Now, will you give me your computer info?");
        var cpuInfo = Console.ReadLine();
        if (cpuInfo == "yes" || cpuInfo == "Yes")
        {
            Console.WriteLine("Thanks for being slightly cooperative! Goodbye!");
        }

        else
        {
            Console.WriteLine("You still don't have a choice lol! Thanks! Goodbye!");
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









