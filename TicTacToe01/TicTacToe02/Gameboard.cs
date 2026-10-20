using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace TicTacToe02
{
    internal class Gameboard
    {
        private bool player;
        private int playcount = 0;
        private string[] box = Enumerable.Repeat(".", 9).ToArray();

        public void GameBorad()
        {
            Console.Clear();
            Console.WriteLine("=== 틱택토 게임 · 1단계 ===");
            Console.WriteLine("두 사람이 X와 O를 번갈아 놓습니다. X가 먼저 시작합니다.");
            Console.WriteLine();
            Console.WriteLine("위치번호:");
            Console.WriteLine("1 | 2 | 3");
            Console.WriteLine("---------");
            Console.WriteLine("4 | 5 | 6");
            Console.WriteLine("---------");
            Console.WriteLine("7 | 8 | 9");
            Console.WriteLine();
            Console.WriteLine("현재 보드:");
            Console.WriteLine($"{box[0]} | {box[1]} | {box[2]}");
            Console.WriteLine("---------");
            Console.WriteLine($"{box[3]} | {box[4]} | {box[5]}");
            Console.WriteLine("---------");
            Console.WriteLine($"{box[6]} | {box[7]} | {box[8]}");
            Console.WriteLine();
        }
        
        public void Gameplay()
        {
            if (!player)
            {
                Console.WriteLine("플레이어 X의 차례입니다.");
                Console.Write("위치를 선택하세요 (1~9): ");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    int i = choice - 1;
                    if (i >= 0 && i < box.Length)
                    {
                        if (box[i] == ".")
                        {
                            box[i] = "X";
                            playcount++;
                            WinerCondition("X");
                            player = true;
                        }
                        else
                        {
                            Console.WriteLine("이미 선택된 자리입니다.");
                            Thread.Sleep(2000);
                        }
                    }
                    else
                    {
                        Console.WriteLine("1부터 9까지의 번호를 입력하세요.");
                        Thread.Sleep(2000);
                    }
                }

            }

            else
            {
                Console.WriteLine("플레이어 O의 차례입니다.");
                Console.Write("위치를 선택하세요 (1~9): ");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    int i = choice - 1;
                    if (i >= 0 && i < box.Length)
                    {
                        if (box[i] == ".")
                        {
                            box[i] = "O";
                            playcount++;
                            WinerCondition("O");
                            player = false;
                        }
                        else
                        {
                            Console.WriteLine("이미 선택된 자리입니다.");
                            Thread.Sleep(2000);
                        }
                    }
                    else
                    {
                        Console.WriteLine("1부터 9까지의 번호를 입력하세요.");
                        Thread.Sleep(2000);
                    }
                }
            }
            if (playcount == 9)
            {
                Console.WriteLine("무승부!");
                ResetGame();
            }
        }
        public void WinerCondition(string player)
        {
           if ((box[0] == player && box[1] == player && box[2] == player) ||
                  (box[3] == player && box[4] == player && box[5] == player) ||
                  (box[6] == player && box[7] == player && box[8] == player) ||
                  (box[0] == player && box[3] == player && box[6] == player) ||
                  (box[1] == player && box[4] == player && box[7] == player) ||
                  (box[2] == player && box[5] == player && box[8] == player) ||
                  (box[0] == player && box[4] == player && box[8] == player) ||
                  (box[2] == player && box[4] == player && box[6] == player))
            {
                if (player == "X")
                {
                    Console.WriteLine("X 승리!");
                    ResetGame();
                }
                else if (player == "O")
                {
                    Console.WriteLine("O 승리!");
                    ResetGame();
                }
            }
        }

        public void ResetGame()
        {
            Console.WriteLine("재시작 하시겠니까?");
            Console.WriteLine("아무키나 눌러주세요.");
            Console.ReadKey();
            box = Enumerable.Repeat(".", 9).ToArray();
            playcount = 0;
        }
    }
}
