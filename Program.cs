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
            bool Is_End = true;

            while (Is_End)
            {
                Console.WriteLine("\t\tWelcome to Tic_Tac_Toe Game");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t\t1.Single Player");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t\t2.Two Player");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t\t3.Exit");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Please enter the number of kind the game, you want to play");
                int MenuStartChoose = int.Parse(Console.ReadLine());
                if (MenuStartChoose == 1)
                {
                    Console.Clear();
                    HumanVSCPU c1 = new HumanVSCPU();
                    c1.Play();
                    
                }
                else if (MenuStartChoose == 2)
                {
                    Console.Clear();
                    HumanVSHuman h1 = new HumanVSHuman();
                    h1.Play();
                }
                else if (MenuStartChoose == 3)
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    continue;
                }
            }
        }
    }
    internal class HumanVSHuman
    {
        bool CheckedRow, CheckedCol, CheckedMainDiameter, CheckedMinorDiameter;
        bool Right_Choice;
        const int n = 3;
        char[,] ground = new char[,] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
        char Playersign;
        public HumanVSHuman()
        {

        }
        public void Show_Ground()
        {
            for (int RowGround = 0; RowGround < n; RowGround++)
            {
                for (int ColGround = 0; ColGround < n; ColGround++)
                {
                    if (ground[RowGround, ColGround] == 'X' || ground[RowGround, ColGround] == 'O')
                        Console.Write(ground[RowGround, ColGround]);
                    else
                        Console.Write("_");
                    Console.Write('\t');
                }
                Console.WriteLine('\t');
            }
        }
        public void Play()
        {
            for (int Turn = 0; Turn < n * n; Turn++)
            {
                if (Turn % 2 == 0)
                {
                    Playersign = 'O';
                    Show_Ground();
                    Choose(Turn, Playersign, 'X');
                }
                else
                {
                    Playersign = 'X';
                    Show_Ground();
                    Choose(Turn, Playersign, 'O');

                }
            }
        }
        public void Choose(int PlayerLoop, char CurrentPlayer, char NextPlayer)
        {
            
            Right_Choice = false;
            Console.Clear();
            Console.WriteLine($"it's player '{CurrentPlayer}' turn");
            Console.WriteLine("please choose a positon from the ground of the play");
            Show_Ground();
            char choosepos = char.Parse(Console.ReadLine());
            for (int RowGround = 0; RowGround < n; RowGround++)
            {
                for (int ColGround = 0; ColGround < n; ColGround++)
                {
                    if (ground[RowGround, ColGround] != NextPlayer && choosepos == ground[RowGround, ColGround])
                    {
                        ground[RowGround, ColGround] = CurrentPlayer;
                        Right_Choice = true;
                        break;
                    }
                }
                if (Right_Choice == true)
                    break;
            }
            if (!Right_Choice)
                Choose(PlayerLoop, CurrentPlayer, NextPlayer);
            if (PlayerLoop >= 4)
            {
                Console.Clear();
                Show_Ground();
                CheckedRow = CheckingRow(Playersign);
                if (CheckedRow == true)
                {
                    Win_Message();
                }
                CheckedCol = CheckingCol(Playersign);
                if (CheckedRow == false && CheckedCol == true)
                {
                    Win_Message();
                }
                CheckedMainDiameter = CheckingMainDiameter(Playersign);
                if (CheckedRow == false && CheckedCol == false && CheckedMainDiameter == true)
                {
                    Win_Message();
                }
                CheckedMinorDiameter = CheckingMinorDiameter(Playersign);
                if (CheckedRow == false && CheckedCol == false && CheckedMainDiameter == false && CheckedMinorDiameter == true)
                {
                    Win_Message();
                }
                if (PlayerLoop == 8 && CheckedRow == false && CheckedCol == false && CheckedMainDiameter == false && CheckedMinorDiameter == false)
                {
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("The Result of this game is Equal");
                    Console.WriteLine("to continue please click any key");
                    Console.ReadKey();
                }
            }
        }
        public void Win_Message()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"player '{Playersign}' wins !!!!");
            Console.WriteLine("to continue please click any key");
            Console.ReadKey();
        }
        public bool CheckingRow(char Playersign)
        {
            int RowGround = 0, ColGround = 0;
            while (RowGround <= 2)
            {
                if (ground[RowGround, ColGround] == Playersign && ground[RowGround, ColGround + 1] == Playersign && ground[RowGround, ColGround + 2] == Playersign)
                {
                    return true;
                }
                RowGround++;
            }
            return false;
        }
        public bool CheckingCol(char Playersign)
        {
            int RowGround = 0, ColGround = 0;
            while (ColGround <= 2)
            {
                if (ground[RowGround, ColGround] == Playersign && ground[RowGround + 1, ColGround] == Playersign && ground[RowGround + 2, ColGround] == Playersign)
                    return true;
                ColGround++;
            }
            return false;
        }
        public bool CheckingMainDiameter(char Playersign)
        {
            int RowGround = 0, ColGround = 0;
            if (ground[RowGround, ColGround] == Playersign && ground[RowGround + 1, ColGround + 1] == Playersign && ground[RowGround + 2, ColGround + 2] == Playersign)
                return true;
            return false;
        }
        public bool CheckingMinorDiameter(char Playersign)
        {
            int RowGround = 0, ColGround = 0;
            if (ground[RowGround, ColGround + 2] == Playersign && ground[RowGround + 1, ColGround + 1] == Playersign && ground[RowGround + 2, ColGround] == Playersign)
                return true;
            return false;
        }
    }
    internal class HumanVSCPU
    {
        bool CheckedRow, CheckedCol, CheckedMainDiameter, CheckedMinorDiameter;
        char choosepos;
        char Playersign;
        bool Right_Choice;
        const int n = 3;
        char[,] ground = new char[,] { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
        public void Show_Ground()
        {
            for (int RowGround = 0; RowGround < n; RowGround++)
            {
                for (int ColGround = 0; ColGround < n; ColGround++)
                {
                    if (ground[RowGround, ColGround] == 'X' || ground[RowGround, ColGround] == 'O')
                        Console.Write(ground[RowGround, ColGround]);
                    else
                        Console.Write("_");
                    Console.Write('\t');
                }
                Console.WriteLine('\t');
            }
        }
        public void Play()
        {
            for (int Turn = 0; Turn < 9; Turn++)
            {
                if (Turn % 2 == 0)
                {
                    Playersign = 'O';
                    Show_Ground();
                    Choose(Turn, Playersign, 'X');
                }
                else
                {
                    Playersign = 'X';
                    Show_Ground();
                    Choose(Turn, Playersign, 'O');
                }
            }
        }
        public void Choose(int PlayerLoop, char CurrentPlayer, char NextPlayer)
        {
            Console.Clear();
            Right_Choice = false;
            if(PlayerLoop%2 == 0)
            {
                Console.WriteLine($"it's player '{CurrentPlayer}' turn");
                Console.WriteLine("please choose a positon from the ground of the play");
                Show_Ground();
                choosepos = char.Parse(Console.ReadLine());
            }
            else
            {
                Random rand = new Random();
                string choose = rand.Next(1, 9).ToString();
                choosepos = char.Parse(choose);
            }
            for (int RowGround = 0; RowGround < n; RowGround++)
            {
                for (int ColGround = 0; ColGround < n; ColGround++)
                {
                    if (ground[RowGround, ColGround] != NextPlayer && choosepos == ground[RowGround, ColGround])
                    {
                        ground[RowGround, ColGround] = CurrentPlayer;
                        Right_Choice = true;
                        break;
                    }
                }
                if (Right_Choice == true)
                    break;
            }
            if (!Right_Choice)
                Choose(PlayerLoop, CurrentPlayer, NextPlayer);
            if (PlayerLoop >= 4)
            {
                Console.Clear();
                Show_Ground();
                CheckedRow = CheckingRow(Playersign);
                if (CheckedRow == true)
                {
                    Win_Message();
                }
                CheckedCol = CheckingCol(Playersign);
                if (CheckedRow == false && CheckedCol == true)
                {
                    Win_Message();
                }
                CheckedMainDiameter = CheckingMainDiameter(Playersign);
                if (CheckedRow == false && CheckedCol == false && CheckedMainDiameter == true)
                {
                    Win_Message();
                }
                CheckedMinorDiameter = CheckingMinorDiameter(Playersign);
                if (CheckedRow == false && CheckedCol == false && CheckedMainDiameter == false && CheckedMinorDiameter == true)
                {
                    Win_Message();
                }
                if(PlayerLoop == 8 && CheckedRow == false && CheckedCol == false && CheckedMainDiameter == false && CheckedMinorDiameter == false )
                {
                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("The Result of this game is Equal");
                    Console.WriteLine("to continue please click any key");
                    Console.ReadKey();
                }
            }
        }
        public void Win_Message()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"player '{Playersign}' wins !!!!");
            Console.WriteLine("to continue please click any key");
            Console.ReadKey();
        }
        public bool CheckingRow(char Playersign)
        {
            int RowGround = 0, ColGround = 0;
            while (RowGround <= 2)
            {
                if (ground[RowGround, ColGround] == Playersign && ground[RowGround, ColGround + 1] == Playersign && ground[RowGround, ColGround + 2] == Playersign)
                {
                    return true;
                }
                RowGround++;
            }
            return false;
        }
        public bool CheckingCol(char Playersign)
        {
            int RowGround = 0, ColGround = 0;
            while (ColGround <= 2)
            {
                if (ground[RowGround, ColGround] == Playersign && ground[RowGround + 1, ColGround] == Playersign && ground[RowGround + 2, ColGround] == Playersign)
                {
                    return true;
                }
                ColGround++;
            }
            return false;
        }
        public bool CheckingMainDiameter(char Playersign)
        {
            int RowGround = 0, ColGround = 0;
            if (ground[RowGround, ColGround] == Playersign && ground[RowGround + 1, ColGround + 1] == Playersign && ground[RowGround + 2, ColGround + 2] == Playersign)
            {
                return true;
            }
            return false;   
        }
        public bool CheckingMinorDiameter(char Playersign)
        {
            int RowGround = 0, ColGround = 0;
            if (ground[RowGround, ColGround + 2] == Playersign && ground[RowGround + 1, ColGround + 1] == Playersign && ground[RowGround + 2, ColGround] == Playersign)
                return true;
            return false;   
        }
    }
}



