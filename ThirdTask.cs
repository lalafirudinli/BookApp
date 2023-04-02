// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int[] number = { 3, 66, 99, 88, 44, 77, 15 };
int max = number[0];
for (int i = 0; i < number.Length; i++ )
{ if (number[i] > max) 
    max = number[i];
}
Console.WriteLine(max);