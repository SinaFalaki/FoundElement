Console.ForegroundColor = ConsoleColor.Green;
Console.Write("\n\n\t\t\t\t\t    please Enter your Phrase :");
var Input = Console.ReadLine();
short Digit = 0;
short letter = 0;
short WhiteSpace = 0;
short symbol = 0;
Console.ForegroundColor = ConsoleColor.Yellow;
for (int i = 0; i < Input.Length; i++)
{
    if (char.IsDigit(Input[i]))
    {
        Digit++;
    }
    else if (char.IsLetter(Input[i]))
    {
        letter++;
    }
    else if (char.IsWhiteSpace(Input[i]))
    {
        WhiteSpace++;
    }
    else if (char.IsSymbol(Input[i]))
    {
        symbol++;
    }
    else
    {
        symbol++;
    }


}
Console.WriteLine($"\n\n\t\t\t\t\t\tnumber of Digit is : {Digit}\n\n\t\t\t\t\t\tnumber of Letter is : {letter}\n\n\t\t\t\t\t\tnumber of WhiteSpace is : {WhiteSpace}\n\n\t\t\t\t\t\tnumber of Symbol is : {symbol} ");
Console.ForegroundColor = ConsoleColor.Cyan;
int All = symbol+letter+Digit+WhiteSpace;
Console.WriteLine($"\n\t\t\t\t\t\tTotal Character is : {All}");
Console.ReadKey();
