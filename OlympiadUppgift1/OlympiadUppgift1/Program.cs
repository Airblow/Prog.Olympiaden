using System;
namespace OlympiadUppgift6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Vad vill du skriva och hur många gånger ska det upprepas? Skriv t.ex 'hej 6' för att skriva hej 6 gånger. Endast mellan 1 och 9.");
                string[] userInput = Console.ReadLine().Split(" ");

                int repeating = int.Parse(userInput[1]);

                Console.WriteLine();

                if (repeating < 10 && repeating > 0)
                    for (int i = 0; i < repeating; i++)
                    {
                        Console.Write(userInput[0]);                   
                    }
                else
                {
                    Console.WriteLine("Du angav ett ogiltligt tal");
                }

            }
            catch
            {
                Console.WriteLine("Något blev fel. Kom ihåg, endast tal 1-9.");
            }
            
            Console.ReadKey();
        }
    }
}