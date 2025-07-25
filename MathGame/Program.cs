
using System.Runtime.Serialization;


string name = getName();
var date = DateTime.UtcNow ;
var games = new List <string>();
Random random = new Random();
int score = 0;
bool isGameOn = true;
string getName()
{
    Console.WriteLine("Please input your name:");
    string name = Console.ReadLine().ToUpper();
    return name;
}
Menu(name, date);

void Menu(string name, DateTime date)
{
    Console.WriteLine($"Hello {name} , it's {date.DayOfWeek} and welcome to the Math game");

    do
    {
        Console.WriteLine("Choose one operation to play with");
        Console.WriteLine("0.VIEW PROVIOUS GAME");
        Console.WriteLine("1.ADDTION");
        Console.WriteLine("2.SUBSTRACTION");
        Console.WriteLine("3.MULTIPLICATION");
        Console.WriteLine("4.DIVISION");
        Console.WriteLine("5.EXIT");
        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 0:
                Console.WriteLine("PREVIOUS GAMES:");
                if (games.Count == 0)
                {
                    Console.WriteLine("there are no previous game");
                }
                else
                {
                    foreach(var game in games)
                    {
                        Console.WriteLine(game);
                    }
                }
                break;
            case 1:
                additionGame();
                break;

            case 2:
                substractionGame();
                break;

            case 3:
                multiplicationGame();
                break;

            case 4:
                divisionGame();
                break;

            case 5:
                Console.WriteLine("EXITING.....");
                isGameOn = false;
                Environment.Exit(1);
                break;

            default:
                Console.WriteLine("Invalid choice!");
                break;

        }


    } while (isGameOn);


    
}
void additionGame()
{
    Console.WriteLine("You choose ADDITION");
    for (int i = 0; i < 5; i++)
    {
        int firstNumber = random.Next(1, 10);
        int secondNumber = random.Next(1, 10);

        Console.WriteLine($"{firstNumber} + {secondNumber}");
        int answer = Convert.ToInt32(Console.ReadLine());

        if (answer == firstNumber + secondNumber)
        {
            Console.WriteLine("Correct");
            score++;
            Console.WriteLine($"Your score:{score}");
        }
        else
        {
            Console.WriteLine("incorrect");
            Console.WriteLine($"Your score :{score}");
        }
        Thread.Sleep(1000);
        Console.Clear();
        games.Add($"{DateTime.UtcNow} -- ADDITION SCORE: {score}");
    }
    Console.WriteLine($"Your final score:{score}");

}
void substractionGame()
    {
        Console.WriteLine("You choose SUBSTRACTION");
        for (int i = 0; i < 5; i++)
        {
            int firstNumber = random.Next(1, 10);
            int secondNumber = random.Next(1, 10);

            Console.WriteLine($"{firstNumber} - {secondNumber}");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == firstNumber - secondNumber)
            {
                Console.WriteLine("Correct");
                score++;
                Console.WriteLine($"Your score:{score}");
            }
            else
            {
                Console.WriteLine("incorrect");
                Console.WriteLine($"Your score :{score}");
            }
            Thread.Sleep(1000);
            Console.Clear();
        games.Add($"{DateTime.UtcNow} -- SUBSTRACTION SCORE: {score}");

    }
    Console.WriteLine($"Your final score:{score}");
    }
void multiplicationGame()
    {
        Console.WriteLine("You choose MULTIPLICATION");
        for (int i = 0; i < 5; i++)
        {
            int firstNumber = random.Next(1, 10);
            int secondNumber = random.Next(1, 10);

            Console.WriteLine($"{firstNumber} * {secondNumber}");
            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == firstNumber * secondNumber)
            {
                Console.WriteLine("Correct");
                score++;
                Console.WriteLine($"Your score:{score}");
            }
            else
            {
                Console.WriteLine("incorrect");
                Console.WriteLine($"Your score :{score}");
            }
            Thread.Sleep(1000);
            Console.Clear();
        games.Add($"{DateTime.UtcNow} -- MULTIPLICATION SCORE: {score}");

    }
    Console.WriteLine($"Your final score:{score}");
    }
void divisionGame()
    {
    Console.WriteLine("You choose DIVISION");
    for( int i = 0; i < 5; i ++)
    {
        int[] divisionNumbers = getDivsionNumbers();
        int firstNumber = divisionNumbers[0];
        int secondNumber = divisionNumbers[1];

        Console.WriteLine($"{firstNumber} / {secondNumber}");

        int answer = Convert.ToInt32(Console.ReadLine());

        if (answer == firstNumber / secondNumber)
        {
            Console.WriteLine("Correct");
            score++;
            Console.WriteLine($"Your score:{score}");
        }
        else
        {
            Console.WriteLine("incorrect");
            Console.WriteLine($"Your score :{score}");
        }
        Thread.Sleep(1000);
        Console.Clear();
        games.Add($"{DateTime.UtcNow} -- DIVISION SCORE: {score}");

    }
    Console.WriteLine($"Your final score:{score}");
}

int[] getDivsionNumbers()
{
    int firstNumber = random.Next(1, 99);
    int secondNumber = random.Next(1, 99);
    int[] result = new int[2];

    while (firstNumber % secondNumber != 0 )
    {
         firstNumber = random.Next(1, 99);
         secondNumber = random.Next(1, 99);
    }

    result[0] = firstNumber;
    result[1] = secondNumber;
    return result;
}


