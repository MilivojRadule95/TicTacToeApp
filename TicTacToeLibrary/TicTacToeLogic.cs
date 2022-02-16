﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLibrary
{
    public class TicTacToeLogic
    {
        public enum GridSpotStatus
        {
            N,
            X,
            O
        }

        private GridSpotStatus[] grid = new GridSpotStatus[9];

        public GridSpotStatus GetWinner()
        {
            //If X is a winner

            if (grid[0] == GridSpotStatus.X && grid[1] == GridSpotStatus.X && grid[2] == GridSpotStatus.X)
            {
                return GridSpotStatus.X;
            }

            if (grid[3] == GridSpotStatus.X && grid[4] == GridSpotStatus.X && grid[5] == GridSpotStatus.X)
            {
                return GridSpotStatus.X;
            }

            if (grid[6] == GridSpotStatus.X && grid[7] == GridSpotStatus.X && grid[8] == GridSpotStatus.X)
            {
                return GridSpotStatus.X;
            }

            if (grid[0] == GridSpotStatus.X && grid[3] == GridSpotStatus.X && grid[6] == GridSpotStatus.X)
            {
                return GridSpotStatus.X;
            }

            if (grid[1] == GridSpotStatus.X && grid[4] == GridSpotStatus.X && grid[7] == GridSpotStatus.X)
            {
                return GridSpotStatus.X;
            }

            if (grid[2] == GridSpotStatus.X && grid[5] == GridSpotStatus.X && grid[8] == GridSpotStatus.X)
            {
                return GridSpotStatus.X;
            }

            if (grid[0] == GridSpotStatus.X && grid[4] == GridSpotStatus.X && grid[8] == GridSpotStatus.X)
            {
                return GridSpotStatus.X;
            }

            if (grid[2] == GridSpotStatus.X && grid[4] == GridSpotStatus.X && grid[6] == GridSpotStatus.X)
            {
                return GridSpotStatus.X;
            }


            //If O is a winner

            if (grid[0] == GridSpotStatus.O && grid[1] == GridSpotStatus.O && grid[2] == GridSpotStatus.O) 
            {
                return GridSpotStatus.O;
            }

            if (grid[3] == GridSpotStatus.O && grid[4] == GridSpotStatus.O && grid[5] == GridSpotStatus.O)
            {
                return GridSpotStatus.O;
            }

            if (grid[6] == GridSpotStatus.O && grid[7] == GridSpotStatus.O && grid[8] == GridSpotStatus.O)
            {
                return GridSpotStatus.O;
            }

            if (grid[0] == GridSpotStatus.O && grid[3] == GridSpotStatus.O && grid[6] == GridSpotStatus.O)
            {
                return GridSpotStatus.O;
            }

            if (grid[1] == GridSpotStatus.O && grid[4] == GridSpotStatus.O && grid[7] == GridSpotStatus.O)
            {
                return GridSpotStatus.O;
            }

            if (grid[2] == GridSpotStatus.O && grid[5] == GridSpotStatus.O && grid[8] == GridSpotStatus.O)
            {
                return GridSpotStatus.O;
            }

            if (grid[0] == GridSpotStatus.O && grid[4] == GridSpotStatus.O && grid[8] == GridSpotStatus.O)
            {
                return GridSpotStatus.O;
            }

            if (grid[2] == GridSpotStatus.O && grid[4] == GridSpotStatus.O && grid[6] == GridSpotStatus.O)
            {
                return GridSpotStatus.O;
            }

            return GridSpotStatus.N;
        }

        public bool IsGameOver()
        {
            if (GetWinner() == GridSpotStatus.X)
            {
                return true;
            }

            if (GetWinner() == GridSpotStatus.O)
            {
                return true;
            }

            if (IsGridFull() == true)
            {
                return true;
            }

            return false;
        }

        private bool IsGridFull()
        {
            for (int i = 0; i < grid.Length; i++)
            {
                if (grid[i] == GridSpotStatus.N)
                {
                    return false;
                }
            }
            return true;
        }



    }
}
