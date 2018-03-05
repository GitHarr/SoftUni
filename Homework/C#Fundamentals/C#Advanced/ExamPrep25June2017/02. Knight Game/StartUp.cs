using System;

namespace _02._Knight_Game
{
    public class StartUp
    {
        public static void Main()
        {
            var boardSize = int.Parse(Console.ReadLine());

            char[][] board = new char[boardSize][];

            for (int counter = 0; counter < boardSize; counter++)
            {
                board[counter] = Console.ReadLine().ToCharArray();
            }

            int maxRow = 0;
            int maxColumn = 0;
            int maxAttackedPositions = 0;
            int countOfRemovedKnights = 0;

            do
            {
                if (maxAttackedPositions > 0)
                {
                    board[maxRow][maxColumn] = '0';
                    maxAttackedPositions = 0;
                    countOfRemovedKnights++;
                }

                int currentAttackPosition = 0;
                for (int row = 0; row < boardSize; row++)
                {
                    for (int column = 0; column < boardSize; column++)
                    {
                        if (board[row][column] == 'K')
                        {
                            currentAttackPosition = CalculateAttackPositions(row, column, board);
                            if (currentAttackPosition > maxAttackedPositions)
                            {
                                maxAttackedPositions = currentAttackPosition;
                                maxRow = row;
                                maxColumn = column;
                            }
                        }
                    }
                }
            } while (maxAttackedPositions > 0);

            Console.WriteLine(countOfRemovedKnights);
        }

        static int CalculateAttackPositions(int row, int column, char[][] board)
        {
            var currentPositions = 0;
            if (IsPositionAttacked(row - 2, column - 1, board)) currentPositions++;
            if (IsPositionAttacked(row - 2, column + 1, board)) currentPositions++;
            if (IsPositionAttacked(row - 1, column - 2, board)) currentPositions++;
            if (IsPositionAttacked(row - 1, column + 2, board)) currentPositions++;
            if (IsPositionAttacked(row + 1, column - 2, board)) currentPositions++;
            if (IsPositionAttacked(row + 1, column + 2, board)) currentPositions++;
            if (IsPositionAttacked(row + 2, column - 1, board)) currentPositions++;
            if (IsPositionAttacked(row + 2, column + 1, board)) currentPositions++;
            return currentPositions;
        }

        static bool IsPositionAttacked(int row, int column, char[][] board)
        {
            return IsWitinBoard(row, column, board[0].Length)
                   && board[row][column] == 'K';
        }

        static bool IsWitinBoard(int row, int column, int boardSize)
        {
            return row >= 0 && row < boardSize && column >= 0 && column < boardSize;
        }
    }
}
