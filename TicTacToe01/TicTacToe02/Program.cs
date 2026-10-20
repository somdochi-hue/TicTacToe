using System;
using TicTacToe02;

int playCount = 0;
Gameboard gamboard = new Gameboard();

while (playCount < 10)
{
    gamboard.GameBorad();
    gamboard.Gameplay();
}