Random dice = new();

int playerScore = 0;
int enemyScore = 0;

while (playerScore <= 10 && enemyScore <= 10)
{
    int playerRoll = dice.Next(1, 7);
    int enemyRoll = dice.Next(1, 7);

    Console.WriteLine($"Player rolled a: {playerRoll}");
    playerScore += playerRoll;
    Console.WriteLine($"Enemy rolled a: {enemyRoll}");
    enemyScore += enemyRoll;

    if (playerScore > 10 || enemyScore > 10)
    {
        break;
    }

    Console.WriteLine($"Current Scores: Player: {playerScore} | Enemy: {enemyScore}");

    string roundResult = playerRoll.CompareTo(enemyRoll) switch
    {
        > 0 => "Player wins this turn!",
        < 0 => "Enemy wins this round!",
        _ => "It's a tie this round!"
    };

    Console.WriteLine(roundResult);
}
Console.WriteLine($"Final Scores: Player: {playerScore} | Enemy: {enemyScore}");

Console.WriteLine(playerScore > enemyScore ? "Player wins the fight!" : "Enemy wins the fight!");
