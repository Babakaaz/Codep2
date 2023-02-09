Console.WriteLine("please input three numbers");
int NUM1, NUM2, NUM3,MAX;
NUM1 = int.Parse(Console.ReadLine());
NUM2 = int.Parse(Console.ReadLine());
NUM3 = int.Parse(Console.ReadLine());
MAX = NUM1;
if (NUM2 > MAX)
{
    MAX = NUM2;
}
if (NUM3 > MAX)
{
    MAX = NUM3;
}
Console.WriteLine(MAX);
