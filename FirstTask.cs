// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int point = 89;


if (point <0 || point >100)
{
    Console.WriteLine("Point should be between 0 and 100");
}
else if (point > 90 && point <= 100)
{
    Console.WriteLine("Your result: A");
}
else if (point > 80 && point <= 90)
{
    Console.WriteLine("Your result: B");
}
else if (point > 70 && point <=80)
{
    Console.WriteLine("Your result: C");
}
else if (point > 60 && point <= 70)
{
    Console.WriteLine("Your result: D");
}
else if (point > 50 && point <= 60)
{
    Console.WriteLine("Your result: E");
}
else if (point <= 50)
{
    Console.WriteLine("Your result: F");
}
