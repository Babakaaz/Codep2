Console.BackgroundColor= ConsoleColor.Yellow;
Console.ForegroundColor= ConsoleColor.DarkGreen;
Console.WriteLine("you enterned to KulatzMatrix!");
int MainNum, NextNum;

MainNum = int.Parse(Console.ReadLine());
while (MainNum >1)
{
    if (MainNum % 2 == 0)
    {
        MainNum = (MainNum / 2);
    }
    else MainNum = MainNum * 3 + 1;
    Console.WriteLine(MainNum);

}
