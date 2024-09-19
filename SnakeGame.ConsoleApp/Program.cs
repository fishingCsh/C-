using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class SnakeGame
{
    private const int Width = 40;
    private const int Height = 20;
    private const char SnakeChar = 'S';
    private const char FoodChar = 'a';
    private const char BorderChar = '#';

    private static List<(int x, int y)> snake = new List<(int x, int y)> { (20, 10) };
    private static (int x, int y) food;
    private static (int x, int y) direction = (1, 0);
    private static bool gameOver = false;
    private static Random random = new Random();
    private static int score = 0;

    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        SpawnFood();

        while (!gameOver)
        {
            DrawGame();
            Input();
            MoveSnake();
            CheckCollision();
            Thread.Sleep(100);
        }

        Console.Clear();
        Console.WriteLine($"Game Over! Your score: {score}");
    }

    private static void DrawGame()
    {
        Console.Clear();
        // Rysowanie obramowania
        for (int i = 0; i <= Width + 1; i++) Console.Write(BorderChar);
        Console.WriteLine();
        for (int i = 0; i < Height; i++)
        {
            Console.Write(BorderChar);
            for (int j = 0; j < Width; j++)
            {
                if (snake.Any(s => s.x == j && s.y == i))
                    Console.Write(SnakeChar);
                else if (food.x == j && food.y == i)
                    Console.Write(FoodChar);
                else
                    Console.Write(' ');
            }
            Console.Write(BorderChar);
            Console.WriteLine();
        }
        for (int i = 0; i <= Width + 1; i++) Console.Write(BorderChar);
        Console.WriteLine();
        Console.WriteLine($"Score: {score}");
    }

    private static void Input()
    {
        if (!Console.KeyAvailable) return;

        var key = Console.ReadKey(true).Key;
        switch (key)
        {
            case ConsoleKey.UpArrow:
                if (direction != (0, 1)) direction = (0, -1);
                break;
            case ConsoleKey.DownArrow:
                if (direction != (0, -1)) direction = (0, 1);
                break;
            case ConsoleKey.LeftArrow:
                if (direction != (1, 0)) direction = (-1, 0);
                break;
            case ConsoleKey.RightArrow:
                if (direction != (-1, 0)) direction = (1, 0);
                break;
        }
    }

    private static void MoveSnake()
    {
        var newHead = (x: snake[0].x + direction.x, y: snake[0].y + direction.y);
        snake.Insert(0, newHead);

        if (newHead == food)
        {
            score++;
            SpawnFood();
        }
        else
        {
            snake.RemoveAt(snake.Count - 1); // Usunięcie ogona
        }
    }

    private static void CheckCollision()
    {
        var head = snake[0];

        // Kolizja ze ścianami
        if (head.x < 0 || head.x >= Width || head.y < 0 || head.y >= Height)
            gameOver = true;

        // Kolizja z samym sobą
        if (snake.Skip(1).Any(s => s == head))
            gameOver = true;
    }

    private static void SpawnFood()
    {
        do
        {
            food = (random.Next(0, Width), random.Next(0, Height));
        } while (snake.Any(s => s == food));
    }
}