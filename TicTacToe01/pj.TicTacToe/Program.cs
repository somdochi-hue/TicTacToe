using System;

int[,] box = new int[3, 3];
bool[,] star = new bool[3, 3];
int playCount = 0;
int completCount = 0;

while (playCount < 9 && completCount == 3)
{
    Console.Clear();
    PrintBoard(box, star);

    Console.Write("1P 행 입력: ");
    int row1 = int.Parse(Console.ReadLine()) - 1;
    Console.Write("1P 열 입력: ");

    int col1 = int.Parse(Console.ReadLine()) - 1;

    star[row1, col1] = true;

    Console.Clear();
    PrintBoard(box, star);

    Console.Write("2P 행 입력: ");
    int row2 = int.Parse(Console.ReadLine()) - 1;
    Console.Write("2P 열 입력: ");

    int col2 = int.Parse(Console.ReadLine()) - 1;

    if ((row1 == row2 && col1 == col2) || star[row2, col2])
    {
        Console.WriteLine("잘못된 선택입니다.");
        star[row1, col1] = false;
        playCount++;

        Console.ReadKey();
        continue;
    }

    star[row2, col2] = true;


    Console.Clear();
    PrintBoard(box, star);


    if (box[row1, col1])

        Console.Clear();
    if (completCount == 3)
    {
        Console.WriteLine("승리!");
    }

    if (playCount == 9)
    {
        Console.WriteLine("시도 횟수(9회)를 모두 소비했습니다. \n 게임오버");

    }
}

void PrintBoard(int[,] box, bool[,] star)
{
    for (int row = 0; row < 3; row++)
    {
        for (int col = 0; col < 3; col++)
        {
            if (star[row, col])
            {
                Console.Write($"[ {box[row, col]} ]\t");
            }
            else
            {
                Console.Write(" . |");
            }
            Console.WriteLine();
        }
    }
}