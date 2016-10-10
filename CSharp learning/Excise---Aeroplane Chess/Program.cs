using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excise___Aeroplane_Chess
{
    class Program
    {
        public static int[] Maps = new int[100];         //存储地图
        public static int[] PlayerPos = new int[2];      //玩家坐标
        public static string nameOfPlayerA, nameOfPlayerB;
        public static int[] luckyturn = { 6, 23, 40, 55, 69, 83 };                     //幸运轮盘◎
        public static int[] landMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };           //地雷☆
        public static int[] pause = { 9, 27, 60, 93 };                               //暂停▲
        public static int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };            //时空隧道卐
        static void Main(string[] args)
        {
            /*
            1、画游戏头
            2、初始化地图(加载地图所需要的资源)
            3、画地图
            4、玩游戏   


                游戏规则：
                如果玩家A踩到了玩家B 玩家B退6格
                踩到了地雷 退6格
                踩到了时空隧道 进10格
                踩到了幸运轮盘 1交换位置  2 轰炸对方 使对方退6格
                踩到了暂停 暂停一回合
                踩到了方块 神马都不干
            */
            GameHead();
            #region 输入玩家姓名
            do
            {
                Console.WriteLine("请输入玩家A姓名：");
                nameOfPlayerA = Console.ReadLine();
                if (nameOfPlayerA == "")
                {
                    Console.WriteLine("姓名不能为空，请重新输入...");
                    continue;
                }
                else
                {
                    break;
                }

            } while (true);

            do
            {
                Console.WriteLine("请输入玩家B姓名：");
                nameOfPlayerB = Console.ReadLine();
                if (nameOfPlayerB == "")
                {
                    Console.WriteLine("姓名不能为空，请重新输入...");
                    continue;
                }
                else if (nameOfPlayerB == nameOfPlayerA)
                {
                    Console.WriteLine("不能重名，请重新输入...");
                }
                else
                {
                    break;
                }

            } while (true);
            #endregion
            Console.Clear();

            GameHead();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("对战开始...");
            Console.WriteLine("玩家{0}用A表示",nameOfPlayerA);
            Console.WriteLine("玩家{0}用B表示", nameOfPlayerB);
            
            Console.WriteLine();
            
            InitialMaps();
            DrawMaps();
            Console.ReadKey();

            #region 玩游戏
            while (PlayerPos[0] < 99 && PlayerPos[1] < 99)
            {
                Console.Clear();
                DrawMaps();
                ThrowDice(0);
                ChangePos(0);
                if (PlayerPos[0] > 99)
                {

                    break;
                }
                Console.Clear();

                DrawMaps();
                ThrowDice(1);
                ChangePos(1);
                Console.Clear();
                DrawMaps();
                if (PlayerPos[0] > 99)
                {
                    break;
                }
                Console.ReadKey(true);                                        //玩家输入的内容不显示在控制台中。
            }
            #endregion

            if (PlayerPos[0]>PlayerPos[1])
            {
                Console.WriteLine("恭喜！玩家{0}胜利了",nameOfPlayerA);
            }
            else
            {
                Console.WriteLine("恭喜！玩家{0}胜利了", nameOfPlayerB);
            }
            
            Console.WriteLine("游戏结束");
            Console.ReadKey();
        }

        public static void GameHead()
        {
            Console.ForegroundColor = ConsoleColor.Blue;                              //给每一行的字上色。
            Console.WriteLine("***************************************************");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("***************************************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***************************************************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("******* Aeroplane Chess --v 1.0 by Chalie *********");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("***************************************************");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("***************************************************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("***************************************************");
        }
        /// <summary>
        /// 初始化数组。
        /// </summary>
        public static void InitialMaps()
        {
            //初始化地图   Map[6]=1
            //我用0表示普通,显示给用户就是 □
            //....1...幸运轮盘,显示组用户就◎ 
            //....2...地雷,显示给用户就是 ☆
            //....3...暂停,显示给用户就是 ▲
            //....4...时空隧道,显示组用户就 卐
            //幸运轮盘◎
            for (int i = 0; i < luckyturn.Length; i++)
            {
                Maps[luckyturn[i]] = 1;
            }
            //地雷☆
            for (int i = 0; i < landMine.Length; i++)
            {
                Maps[landMine[i]] = 2;
            }
            //暂停▲
            for (int i = 0; i < pause.Length; i++)
            {
                Maps[pause[i]] = 3;
            }
            //时空隧道卐
            for (int i = 0; i < timeTunnel.Length; i++)
            {
                Maps[timeTunnel[i]] = 4;
            }
        }

        public static void DrawMaps()
        {
            Console.WriteLine("图例：幸运轮盘：◎    地雷：☆    暂停：▲    时空隧道：卐");
            #region 第一横行
            for (int i = 0; i < 30; i++)
            {
                if (PlayerPos[0] == PlayerPos[1] && PlayerPos[1] == i)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("<>");
                }
                else if (PlayerPos[0] == i)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Ａ");　　　　　　　　　　　　　　　　　 //shift+空格 切换全角/半角  两个半角占位等于一个全角
                }
                else if (PlayerPos[1] == i)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Ｂ");
                }
                else
                {
                    Console.Write(PrintLables(Maps[i]));
                } 
            }
            #endregion

            Console.WriteLine();                                                              //另起一行

            #region 第一竖行
            for (int i = 30; i < 35; i++)
            {
                Console.Write("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");    
                if (PlayerPos[0] == PlayerPos[1] && PlayerPos[1] == i)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("<>");
                }
                else if (PlayerPos[0] == i)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Ａ");　　　　　　　　　　　　　　　　　 
                }
                else if (PlayerPos[1] == i)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Ｂ");
                }
                else
                {
                    Console.Write(PrintLables(Maps[i]));
                }
                Console.WriteLine();

            }
            #endregion

            #region 第二横行
            for (int i = 64; i > 34; i--)                                  
            {
                if (PlayerPos[0] == PlayerPos[1] && PlayerPos[1] == i)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("<>");
                }
                else if (PlayerPos[0] == i)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Ａ");　　　　　　　　　　　　　　　　　
                }
                else if (PlayerPos[1] == i)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Ｂ");
                }
                else
                {
                    Console.Write(PrintLables(Maps[i]));
                }
            }
            #endregion

            Console.WriteLine();

            #region 第二竖行
            for (int i = 65; i < 70; i++)                                  //打印第二竖行
            {
                if (PlayerPos[0] == PlayerPos[1] && PlayerPos[1] == i)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("<>");
                }
                else if (PlayerPos[0] == i)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Ａ");
                }
                else if (PlayerPos[1] == i)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Ｂ");
                }
                else
                {
                    Console.Write(PrintLables(Maps[i]));
                }
                Console.Write("　　　　　　　　　　　　　　　　　　　　　　　　　　　　　");
                Console.WriteLine();
            }
            #endregion


            #region 第三横行
            for (int i = 70; i < 100; i++)                                 //打印第三横行
            {
                if (PlayerPos[0] == PlayerPos[1] && PlayerPos[1] == i)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("<>");
                }
                else if (PlayerPos[0] == i)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Ａ");
                }
                else if (PlayerPos[1] == i)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Ｂ");
                }
                else
                {
                    Console.Write(PrintLables(Maps[i]));
                }
            }
            #endregion
            Console.WriteLine();


        }
