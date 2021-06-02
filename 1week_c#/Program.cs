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
            //定数
            const int number = 100;
            const String str = "hoge";
            Console.WriteLine(number);
            Console.WriteLine(str);
            //number = 1000; constがついた変数は値を変えられない
            //str = "abcd";  エラーが発生する

            //条件分岐 if
            Console.Write("数値を入力");
            int h = int.Parse(Console.ReadLine());  //コンソールからの文字列を数値に変換 int.Parse(Console.ReadLine())
            Console.WriteLine("h = " + h);
            if( a > 0){
                Console.WriteLine("hは正の数です。");
            }else{
                Console.WriteLine("hは正の数ではありません。");
            }
            Console.WriteLine("1から3の整数を入力");
            int num = int.Parse(Console.ReadLine());
            if(num == 1){
                Console.WriteLine("two");
            }else if(num == 2){
                Console.WriteLine("two");
            }else if(num == 3){
                Console.WriteLine("three");
            }else{
                Console.WriteLine("不適切な値です。");
            }

            //条件分岐 switch
            Console.Write("1から3の整数を入力:");
            int num2 = int.Parse(Console.ReadLine());
            switch(num2){
            case 1:
                Console.WriteLine("one");    //  num2が1だった場合の処理
                break;
            case 2:
                Console.WriteLine("two");    //  num2が2だった場合の処理
                break;
            case 3:
                Console.WriteLine("three");  //  num2が3だった場合の処理
                break;
            default:
                Console.WriteLine("不適切な値です。"); //  それ以外の値が入力された場合の処理
                break;
            }
            //複数のcase
            //  サイコロの目を入力
            Console.Write("さいころの目(1～6):");
            //  コンソールから数値を入力
            int dice = int.Parse(Console.ReadLine());
            switch (dice)
            {
                case 1:
                case 3:
                case 5:
                    Console.WriteLine("丁（チョウ）です。");  //  偶数ならば丁（チョウ）
                    break;
                case 2:
                case 4:
                case 6:
                    Console.WriteLine("半（ハン）です。");   //  奇数ならば半（ハン）
                    break;
                default:
                    Console.WriteLine("範囲外の数値です。");
                    break;
            }
            //繰り返し処理 for
            for(int i = 1;i <= 5;i++){
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.WriteLine("forの2重ループ");
            for(int i = 1;i <= 2;i++){
                for(int j = 1; j <=3 ; j++){
                    int k = i + j;
                    Console.Write(i+"+" + j +  "=" + k +" ");
                }
                Console.WriteLine();
            }
            //繰り返し処理 while 条件を満たしていないと処理は実行されない
            int t = 0;
            while(t <= 5){
                Console.WriteLine(t + " ");
                t++;
            }
            Console.WriteLine();
            //do-while 条件を満たしていなくても必ず１回は処理が実行される
            int y = 0;
            do{
                Console.WriteLine(y + " ");
                y++;
            }while(y <= 5);
            Console.WriteLine();

            //配列
            double[] x = new double[3];
             x[0] = 1.2;
             x[1] = 3.7;
             x[2] = 4.1;    //  変数の代入
             double sum,avg; //  合計値、平均値を入れる変数
             sum = 0.0;
             for(int i = 0; i < x.Length; i++){
                 Console.Write(x[i] + " ");
                 sum += x[i];
            }
            Console.WriteLine();
            avg = sum / x.Length;
            Console.WriteLine("合計値：" + sum);
            Console.WriteLine("平均値：" + avg);

            //foreachループ 配列の内容出力に使える繰り返し処理(forよりもシンプル)
            //foreach(変数 in 配列変数)
            int[] n = {1,2,3,4};
            foreach(int i in n){
                Console.WriteLine("{0}",i);
            }
            Console.WriteLine();
            //多次元配列
            int[,] k = new int[3,4];
            int m,l;
            //  二次元配列に値を代入
            for(m = 0; m < 3; m++){
                for(l = 0; l < 4; l++){
                    k[m,l] = m+l;
                }
            }
            //  二次元配列に値を出力
            for (m = 0; m < 3; m++)
            {
                for (l = 0; l < 4; l++)
                {
                    Console.Write("l[{0},{1}]={2} ", m, n, k[m, l]);
                }
                Console.WriteLine();
            }
            /*
            二次元配列	int[,] a = new int[3,4];	→	a[1,2] = 2;
            三次元配列	int[,,] a = new int[3,4,5]	→	a[1,2,3] = 2;
            四次元配列	int[,,,] a = new int[3,4,5,6]	→	a[1,2,3,4] = 2;
            */
        }
    }
}
