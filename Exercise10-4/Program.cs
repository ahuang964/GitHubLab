using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] chessboard = new string[8,8];
            //string assign = "white";
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        chessboard[i, j] = "white";
                    }
                    //look left
                    else if (j != 0)
                    {
                        if (chessboard[i, j - 1] == "white")
                        {
                            chessboard[i, j] = "black";
                        }
                        else
                        {
                            chessboard[i, j] = "white";
                        }
                    }
                    //look up
                    else if (j == 0)
                    {
                        if (chessboard[i - 1, j] == "white")
                        {
                            chessboard[i, j] = "black";
                        }
                        else
                        {
                            chessboard[i, j] = "white";
                        }
                    }


                }
            }


            ////dobule check
            //for (int i = 0; i < 8; i++)
            //{
            //    Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}",chessboard[i,0],chessboard[i,1],chessboard[i,2],chessboard[i,3],chessboard[i,4],chessboard[i,5],chessboard[i,6],chessboard[i,7]);
            //}

            Console.WriteLine("Enter x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(chessboard[x, y]);
        }
    }
}
