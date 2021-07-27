## C#の実行方法(VScode)
.NET Core をインストールし、VSコードのターミナルで
```
dotnet new console
```
プロジェクト作成

## C#のファイル拡張子は
```
.cs
```

## プロジェクト作成後
Program.csファイルが作成されるので  
その中に記述（基礎学習中）  
##### 実行方法
ターミナルで(実行したいファイルを選択した状態で)
```
dotnet run
```
## 計算
```
int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);

First increment: 2
Second increment: 3
Third increment: 4
First decrement: 3
Second decrement: 2
Third decrement: 1
```

