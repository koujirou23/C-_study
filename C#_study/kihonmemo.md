### C#の変数宣言
```
using System;

namespace project
{
	class Program
	{
		static void Main(string[] args)
		{
			string newName;       // 変数宣言
			newName = "taro";    // 値を代入
			Console.WriteLine(newName);    // 値を出力

		}
	}
}
```

#### データ型
```
int x = 1;				 // 整数型
decimal y = 1.23m;	    //	浮動小数点型
char c = 'a';		   //	文字型
string s = "aiueo";	  //	文字列型
bool is_ok = true;   //		論理型

```
### エスケープ文字
```
\t    // タブ
\n   // 改行
\\  //  \を出力
@"" // ""の中身をそのまま出力　改行も
```