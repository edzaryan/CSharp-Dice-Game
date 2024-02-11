
int playerRandomNum;
int enemyRandomNum;

int playerScore = 0;
int enemyScore = 0;

Random random = new Random();

for (int i = 0; i < 10; i++) 
{
    Console.WriteLine("Press any key to roll the dice");

    Console.ReadKey();

    playerRandomNum = random.Next(1, 10);

    Console.WriteLine("\nYou rolled: " + playerRandomNum);

    Console.WriteLine("...");

    Thread.Sleep(1000);

    enemyRandomNum = random.Next(1, 10);

    Console.WriteLine("\nEnemy rolled: " + enemyRandomNum);

    if (playerRandomNum > enemyRandomNum) 
    {
        playerScore++;
        Console.WriteLine("Player wins this round!");
    } 
    else if (playerRandomNum < enemyRandomNum) 
    {
        enemyScore++;
        Console.WriteLine("Enemy wins this round!");
    } 
    else 
    {
        Console.WriteLine("Draw!");
    }
}

if (playerScore > enemyScore)
{
    Console.WriteLine("The player wins!");
}
else if (playerScore < enemyScore)
{
    Console.WriteLine("The enemy wins!");
}
else 
{
    Console.WriteLine("It's draw !");
}

Console.WriteLine($"Player: {playerScore} - Enemy: {enemyScore}");