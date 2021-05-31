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
            String name = "田中";
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(a+b);
            Console.WriteLine(a*b);
            Console.WriteLine(a/b);
            Console.WriteLine(name);
            Console.WriteLine(name + "は" + a * 7 + "歳です");
        }
    }
}
