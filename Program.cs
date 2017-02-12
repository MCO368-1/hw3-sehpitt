using System;
using System.Threading;

namespace GameOfLife
{
    internal class Program
    {
        private static readonly int height = 20;
        private static readonly int width = 20;
        private static int[,] x;
        private static readonly Board b = new Board();


        private static void Main(string[] args)
        {
            x = b.CreateBoard(height, width);
            PromptForBoardType();
            PromptForRunType();
        }

        private static void PromptForBoardType()
        {

            while (true)
            {
                Console.WriteLine(
                    "Press 1 for Blinker: Press 2 for Toad: Press 3 for Beacon: Press 4 for Pulsar: Press 5 for Pentadecathlon");
                var line = Console.ReadLine();
                if (line == "1")
                {
                    b.CreateBlinkerBoard();
                    break;
                }
                if (line == "2")
                {
                    b.CreateToadBoard();
                    break;
                }
                if (line == "3")
                {
                    b.CreateBeaconBoard();
                    break;
                }
                if (line == "4")
                {
                    b.CreatePulsarBoard();
                    break;
                }
                if (line == "5")
                {
                    b.CreatePentadecathlonBoard();
                    break;
                }
            }
        }

       private static void PromptForRunType()
        {
            while (true)
            {
                Console.WriteLine("Press 1 for Auto: Press 2 for Manual: Press 3 to close:");
                string line = Console.ReadLine();
                if (line == "1")
                    do
                    {
                        while (!Console.KeyAvailable)
                        {
                            b.DisplayBoard(x);
                            b.ChangeState();
                            x = b.GetBoard();
                            Thread.Sleep(500);
                        }
                    } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

                if (line == "2")
                {
                    while (true)
                    {
                        Console.WriteLine("Press 1 to move to next board: Press 2 to stop:");
                        string line3 = Console.ReadLine();
                        if (line3 == "1")
                        {
                            b.DisplayBoard(x);
                            b.ChangeState();
                            x = b.GetBoard();
                        }
                        if (line3 == "2")
                        {
                            break;
                        }
                    }
                }
                if (line == "3")
                {
                    break;
                }
            }
        }
    }
}