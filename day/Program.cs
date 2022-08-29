using Day9;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using后边的都是命名空间的名字

namespace day
{
    class Program
    {
        static void Main(string[] args)
{
            //集合List是类似于集合的一个类，想要使用这个类，必须使用命名空间
            //List<int> List = new List<int>();
            //Console.WriteLine();
            //int[] nums = new int[10];

            //Person zs = new Person();
            //zs.Name = "张三";
            //Console.WriteLine(zs.Name);
            //Console.ReadKey();


            //字符串
            //字符串的不可变性
            //string S1 = "张三";
            //string S2 = "张三";
            //S1 = "李四";
            //Console.ReadKey();

            //可以把string看成一个char类型的只读数组,直接访问
            //string s = "absldjdld";

            ////s[0] = 'b';无法直接赋值，因为是只读的
            ////要想给字符串中的元素赋值，将字符串转换为真正的char类型的数组
            //char[] ch = s.ToCharArray();
            //char[] cha = s.ToCharArray();
            //ch[0] = 'b';
            ////将字符数组转化为字符串
            //s = new string(ch);
            //s = new string(ch);

            ////既然可以将string看做char类型的只读数组，所以我们可以通过下标去访问字符串中的每一个元素
            //Console.WriteLine(s[0]);
            //Console.ReadKey();



            // StringBuilder s = new StringBuilder();//可以不申请内存直接对字符串进行拼接
            // //定义一个计时器来记录程序的运行时间
            // Stopwatch sw = new Stopwatch();
            // sw.Start();//开始计时

            //// string s = null;
            // for (int i = 0; i < 100000; i++)
            // {
            //     // s += i + " ";
            //     s.Append(i);
            // }

            // sw.Stop();//结束计时
            // Console.WriteLine(sw.Elapsed);
            // Console.WriteLine(s);
            // Console.ReadKey();

            //字符串提供的各种方法
            //1.随机输入你心中想的一个人的名字，然后输出它的字符串长度（Length方法）

            //string names = Console.ReadLine();
            //Console.WriteLine(names.Length);
            //Console.ReadKey();



            ////随便输入一个人的名字
            //string name = Console.ReadLine();
            ////输出名字的长度
            //Console.WriteLine(name.Length);
            //Console.ReadKey();

            //2.两个学员输入自己最喜欢的课程的名字，如果相同，则输出你俩喜欢的课程相同
            //如果不同，则输出你俩喜欢的课程不同；考虑如果c#和C#代表的是同一个课程怎么办？

            //Console.WriteLine("请输入第一个学员喜欢的课程：");
            //string lesson1 = Console.ReadLine();

            //Console.WriteLine("请输入第二个学员喜欢的课程：");
            //string lesson2 = Console.ReadLine();

            //if (lesson1.ToLower() == lesson2.ToLower())//将输入的字符都转成小写
            //{

            //    Console.WriteLine("两人喜欢的课程相同");
            //}
            //else
            //{
            //    Console.WriteLine("两人喜欢的课程不同");
            //}
            //Console.ReadKey();

            //if (lesson1.Equals(lesson2, StringComparison.OrdinalIgnoreCase))
            //{
            //    Console.WriteLine("两人喜欢的课程相同");
            //}
            //else
            //{
            //    Console.WriteLine("两人喜欢的课程不同");
            //}
            //Console.ReadKey();






            //Console.WriteLine("请第一个学员输入喜欢的课程");
            //string lesson1 = Console.ReadLine();
            //lesson1 = lesson1.ToUpper();
            //Console.WriteLine("请第二个学员输入喜欢的课程");
            //string lesson2 = Console.ReadLine();
            //lesson2 = lesson2.ToUpper();

            ////if (lesson1.ToUpper() == lesson2.ToUpper())//把输入的字符都转成大写的
            ////{
            ////    Console.WriteLine("你俩喜欢的课程名字相同");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("你俩喜欢的课程名字不同");
            ////}
            ////Console.ReadKey();

            //if (lesson1.Equals(lesson2, StringComparison.OrdinalIgnoreCase))
            //{

            //    Console.WriteLine("你俩喜欢的课程相同");
            //}
            //else
            //{
            //    Console.WriteLine("你俩喜欢的课程不相同");
            //}
            //Console.ReadKey();


            //3.分割字符串
            //string s = "+ - ,,, sajdsk,dkn. sjjs";
            //string s1 = "as   + d f f s";

            ////char[] ch = { ',', '+', '-', '.' };
            //string[] str = s1.Split(new char[]{ ',', '+', '-', '.',' ' },StringSplitOptions.RemoveEmptyEntries);

            ////for (int i = 0; i < str.Length; i++)
            ////{
            ////    Console.WriteLine(str[i]);
            ////}

            //Console.ReadKey();



            //char[] cha = {' ', '+', ',', '-', '.' };
            //string[] s1 = s.Split(cha,StringSplitOptions.RemoveEmptyEntries);

            //Console.ReadKey();

            //从日期字符串（"2022-05-19"）中分析出年、月、日；2022年05月19日
            //如用户输入的日期是2022年05-01，输出2022年05月01号


            //Console.WriteLine("请输入年月日，格式为2022-05-19");
            //string date = Console.ReadLine();
            //string[] date1 = date.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("用户输入的日期是{0}年{1}月{2}日", date1[0], date1[1], date1[2]);
            //Console.ReadKey();

            //Console.WriteLine("请输入年月日，格式为2011-08-09");
            //string date = Console.ReadLine();
            //char[] ch = { '-' };
            //string[] str = date.Split(ch, StringSplitOptions.RemoveEmptyEntries);

            //Console.WriteLine("输入的日期为{0}年{1}月{2}日", str[0], str[1], str[2]);
            //Console.ReadKey();


            ////字符串替换
            //string str = "关键人物老赵";
            //if (str.Contains("老赵"))
            //{
            //    str = str.Replace("老赵", "**");
            //}
            //else
            //{ }
            //Console.WriteLine(str);
            //Console.ReadKey();


            //string str = "关键人物琛哥";
            //if (str.Contains("琛哥"))
            //{
            //   str = str.Replace("琛哥", "**");
            //}

            //Console.WriteLine(str);
            //Console.ReadKey();

            //取字符串
            //string str = "今天天气好晴朗，处处好风光";
            //string s = str.Substring(1);//从索引处开始取值，包括索引的值
            //string s1 = str.Substring(1, 3);//从索引处开始取值，长度为规定的值

            //Console.WriteLine(s1);


            //int num = str.IndexOf('今');
            //Console.WriteLine(num);
            //Console.ReadKey();


            //str = str.Substring(1);
            //string str1 = str.Substring(1, 5);
            //Console.WriteLine(str);
            //Console.WriteLine(str1);
            //Console.ReadKey();


            //字符串的以....开始方法和以....结束方法，判断一个字符串是否以某个字符或字符串开始或者结束
            //string str = "今天天气好晴朗，处处好风光";

            //if (str.StartsWith("今天"))
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("不是");
            //}
            //Console.ReadKey();

            //if(str.StartsWith("天"))
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("不是");
            //}
            //if (str.EndsWith("风光"))
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("不是");
            //}
            //Console.ReadKey();



            ////判断字符出现的位置IndexOf,LastIndexOf
            //string str = "今天天气好晴朗，处处好天风光";

            //int index = str.IndexOf("好");
            //int index1 = str.LastIndexOf("天气");
            //int index2 = str.IndexOf("天", 3);
            //Console.WriteLine(index);
            //Console.WriteLine(index1);
            //Console.WriteLine(index2);
            //Console.ReadKey();



            // int index = str.IndexOf("天");
            //int index = str.LastIndexof("天");
            //int index = str.IndexOf("天", 2);
            //要找出所有的天，就用循环
            //for (int i = 0; i < str.Length; i++)
            //{
            //    _index1 = str.IndexOf("天", i);

            //    Console.WriteLine(_index1);
            //}
            //Console.ReadKey();


            ////LastIndexof和Substring经常一起使用，假设要取出苍老师.avi
            //string path = @"\a\s苍\c\d\f\g\e\t\苍老师苍.avi";
            //////找到字符串中最后一次出现\的位置
            //int index = path.LastIndexOf("\\");
            //string str = path.Substring(index+1);//要从判断位置的下一位开始取出字符串
            //Console.WriteLine(str);
            //Console.ReadKey();

            //int index = path.LastIndexOf("\\");
            //string str = path.Substring(index + 1);
            //Console.WriteLine(str);
            //Console.ReadKey();

            //去掉空格的方法
            //string str = "       askadhka           ";
            //str = str.Trim();
            //str = str.TrimStart();
            //str = str.TrimEnd();
            //Console.WriteLine(str);
            //Console.ReadKey();

            ////str = str.Trim();
            ////str = str.TrimStart();
            // str = str.TrimEnd();

            //Console.WriteLine(str);
            //Console.ReadKey();

            //string的两个方法

            ////string IsNullOrEmpty
            ///
            //string str = "s";
            //if (string.IsNullOrEmpty(str))
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("不是");
            //}
            //Console.ReadKey();



            //string str = null;
            //bool st = string.IsNullOrEmpty(str);
            //if(st)
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("不是");
            //}
            //Console.ReadKey();


            // //String.Join方法
            // string[] names = { "迈克尔杰克逊", "马云", "小甜甜布莱妮", "爱因斯坦" };

            //string str = string.Join("|", names);
            //Console.WriteLine(str);
            //Console.ReadKey();


            //// string str = string.Join("|", names);
            // string str = string.Join("|", "迈克尔杰克逊", "马云", "爱因斯坦");
            // Console.WriteLine(str);
            // Console.ReadKey();


            //字符串练习
            //1.接收用户输入的字符串，将其中的字符以与输入相反的顺序输出“abc”变成“cba”

            //Console.WriteLine("请用户输入字符串");
            //string str = Console.ReadLine();

            //char[] ch = str.ToCharArray();

            //for (int i = 0; i < ch.Length/2; i++)
            //{
            //    char temp = ch[i];
            //    ch[i] = ch[ch.Length - 1 - i];
            //    ch[ch.Length - 1 - i] = temp;
            //}

            //str = new string(ch);
            //Console.WriteLine(str);

            //char[] ch = str.ToCharArray();
            //for (int i = ch.Length-1; i>=0 ; i--)
            //{
            //    Console.WriteLine(ch[i]);
            //}

            //for (int i =str.Length-1; i >= 0; i--)
            //{
            //    Console.WriteLine(str[i]);//字符串可以作为数组的只读形式，按照索引输出
            //}
            //Console.ReadKey();

            //Console.ReadKey();


            //Console.WriteLine("请输入字符串");
            //string str = Console.ReadLine();

            //char[] ch = str.ToCharArray();

            //for (int i = 0; i < ch.Length/2; i++)
            //{
            //    char temp = ch[i];
            //    ch[i] = ch[ch.Length - i - 1];
            //    ch[ch.Length - i - 1] = temp;
            //}

            //////将字符型数组再转化为字符串
            //str = new string(ch);
            //Console.WriteLine(str);
            //Console.ReadKey();

            //直接倒序输出
            //string str = Console.ReadLine();

            //for (int i = str.Length-1; i >= 0; i--)
            //{
            //    Console.WriteLine(str[i]);
            //}
            //Console.ReadKey();


            //char[] ch = { 'a', 'b', 'c','d','e' };


            //for (int i = 0; i < ch.Length/2; i++)
            //{
            //    char temp = ch[i];
            //    ch[i] = ch[ch.Length - 1-i];
            //    ch[ch.Length - 1-i] = temp;
            //}

            //Console.WriteLine(ch);
            //Console.ReadKey();







            //2.接收用户输入的一句英文，将其中的单词以反序输出，“hello c sharp”变成“sharp c hello”

            //string English = "hello c sharp";

            //string[]  s = English.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //for (int i = 0; i < s.Length/2; i++)
            //{
            //    string temp = s[i];
            //    s[i] = s[s.Length - 1 - i];
            //    s[s.Length - 1 - i] = temp;
            //}

            //English = string.Join(" ", s);
            //Console.WriteLine(English);
            //Console.ReadKey();


            // string str = "hello c sharp";

            // string[] s = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // for (int i = 0; i < s.Length/2; i++)
            // {
            //     string temp = s[i];
            //     s[i] = s[s.Length-1-i];
            //     s[s.Length - 1 - i] = temp;
            // }

            //str = string.Join(" ", s);
            // Console.WriteLine(str);

            // Console.ReadKey();


            //char[] ch = new char[] {' '};

            // String str = "hello c sharp";
            ////Split这个方法返回的是一个字符串的数组，参数是字符串型的数组
            // string[] s=str.Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);
            // for (int i = 0; i < s.Length/2; i++)
            // {
            //     string temp = s[i];
            //     s[i] = s[s.Length - 1 - i];
            //     s[s.Length - 1 - i] = temp;
            // }
            // //使用Join方法输出
            // str = string.Join(" ", s);
            // Console.WriteLine(str);

            // //使用数组方法输出
            // //for (int i = 0; i < s.Length; i++)
            // //{
            // //    Console.WriteLine(s[i]);
            // //}

            // Console.ReadKey();


            //3.从Email中提取出用户名和域名：abc@163.com


            //string email = "abc@163.com";

            //int index = email.IndexOf("@");

            //string user = email.Substring(0, index);
            //string dns = email.Substring(index + 1);
            //Console.WriteLine("用户名{0}域名{1}", user, dns);
            //Console.ReadKey();



            //string email = "acb@163.com";

            //int index = email.IndexOf('@');
            //string username = email.Substring(0, index);
            //string dns = email.Substring(index + 1);

            //Console.WriteLine(username);
            //Console.WriteLine(dns);
            //Console.ReadKey();



            //4.文本文件中存储了多个文章的标题、作者，标题和作者之间用若干空格（数量不定）隔开，
            //每行一个，标题有的长有的短，输出到控制台的时候最长的标题长度为10，如果超过10，则截取
            //长度为8的子串并且最后添加“...”，加一个竖线后输出作者的名字


            //string path = @"C:\Users\Ma Chenlu\Desktop\1.txt";

            //string[] str = File.ReadAllLines(path);

            //for (int i = 0; i < str.Length; i++)
            //{
            //    string[] contents = str[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //    if (contents[0].Length > 10)
            //    {
            //        contents[0] = contents[0].Substring(0, 8) + "....";
            //        Console.WriteLine(contents[0] + "|" + contents[1]);
            //    }
            //    else
            //    {
            //        Console.WriteLine(contents[0] + "|" + contents[1]);
            //    }

            //}

            //Console.ReadKey();



            //string path = @"C:\Users\Ma Chenlu\Desktop\1.txt";
            //string[] str = File.ReadAllLines(path);

            //for (int i = 0; i < str.Length; i++)
            //{
            //    string[] st = str[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //    if (st[0].Length > 10)
            //    {
            //        st[0] = st[0].Substring(0, 8) + "...";
            //       // st[0] = string.Join("|", st);//我的错误的写法
            //        string s=string.Join("|", st);
            //        Console.WriteLine(s);
            //        //Console.WriteLine(st[0] + "|" + st[1]);
            //    }
            //    else
            //    {
            //        string s = string.Join("|", st);
            //        Console.WriteLine(s);
            //        // Console.WriteLine(st[0] + "|" + st[1]);
            //    }
            //}

            //Console.ReadKey();




            //string path = @"C:\Users\Ma Chenlu\Desktop\1.txt";
            //string[] str = File.ReadAllLines(path);

            //for (int i = 0; i < str.Length; i++)
            //{
            //    string[] contents = str[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //    if (contents[0].Length > 8)
            //    {
            //        contents[0] = contents[0].Substring(0, 8) + "......";
            //    }

            //    Console.WriteLine(contents[0] + "|" + contents[1]);
            //}


            //Console.ReadKey();


            //5.让用户输入一句话找出所有e的位置

            //string s = "esjdeksneefe";

            //int index = s.IndexOf('e');
            //Console.WriteLine("第1次找到e的位置是{0}",index);

            //int count = 1;
            //for (int i = 0; i < s.Length; i++)
            //{
            //    count++;
            //    index = s.IndexOf('e', index + 1);
            //    if (index == -1)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("第{0}次找到e的位置是{1}", count, index);
            //}
            //Console.ReadKey();


            //string str = "avsjhadbebjhvewweeeeee";

            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] == 'e')//这种方式只适合单个字符
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadKey();




