// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int[] number = { 4, 28, -3, 22, -7, -20,15 };
int countplus = 0;
int countmin = 0;
for (int i = 0; i < number.Length; i++)
{ if (number [i] > 0) 
    { countplus++;
    }
 //else if (number[i] > 0)
 //   { countplus++;
 //   }
}
countmin = (number.Length - countplus);
Console.WriteLine("Positive numbers count: " + countplus + "\nNegative number counts: " + countmin);
//Console.WriteLine(countmin);
