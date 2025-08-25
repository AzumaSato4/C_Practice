//シンプルなif文

using System.Runtime.CompilerServices;

string money; //所持金
Console.Write("所持金はいくらありますか？：");
money = Console.ReadLine(); //ユーザーの入力待ち

Console.WriteLine("所持金は" + money + "円ですね");


//if文
//型変換 文字列→整数
int x;
x = int.Parse(money);


//xが1000以上なら
if (x >= 1000)
{
    Console.WriteLine("まぐろ丼にします");
}
else if (x >= 500)
{
    Console.WriteLine("からあげ弁当にします");
}
else
{
    Console.WriteLine("そぼろ丼にします");
}

//switch文
switch (x)
{
    case >= 1000: //xの中身が1000以上なら
        Console.WriteLine("まぐろ丼にします");
        break; //switch文を抜ける
    case >= 500:
        Console.WriteLine("からあげ弁当にします");
        break;
    default: //何にも該当しなかったら
        Console.WriteLine("そぼろ丼にします");
        break;
}