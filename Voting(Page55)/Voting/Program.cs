int VoteCounterALI = 0, VoteCounterMMD = 0;
for (int i = 0; i< 25; i++)
{
    Console.WriteLine("vote for AliAzami=1 , vote for MmdHabiboour = 2");
    int VOTE = int.Parse(Console.ReadLine());
    if (VOTE == 1)
    {
        VoteCounterALI++;
    }
    else VoteCounterMMD++;
    Console.WriteLine(VoteCounterALI);
    Console.WriteLine(VoteCounterMMD);
}