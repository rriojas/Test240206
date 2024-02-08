// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//read a string and print it
Console.WriteLine("Enter a string: ");
string str = Console.ReadLine();
Console.WriteLine("You entered: " + str);
//read a number and print it

Console.WriteLine("Enter a number: ");
Int32 num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("You entered: " + num);
////read a character and print it

Console.WriteLine("Enter a character: ");
string line = Console.ReadLine();
if (line.Length==0)
{
    Console.WriteLine("You did not enter a character");
    return;
}

char ch = line[0];
Console.WriteLine("You entered: " + ch);

Console.ReadKey();
