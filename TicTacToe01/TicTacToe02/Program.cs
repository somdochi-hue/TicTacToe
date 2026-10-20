using System;
using TicTacToe02;

bool[] comma = new bool[9];
bool[] extraction = new bool[9];
bool[] circle = new bool[9];
int playCount = 0;
int completCount = 0;
Gameboard gamboard = new Gameboard();

while (playCount < 10)
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
    gamboard.GameBorad();
    gamboard.Gameplay();
}
