using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello  Word");
            // Console.ReadKey();
            //占位符
            //int n1 = 10;
            //int n2 = 20;
            //int n3 = 30;
            //Console.WriteLine("第一个是{1},第二个是{0}，第三个是{2}", n1, n2, n3);
            //Console.WriteLine("第一个数字是：" + n1 + "第二个数字是：" + n2 + "第三个数字是：" + n3);
            //Console.ReadKey();

            ////定义四个变量，分别存储一个人的姓名、性别（Gender）、年龄、电话
            ////(Telephonenumber)。然后打印在屏幕上（我叫X，今年X岁了，我X生，我的电话是
            //// XX)(电话号是什么类型，如：010-12345)
            //string name = "张三";
            //char Gender = '男';
            //int age = 20;
            //string Tel = "010-12345";
            //Console.WriteLine("我叫{0},今年{2}岁了，我是{1}生，我的电话是{3}", name, Gender, age, Tel);
            //Console.ReadKey();

            //交换变量
            //交换两个int行的变量，要求不使用第三方变量
            //int n1 = 30;
            //int n2 = 70;
            //n1 = n1 + n2;
            //n2 = n1 - n2;
            //n1 = n1 - n2;

            //Console.WriteLine("输出的两个变量是{0},{1}", n1, n2);
            //Console.ReadKey();

            ////接收用户的输入
            //Console.WriteLine("请输入你的姓名");

            //string name = Console.ReadLine();
            //Console.Write("您的姓名是:{0}", name);
            //Console.ReadKey();

            ////问用户喜欢吃什么水果，假如用户输入“苹果”，则显示“哈哈，我也喜欢吃苹果”
            //Console.WriteLine("请输入您喜欢吃的水果：");
            //string fruit = Console.ReadLine();
            //Console.WriteLine("哈哈，我也喜欢吃{0}", fruit);
            //Console.ReadKey();
            //请用户输入姓名性别年龄，当用户按下某个键后在屏幕上显示：您好：XX 您的年龄是
            // XX ,您的性别是：X生。
            //Console.WriteLine("请您的输入姓名：");
            //string name = Console.ReadLine();

            //Console.WriteLine("请输入您的性别：");
            //string Gender = Console.ReadLine();

            //Console.WriteLine("请输入您的年龄");
            //string age = Console.ReadLine();

            //Console.WriteLine("{0}，您的性别是{1}，您的年龄是{2}", name, Gender, age);
            //Console.ReadKey();

            //C#中的转义符
            // \n表示换行    \"表示一个英文半角的双引号
            // \t表示一个Tab键的空格  \b放在字符串的两端，表示一个退格键
            // \r\n 表示Windows能够识别\n   \\表示能够输出\ 
            // @ 1、表示取消\在字符串中的转义作用，使其单纯地表示一个\  2、将字符串按照原格式输出

            //Console.WriteLine("我想在这句话中输出一个\"英文半角的双引号");
            //Console.ReadKey();

            string str = "今天天气好晴朗\r\n处处好风光";

            System.IO.File.WriteAllText(@"C:\Users\Ma Chenlu\Desktop\111.txt", str);
            Console.WriteLine("写入成功");
            Console.ReadKey();

            //string path = @"F:\最优化方法\a\b\c\小泽玛利亚.avi";
            //Console.WriteLine(path);
            //Console.ReadKey();

            // 算术运算符和算术表达式
            // + - * \ %


            // 类型转换
            //隐式类型转换
            // 我们要求等号两边参与运算的操作数的类型必须一直，如果不一致，满足下列条件
            // 会发生自动类型转换，或称之为隐式类型转换。
            //两种类型兼容
            //例如：int 和 double 兼容（都是数字类型）
            //目标大于源类型
            //例如 double > int

            // 显式类型转换
            //要满足的条件：
            //1、两种类型相兼容  int---double
            //2、大的转成小的   double -- int
            //语法
            //（待转换的类型）要转换的值；


            //计算半径为5的圆的面积和周长
            //int r = 5;
            //double area = 3.14 * r * r;
            //double perimeter = 2 * 3.14 * r;
            //Console.WriteLine("圆的面积是{0}，圆的周长是{1}", area, perimeter);
            //Console.ReadKey();

            ////某商店T恤的价格为35元/件，裤子的价格为120元/条，小明在该商店买了3件T恤和2条裤子
            ////请计算并显示小明应该付多少钱，打折8.8之后呢？

            //int T_shirt = 35;
            //int trousers = 120;

            //double price = 3 * T_shirt + 2 * trousers;
            //double discount = price * 0.88;
            //Console.WriteLine("价格是{0}，打折后是{1}", price, discount);
            //Console.ReadKey();

            //int number = 10;
            //double d = number; //小的转大的， 自动类型转换，隐式类型转换

            //double d = 303.6;
            ////int num = d;  //大的转小的，  强制类型转换，显式类型转换
            //int n = (int)d;
            //Console.WriteLine(n);
            //Console.ReadKey();

            //int n1 = 10;
            //int n2 = 3;
            //double d = n1*0.1 / n2;
            //Console.WriteLine("{0:0.00}",d);
            //Console.ReadKey();

            //double a = 5;
            //int b = 2;
            //double c = a / b;
            //Console.WriteLine(c);
            //Console.ReadKey();

            //string s1 = "123";
            //int num = 5;
            //s1 + num  //加号的作用是字符串拼接  num + 100 加号的作用是数值相加，因为都是数字


        }
    }
}
