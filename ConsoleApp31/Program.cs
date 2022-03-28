using System;

namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добрый день! Какое сообщение вы хотите вывести на экран?");
            string outputMessage = Console.ReadLine();
            Console.WriteLine("Введите количество выводов на экран");
            int amountOfOutputs = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < amountOfOutputs; i++)
            {
                Console.WriteLine(outputMessage);
            }
        }
    }
}
