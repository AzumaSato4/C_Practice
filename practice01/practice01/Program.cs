string x;
x = "今日は22日です。";

Console.WriteLine(x+"こんにちは！");

int a = 45; //体重
float b = 1.58f; //身長

//BMI指数
float bmi = a / (b * 2);

//結果を文字連結する
Console.WriteLine("私のBMI指数は" + bmi + "です。");



//四則演算の省略形の話

//算術演算子
int count = 10;
//countの中身を「5を足した数」に置き換え
//count = count + 5;

//省略形
count += 5;


//インクリメント演算子
//count += 1; // 1だけ足す
//省略形
count++;

//デクリメント演算子
//count = count - 1;
//count -= 1;
//省略形
count--;
