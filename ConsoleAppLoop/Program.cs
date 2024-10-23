// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//loop
//char myLetter = 'a';
//while (myLetter <= 'm') // mandatory to have condition, no operator
//{
//    Console.Write(myLetter);
//    myLetter++;
//}

//for (char i = 'a'; i < 'm'; i++)
//{
//    Console.WriteLine(i);
//}

//nested loop - create a square

Console.Write("Enter length: ");
int length= Convert.ToInt32(Console.ReadLine());
Console.Write("Enter width: ");
int width = Convert.ToInt32(Console.ReadLine());
Console.Write("What symbol: ");
char symbol = Convert.ToChar(Console.ReadLine());

for (int i = 0; i < length; i++)
{
    for (int j = 0; j < width; j++)
    {
        Console.Write(".");
    }
    Console.WriteLine(symbol);
}
