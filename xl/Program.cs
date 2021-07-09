using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xl
{
    class Program
    {
        static Boolean test = true;
        static string exit = "no";
        static Random random = new Random();

        static int readrandom() {
            var return_01 = random.Next(0,20);
            return return_01;
        }//
        static int input_N = 0;//输入数

        static void Main(string[] args)
        {
            int Number_ = readrandom();
            Console.WriteLine("请输入一0-20的数字开始游戏！");
            if (test)
            {
                Console.WriteLine(Number_);
            }
            while (exit != "exit") {
                input_N++;
                var user_input = Console.ReadLine();
                int inputNumber = int.Parse(user_input);
                //调试代码 
               

                if (inputNumber == Number_)
                {
                    Console.WriteLine($"恭喜你第 {input_N} 次答对了,错误了 {--input_N} 次");
                    exit = "exit";
                }
                else
                {
                    if (inputNumber < Number_) { Console.WriteLine("你输入的小了"); }
                    if (inputNumber > Number_) { Console.WriteLine("你输入的大了"); }
                    Console.WriteLine("请再次输入");
                }
            }
            Console.ReadLine();
        }
    }
}
