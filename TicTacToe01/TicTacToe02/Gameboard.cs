using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TicTacToe02
{
    internal class Gameboard
    {
        private bool player;
        private bool comma;
        private string[] box = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

        public void GameBorad()
        {
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
                string X = Console.ReadLine();
                for (int i = 0; i < box.Length; i++)
                {
                    if (X == box[i])
                    {
                        box[i] = "X";
                        player = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("1부터 9까지의 번호를 입력하세요.");
                    }
                }
            }

            else
            {
                Console.WriteLine("플레이어 O의 차례입니다.");
                Console.Write("위치를 선택하세요 (1~9): ");
                string O = Console.ReadLine();
                for (int i = 0; i < box.Length; i++)
                {
                    if (O == box[i])
                    {
                        box[i] = "O";
                        player = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("1부터 9까지의 번호를 입력하세요.");
                    }
                }
            }
        }
        public bool Winer(string player)
        {
           return (box[0] == player && box[1] == player && box[2] == player) ||
                  (box[3] == player && box[4] == player && box[5] == player) ||
                  (box[6] == player && box[7] == player && box[8] == player) ||
                  (box[0] == player && box[3] == player && box[6] == player) ||
                  (box[1] == player && box[4] == player && box[7] == player) ||
                  (box[2] == player && box[5] == player && box[8] == player) ||
                  (box[0] == player && box[4] == player && box[8] == player) ||
                  (box[2] == player && box[4] == player && box[6] == player);
        }
    }
}
