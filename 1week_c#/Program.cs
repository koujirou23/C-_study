using System;

namespace C__project  //プログラムを分類する入れ物みたいなもの
{
    class Program  //クラス名 パッケージが異なれば同じクラス名を使用できる
    {
        static void Main(string[] args)  //エントリーポイント 原則この中に処理を記述することでプログラムが実行される(1つのプロジェクトには、1つのエントリーポイントしかおけない)
        {
            Console.WriteLine("Hello World!");  //コンソールに表示する命令
            Console.WriteLine(100);
            Console.Write("改行しない");
            Console.WriteLine("改行する");
            Console.WriteLine("改行された");
            int a = 3;
            int b = 2;
            double c = 3.5;
            int d = 3;
            String name = "田中";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(a+b);
            Console.WriteLine(a*b);
            Console.WriteLine(a/b);
            Console.WriteLine(name);
            Console.WriteLine(name + "は" + a * 7 + "歳です");
            Console.WriteLine(c);  //基本はJAVAと同じみたい
            Console.WriteLine("代入前 " +d);
            d = 5; //代入
            Console.WriteLine("代入後 " +d);
            int e = (int)1.23;  //キャスト
            Console.WriteLine(e);
            int f = 10;
            double g = (double)f;
            Console.WriteLine(g);
            //コンソールから文字を入力
            String str1, str2;
            Console.WriteLine("文字列を入力してください");
            Console.Write("str1=");
            str1 = Console.ReadLine();  //コンソールからstr1に文字列を入力
            Console.Write("str2=");
            str2 = Console.ReadLine();  //コンソールからstr2に文字列を入力
            Console.WriteLine("str1 + str2 = " + str1 + str2);
        }
    }
}
