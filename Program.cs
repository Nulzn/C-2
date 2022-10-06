int hemligtNum = 47;
int guessesLeft = 3;
int guesses = 0;

bool gameRunning = true;
while (gameRunning)
{
    try
    {
        Console.WriteLine("Gissa Talet: ");
        int num = Convert.ToInt32(Console.ReadLine());;
        if (num == hemligtNum)
        {
            Console.WriteLine("Du Vann!");
            gameRunning = false;
        }
        else
        {
            guesses++;
            int leftGuesses = guessesLeft - guesses;
            Console.WriteLine((guesses == guessesLeft) ? "Fel! Du förlorade!" : $"Fel! Gissa igen. {leftGuesses} försök kvar.");
            if (leftGuesses == 0)
            {
                gameRunning = false;
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Något gick snett med programmet! Felkod: {ex}");
    }
}