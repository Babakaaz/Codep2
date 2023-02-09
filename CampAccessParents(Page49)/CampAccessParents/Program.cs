Console.WriteLine("accessing for going camp");
bool parent;
bool sun;
int students;
students = int.Parse(Console.ReadLine());
parent = bool.Parse(Console.ReadLine());
sun = bool.Parse(Console.ReadLine());
if (parent = true)
{
    if (sun = true)
    {
        if (students >= 2)
        {
            Console.WriteLine("camp will be plan");
        }
        else Console.WriteLine("camp is cancelled");
    }
    else Console.WriteLine("camp is cancelled");
}
else Console.WriteLine("camp is cancelled");

