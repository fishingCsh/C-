using System;

namespace Miliopnerzy2._0.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random los = new Random();
            int[] Questions = {1, 13};
            int losQuestions = los.Next(Questions.Length);
            
            if (losQuestions == 1)
            {
                Console.WriteLine("Question first\n\n" +
                "What language do we program in?\n" +
                "a) in Spanish\n" +
                "b) in English\n" +
                "c) in Japanese\n" +
                "d) in French\n");
                char switchQuiz = char.Parse(Console.ReadLine());
                if(switchQuiz == 'b' || switchQuiz == 'B')
                {
                    Console.WriteLine("Good answer!");
                }
                else
                {
                    Console.WriteLine("Bad answer!");
                    for (int i = 1000; i == 0; i--)
                    {
                        Console.WriteLine(i);
                    }
                }

            }
            else if(losQuestions == 2)
            {
                Console.WriteLine("Question first\n\n" +
                "What language do we program in?\n" +
                "a) in Spanish\n" +
                "b) in English\n" +
                "c) in Japanese\n" +
                "d) in French\n");
                char switchQuiz = char.Parse(Console.ReadLine());
                if (switchQuiz == 'b' || switchQuiz == 'B')
                {
                    Console.WriteLine("Good answer!");
                }
                else
                {
                    Console.WriteLine("Bad answer!");
                    for (int i = 1000; i == 0; i--)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
