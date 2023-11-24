using System;
namespace olympiadUppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Skriv in ett heltal som är större än 0.");
                long userNumber = long.Parse(Console.ReadLine());
                long product = 0;
                int firstVariable = 1;

                while (userNumber > product)
                {
                    product = firstVariable * (firstVariable + 1) * (firstVariable + 2);
                    firstVariable++;

                }

                Console.WriteLine($"Det finns {firstVariable - 2} treiga tal som är mindre än {userNumber}.");
                Console.ReadKey();

            }
            catch
            {
                Console.WriteLine("Något gick fel. Följde du instruktionerna?");
            }

        }

    }

}
