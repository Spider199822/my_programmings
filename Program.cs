using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            humanvscpu s1 = new humanvscpu();
            s1.play();






        }

    }
    internal class humanvshuman
    {
        //h1vsh2 the we have turn and h1 is false and h2 true then choose after 4 turn each player needs to check the state so call that function 

        
        char[,] ground = new char[,] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
        char player1 = 'O';
        char player2 = 'X';
        bool turn;
        bool flag;
        public humanvshuman()
        {
            
        }
        public void show_ground()
        {
            for (int k = 0; k < 3; k++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(ground[k, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        public void play()
        {
            for(int i=0;i<9;i++)
            {
                if(i%2==0)
                {
                    show_ground();
                    Console.WriteLine("it's player1 turn");
                    Console.WriteLine("please choose a positon from the ground of the play");
                    char choosepos = char.Parse(Console.ReadLine());
                    for(int j = 0; j<3;j++)
                    {
                        for(int k = 0; k<3;k++)
                        {
                            if (ground[j, k] != player2 && choosepos == ground[j, k])
                                ground[j, k] = player1;
                        }
                    }
                }
                else
                {
                    show_ground();
                    Console.WriteLine("it's player2 turn");
                    Console.WriteLine("please choose a positon from the ground of the play");
                    char choosepos = char.Parse(Console.ReadLine());
                    for (int j = 0; j < 3; j++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            if (ground[j, k] != player1 && choosepos == ground[j, k])
                                ground[j, k] = player2;
                        }
                    }
                    
                }
                if (i >= 4 && i%2 == 0)
                {
                    turn = true;
                    checking_for_win();
                }
                else if(i>=4 && i%2 == 1)
                {
                    turn = false;
                    checking_for_win();
                }
                if (flag)
                    break;
                else if(flag == false && i == 8)
                {
                    Console.WriteLine("the game is equal no one wins!!!!");
                    break;
                }
            }
            

        }
        public void checking_for_win()
        {
            if (turn)

            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (i >= 0 && i <= 2 && j >= 0 && j <= 2 && i + 1 >= 0 && i + 1 <= 2 && j + 1 >= 0 && j + 1 <= 2 && i + 2 >= 0 && i + 2 <= 2 && j + 2 >= 0 && j + 2 <= 2 && ground[i, j] == 'O' && ground[i, j + 1] == 'O' && ground[i, j + 2] == 'O')
                        {
                            Console.WriteLine("player1 wins !!!!");
                            flag = true;
                            break;

                        }

                        else if (i >= 0 && i <= 2 && j >= 0 && j <= 2 && i + 1 >= 0 && i + 1 <= 2 && j + 1 >= 0 && j + 1 <= 2 && i + 2 >= 0 && i + 2 <= 2 && j + 2 >= 0 && j + 2 <= 2 && ground[i, j] == 'O' && ground[i + 1, j] == 'O' && ground[i + 2, j] == 'O')
                        {
                            Console.WriteLine("player1 wins!!!");
                            flag = true;
                            break;
                        }

                        else if (i >= 0 && i <= 2 && j >= 0 && j <= 2 && i + 1 >= 0 && i + 1 <= 2 && j + 1 >= 0 && j + 1 <= 2 && i + 2 >= 0 && i + 2 <= 2 && j + 2 >= 0 && j + 2 <= 2 && ground[i, j] == 'O' && ground[i + 1, j + 1] == 'O' && ground[i + 2, j + 2] == 'O')
                        {
                            Console.WriteLine("player1 wins !!!!");
                            flag = true;
                            break;
                        }

                        else if (i >= 0 && i <= 2 && j >= 0 && j <= 2 && i + 1 >= 0 && i + 1 <= 2 && j + 1 >= 0 && j + 1 <= 2 && i + 2 >= 0 && i + 2 <= 2 && j + 2 >= 0 && j + 2 <= 2 && ground[i, j + 2] == 'O' && ground[i + 1, j + 1] == 'O' && ground[i + 2, j] == 'O')
                        {
                            Console.WriteLine("player1 wins!!!!");
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                        break;

                }
            }
            else if(!turn)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (i >= 0 && i <= 2 && j >= 0 && j <= 2 && i + 1 >= 0 && i + 1 <= 2 && j + 1 >= 0 && j + 1 <= 2 && i + 2 >= 0 && i + 2 <= 2 && j + 2 >= 0 && j + 2 <= 2 && ground[i, j] == 'X' && ground[i, j + 1] == 'X' && ground[i, j + 2] == 'X')
                        {
                            Console.WriteLine("player2 wins !!!!");
                            flag = true;
                            break;

                        }

                        else if (i >= 0 && i <= 2 && j >= 0 && j <= 2 && i + 1 >= 0 && i + 1 <= 2 && j + 1 >= 0 && j + 1 <= 2 && i + 2 >= 0 && i + 2 <= 2 && j + 2 >= 0 && j + 2 <= 2 && ground[i, j] == 'X' && ground[i + 1, j] == 'X' && ground[i + 2, j] == 'X')
                        {
                            Console.WriteLine("player2 wins!!!");
                            flag = true;
                            break;
                        }

                        else if (i >= 0 && i <= 2 && j >= 0 && j <= 2 && i + 1 >= 0 && i + 1 <= 2 && j + 1 >= 0 && j + 1 <= 2 && i + 2 >= 0 && i + 2 <= 2 && j + 2 >= 0 && j + 2 <= 2 && ground[i, j] == 'X' && ground[i + 1, j + 1] == 'X' && ground[i + 2, j + 2] == 'X')
                        {
                            Console.WriteLine("player2 wins !!!!");
                            flag = true;
                            break;
                        }

                        else if (i >= 0 && i <= 2 && j >= 0 && j <= 2 && i + 1 >= 0 && i + 1 <= 2 && j + 1 >= 0 && j + 1 <= 2 && i + 2 >= 0 && i + 2 <= 2 && j + 2 >= 0 && j + 2 <= 2 && ground[i, j + 2] == 'X' && ground[i + 1, j + 1] == 'X' && ground[i + 2, j] == 'X')
                        {
                            Console.WriteLine("player2 wins!!!!");
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                        break;

                }
            }
            
        }
    }


    internal class humanvscpu
    {


        char[,] ground = new char[,] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
        char player1 = 'O';
        char cpu = 'X';
        bool flag;
        bool turn;
        public void show_ground()
        {
            for (int k = 0; k < 3; k++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(ground[k, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        public void play()
        {
            for (int i = 0; i < 9; i++)
            {
                if (i % 2 == 0)
                {
                    show_ground();
                    Console.WriteLine("it's player1 turn");
                    Console.WriteLine("please choose a positon from the ground of the play");
                    char choosepos = char.Parse(Console.ReadLine());
                    for (int j = 0; j < 3; j++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            if (ground[j, k] != cpu && choosepos == ground[j, k])
                                ground[j, k] = player1;
                        }
                    }
                    
                }
                else
                {
                    show_ground();
                    Console.WriteLine("it's computer's turn");
                    Random rand = new Random();
                    string choose = rand.Next(1, 9).ToString();
                    char choosepos = char.Parse(choose);

                    for (int j = 0; j < 3; j++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            if (ground[j, k] != player1 && choosepos == ground[j, k])
                                ground[j, k] = cpu;
                            else if(ground[j,k] == player1)
                            {

                            }
                        }
                    }
                }
                if (i >= 4 && i % 2 == 0)
                {
                    turn = true;
                    checking_for_win();
                }
                else if (i >= 4 && i % 2 == 1)
                {
                    turn = false;
                    checking_for_win();
                }
                if (flag)
                    break;
                else if (flag == false && i == 8)
                {
                    Console.WriteLine("the game is equal no one wins!!!!");
                    break;
                }
            }

        }
        public void checking_for_win()
        {
            if (turn)

            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (i >= 0 && i <= 2 && j >= 0 && j <= 2 && i + 1 >= 0 && i + 1 <= 2 && j + 1 >= 0 && j + 1 <= 2 && i + 2 >= 0 && i + 2 <= 2 && j + 2 >= 0 && j + 2 <= 2 && ground[i, j] == 'O' && ground[i, j + 1] == 'O' && ground[i, j + 2] == 'O')
                        {
                            Console.WriteLine("player1 wins !!!!");
                            flag = true;
                            break;

                        }

                        else if (i >= 0 && i <= 2 && j >= 0 && j <= 2 && i + 1 >= 0 && i + 1 <= 2 && j + 1 >= 0 && j + 1 <= 2 && i + 2 >= 0 && i + 2 <= 2 && j + 2 >= 0 && j + 2 <= 2 && ground[i, j] == 'O' && ground[i + 1, j] == 'O' && ground[i + 2, j] == 'O')
                        {
                            Console.WriteLine("player1 wins!!!");
                            flag = true;
                            break;
                        }

                        else if (i >= 0 && i <= 2 && j >= 0 && j <= 2 && i + 1 >= 0 && i + 1 <= 2 && j + 1 >= 0 && j + 1 <= 2 && i + 2 >= 0 && i + 2 <= 2 && j + 2 >= 0 && j + 2 <= 2 && ground[i, j] == 'O' && ground[i + 1, j + 1] == 'O' && ground[i + 2, j + 2] == 'O')
                        {
                            Console.WriteLine("player1 wins !!!!");
                            flag = true;
                            break;
                        }

                        else if (i >= 0 && i <= 2 && j >= 0 && j <= 2 && i + 1 >= 0 && i + 1 <= 2 && j + 1 >= 0 && j + 1 <= 2 && i + 2 >= 0 && i + 2 <= 2 && j + 2 >= 0 && j + 2 <= 2 && ground[i, j + 2] == 'O' && ground[i + 1, j + 1] == 'O' && ground[i + 2, j] == 'O')
                        {
                            Console.WriteLine("player1 wins!!!!");
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                        break;

                }
            }
            else if (!turn)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (i >= 0 && i <= 2 && j >= 0 && j <= 2 && i + 1 >= 0 && i + 1 <= 2 && j + 1 >= 0 && j + 1 <= 2 && i + 2 >= 0 && i + 2 <= 2 && j + 2 >= 0 && j + 2 <= 2 && ground[i, j] == 'X' && ground[i, j + 1] == 'X' && ground[i, j + 2] == 'X')
                        {
                            Console.WriteLine("cpu wins !!!!");
                            flag = true;
                            break;

                        }

                        else if (i >= 0 && i <= 2 && j >= 0 && j <= 2 && i + 1 >= 0 && i + 1 <= 2 && j + 1 >= 0 && j + 1 <= 2 && i + 2 >= 0 && i + 2 <= 2 && j + 2 >= 0 && j + 2 <= 2 && ground[i, j] == 'X' && ground[i + 1, j] == 'X' && ground[i + 2, j] == 'X')
                        {
                            Console.WriteLine("cpu wins!!!");
                            flag = true;
                            break;
                        }

                        else if (i >= 0 && i <= 2 && j >= 0 && j <= 2 && i + 1 >= 0 && i + 1 <= 2 && j + 1 >= 0 && j + 1 <= 2 && i + 2 >= 0 && i + 2 <= 2 && j + 2 >= 0 && j + 2 <= 2 && ground[i, j] == 'X' && ground[i + 1, j + 1] == 'X' && ground[i + 2, j + 2] == 'X')
                        {
                            Console.WriteLine("cpu wins !!!!");
                            flag = true;
                            break;
                        }

                        else if (i >= 0 && i <= 2 && j >= 0 && j <= 2 && i + 1 >= 0 && i + 1 <= 2 && j + 1 >= 0 && j + 1 <= 2 && i + 2 >= 0 && i + 2 <= 2 && j + 2 >= 0 && j + 2 <= 2 && ground[i, j + 2] == 'X' && ground[i + 1, j + 1] == 'X' && ground[i + 2, j] == 'X')
                        {
                            Console.WriteLine("cpu wins!!!!");
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                        break;

                }
            }

        }
    }
}
   

