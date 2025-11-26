int guess;
int min = 1;
int max = 100;


Random rnd = new Random();

int number = rnd.Next(min, max + 1); //inklusive max
int guesses = 0;

do
{
    Console.Write("Gebe deine Zahl zwischen {0} und {1} ein: ", min, max);
    guess = Convert.ToInt32(Console.ReadLine());
    guesses++;

    if (guess == number)
    {
        Console.WriteLine("RIGHT! You guessed the number {0} in {1} guesses.", number, guesses);

    }
    else if (guess < number)
    {
        Console.WriteLine("TO LOW! Try again.");
    }
    else
    {
        Console.WriteLine("TO HIGH! Try again.");
    }
}
while (guess != number); 