            //string str = "asdhjsaaskjkdkndas";

            //int index = str.IndexOf("as");
            //Console.WriteLine("第1次找到as的位置是{0}", index);
            ////int index = str.IndexOf("as");
            //int count = 0;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    count++;
            //    index = str.IndexOf("as", index + 1);
            //    if (index == -1)
            //    {
            //        break;
            //    }
            //    Console.WriteLine("第{0}次输出as的位置是{1}", count, index);
            //}
            //Console.ReadKey();



            //6.让用户输入一句话，判断这句话中有没有邪恶，如果有邪恶就替换成这种形式，然后输出，
            //如“老牛很邪恶”变成“老牛很**”
            //Console.WriteLine("请输入");
            //string cons = Console.ReadLine();

            //if (cons.Contains("邪恶"))
            //{
            //    cons = cons.Replace("邪恶", "**");

            //}
            //Console.WriteLine(cons);
            //Console.ReadKey();



            //string str = "老牛很邪恶";
            //if (str.Contains("邪恶"))
            //{

            //    str = str.Replace("邪恶", "**");
            //}
            //else
            //{

            //}
            //Console.WriteLine(str);
            //Console.ReadKey();

            //7.把{“诸葛亮”，“卡卡西”，“卡哇伊”}变成{“诸葛亮|卡卡西|卡哇伊”}，再把|切掉

            //string[] str = { "诸葛亮", "卡卡西", "卡哇伊" };
            //string s = string.Join("|", str);
            //str = s.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine(s);
            //Console.ReadKey();


            // string[] str = { "诸葛亮", "卡卡西", "卡哇伊" };
            // string names = string.Join("|", str);
            // string[] s= names.Split( new char[]{'|'},StringSplitOptions.RemoveEmptyEntries);
            //// Console.WriteLine(names);
            // Console.ReadKey();

            //double a = 3.4;
            //int b = (int)a * 2;
            //Console.WriteLine(b);
            //Console.ReadKey();


            //8.总结常用的string方法
            //1.Contains 2.Replace 3.Split 4.string.Join 5.Substring 6.IndexOf和LastIndexOf
            //7.Stratswith和EndWith 8.Trim 9.ToUpper 10.Equals

            

           





















        }
    }
}
