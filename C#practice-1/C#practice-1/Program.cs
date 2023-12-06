/*string 字串
 * char 字元
 * int 整數
 * double 浮點數
 * bool 布林值*/

//字串常見用法
/*string a = "Worldd";
          //012345
System.Console.WriteLine("Hello " + a); //串接
System.Console.WriteLine(a.Length); //字串長度
System.Console.WriteLine("這樣也可以".Length);
System.Console.WriteLine(a.ToUpper()); //變大寫
System.Console.WriteLine(a.ToLower()); //變小寫
System.Console.WriteLine(a.Contains("orl")); //a字串中是否有orl---True
System.Console.WriteLine(a.Contains("Hello")); //a字串中是否有Hello---False
System.Console.WriteLine(a[0]); //回傳第0位
System.Console.WriteLine(a.IndexOf('d')); //找字元在第幾位(重複取第一個)
System.Console.WriteLine(a.IndexOf("rld")); //字串取開頭
System.Console.WriteLine(a.IndexOf("Hello")); //找不到會回傳-1
System.Console.WriteLine(a.Substring(2)); //刪除第二位以前的字串
System.Console.WriteLine(a.Substring(2, 2)); //第二位開始取兩位
a = a.Substring(2);
System.Console.WriteLine(a);*/

//數字常見用法(整數、浮點數)
/*System.Console.WriteLine(System.Math.Abs(-3)); //絕對值
System.Console.WriteLine(System.Math.Pow(-4, 3)); //次方
double b = System.Math.Pow(15, 6) + 5 * 3;
System.Console.WriteLine(b);
System.Console.WriteLine(System.Math.Sqrt(81)); //開根號
System.Console.WriteLine(System.Math.Max(45, 62)); //兩者最大值
System.Console.WriteLine(System.Math.Min(45, 62)); //兩者最小值
System.Console.WriteLine(System.Math.Round(16.498)); //四捨五入*/

//取得用戶輸入
/*System.Console.Write("請輸入你的名字: "); //不換行
string name = System.Console.ReadLine(); //輸入的字串會直接覆蓋System.Console.ReadLine();
System.Console.Write("請再麻煩輸入你的年紀: ");
string age = System.Console.ReadLine();
System.Console.WriteLine("Hello " + name + "!");*/

//基本計算機
/*System.Console.Write("請輸入第一個數: ");
double num1 = System.Convert.ToDouble(System.Console.ReadLine());
System.Console.Write("請輸入第二個數: ");
double num2 = System.Convert.ToDouble(System.Console.ReadLine());
System.Console.Write("總和: ");
System.Console.WriteLine(num1 + num2);*/

//Array 陣列
/*int[] scores = { 50, 60, 70, 30, 20 };
string[] phones = new string[10];

phones[0] = "0123456789";
phones[1] = "2546221158";

System.Console.WriteLine(phones[0]);
System.Console.WriteLine(phones[1]);
System.Console.WriteLine(phones[2] + "1");

scores[0] = scores[2] + scores[3];
System.Console.WriteLine(scores[0]);
System.Console.WriteLine(scores[1]);
System.Console.WriteLine(scores[2]);
System.Console.WriteLine(scores[3]);
System.Console.WriteLine(scores[4]);*/