/// <summary>
/// 将Maps数组中的对于的元素打印成不同的符号
/// </summary>
/// <param name="i"></param>
        public static char PrintLables(int i)
        {
            switch (i)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    return '◎';
                    
                case 2:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    return '☆';
                   
                case 3:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    return '▲';
                  
                case 4:
                    Console.ForegroundColor = ConsoleColor.Red;
                    return '卐';
                    
                default:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    return '□';
                    
                }
        }
        /// <summary>
        /// 掷骰子
        /// </summary>
        /// <param name="i"></1代表玩家A，2代表玩家B>
        public static void ThrowDice(int i)
        {
            Random ss = new Random();
            int randNum = ss.Next(1, 6);
            switch (i)
            {
                case 0:
                    Console.WriteLine("{0}按任意键开始掷骰子", nameOfPlayerA);
                    Console.ReadKey(true);                                              //按任意键的内容不显示在屏幕上
                    PlayerPos[0] += randNum;
                    Console.WriteLine("{0}掷出了{1}", nameOfPlayerA, randNum);
                    Console.WriteLine("玩家{0}请按任意键开始行动", nameOfPlayerA);
                    Console.ReadKey(true);
                    Console.WriteLine("玩家{0}行动完了", nameOfPlayerA);
                    Console.ReadKey(true);
                    return;
                case 1:
                    Console.WriteLine("{0}按任意键开始掷骰子", nameOfPlayerB);
                    Console.ReadKey(true);                                              //按任意键的内容不显示在屏幕上
                    PlayerPos[1] += randNum;
                    Console.WriteLine("{0}掷出了{1}", nameOfPlayerB, randNum);
                    Console.WriteLine("玩家{0}请按任意键开始行动", nameOfPlayerB);
                    Console.ReadKey(true);
                    Console.WriteLine("玩家{0}行动完了", nameOfPlayerB);
                    Console.ReadKey(true);
                    return;
            }
            
        }
        public static void ChangePos(int i)
        {
            if (luckyturn.Contains(PlayerPos[i]))                                //猜中幸运轮盘，多掷一次
            {
                Console.Clear();
                DrawMaps();
                ThrowDice(i);
                ChangePos(i);
                return;
                }
            else if (landMine.Contains(PlayerPos[i]))                         //踩地雷，退后三步
            {
                PlayerPos[i] -= 3;
                return;
            }
            else if (pause.Contains(PlayerPos[i]))                             //暂停 对方掷两次
            {
                if (i==0)
                {
                    Console.Clear();
                    DrawMaps();
                    ThrowDice(1);
                    ChangePos(1);

                    if (pause.Contains(PlayerPos[i]))                    //如果对方第一次也走到暂停位置上了，则不扔第二次。
                    {
                        return;
                    }
                    else
                    {
                        Console.Clear();
                        DrawMaps();
                        ThrowDice(1);
                        ChangePos(1);
                        return;
                    }
                    
                }
                else
                {
                    Console.Clear();
                    DrawMaps();
                    ThrowDice(0);
                    ChangePos(0);
                    return;
                }
            }
            else if (timeTunnel.Contains(PlayerPos[i]))                   //时光隧道，直接传送到下一个点
            {
                if (Array.IndexOf(timeTunnel, PlayerPos[i]) < timeTunnel.Length-1)                          //如果是最后一个元素就无法再前进，保持原地不动。
                {
                    PlayerPos[i] = timeTunnel[Array.IndexOf(timeTunnel, PlayerPos[i]) + 1];
                    return;
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }

    }
}
