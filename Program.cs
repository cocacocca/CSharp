namespace _027_字符串
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name = " Micheal Liang Li ";
            //Console.WriteLine(name.Length);
            //正序遍历
            //for(int i  = 0; i < name.Length; i++)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //倒序遍历
            //for(int i = name.Length-1; i >= 0; i--)
            //{
            //    Console.WriteLine(name[i]);
            //}

            //name.methodName();调用方法

            //string str2 = name.ToLower();//表示name使用tolower方法
            //Console.WriteLine(name + "-" + str2);
            //string str3 = name.ToUpper();
            //Console.WriteLine(name + "-" + str3);
            //string str4 = name.Trim();//trim方法去除字符串中间的空格
            //Console.WriteLine(name + "-" + str4);
            //string str5 = name.TrimStart();//trimstart方法去除字符串前面的空格
            //Console.WriteLine(name + "-" + str5 + '|');
            //string str6 = name.TrimEnd();//trimend方法去除字符串后面的空格
            //Console.WriteLine(name + "-" + str6 + '|');

            string name = "zhangsan,lisi,wangwu";
            string[] strArray = name.Split(",");//split()是在","左右的字符串分离输出
            foreach(string str in strArray)
            {
                Console.WriteLine(str);
            }
        }
    }
}