
for (int i = 0; i < 3; i++)
{
    Console.WriteLine("input your username & password");
    string UserLogin = Console.ReadLine();
    string UserLoginPass = Console.ReadLine();
    if (UserLogin == "dana" && UserLoginPass == "D_a1650@")
    {
        Console.WriteLine("you entered");
        goto End;
    }
    else
        Console.WriteLine("password or username is incorrect! tryagain!");
}
Console.WriteLine("you had 3 chances to login please comeback and tryagain!");
End:
Console.ReadKey();