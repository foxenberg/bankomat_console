//int a = 10;
//double b = 20;
//string c = "text";
//char d = 'a';
//bool e = false;

//Console.WriteLine(a);
//Console.WriteLine(b);
//Console.WriteLine(c);
//Console.WriteLine(d);
//Console.WriteLine(e);

//string name = "Руслан";
//int age = 14;
//double height = 1.7;
//Console.WriteLine($"имя:{name} возраст:{age} рост:{height}");
//Console.Write("alalalallala");
//Console.WriteLine($"имя:{0} возраст:{1} рост:{2}",name,age,height );

////Console.Write("введите имя");
////string name2 = Console.ReadLine();

////Console.Write("введите возраст");
////int age2 = Convert.ToInt32(Console.ReadLine());

////Console.Write("введите рост");
////double height2 = Convert.ToDouble(Console.ReadLine());

////Console.WriteLine($"имя:{name2} возраст:{age2} рост:{height2}");

//int f = 10;
//int g = 3;
//Console.WriteLine($"сумма: {f+g}");
//Console.WriteLine($"разность: {f - g}");
//Console.WriteLine($"произведение: {f * g}");
//Console.WriteLine($"частное: {f % g}");
//int f1 = f++;
//Console.WriteLine(f1);

//int a2 = 3;
//int b2 = 5;
//int c2= 40;
//int d2 = c2---b2 * a2;

//Console.WriteLine("Здравствуйте, введите высоту");
//int he = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Здравствуйте, введите ширину");
//int wi = Convert.ToInt32(Console.ReadLine());
//int perimetr = (he + wi) * 2;
//int square = he * wi;
//Console.WriteLine($"Периметр данного прямогугольника равен:{perimetr}");
//Console.WriteLine($"Площадь данного прямогугольника равен:{square}");

//bool f3= (a2==b2);
//bool f4 = a2 != b2;
//if (f > g)
//{
//    Console.WriteLine($"Число {f} больше числа {g}");
//}

//Console.WriteLine("Введите температуру");
//int tempreture = Convert.ToInt32(Console.ReadLine());
//if (tempreture <= 0)
//{
//    if (tempreture <= -30)
//    {
//        Console.WriteLine($"Оставайтесь дома");
//    }
//    else
//        Console.WriteLine($"Оденьте шапку, температура ниже нуля");
//}
//else if (tempreture >= 30)
//{
//    Console.WriteLine($"Оденьте кепку");
//}
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//}
//int k = 2;
//do
//{
//    Console.WriteLine("");
//}
//while(k > 5);
//foreach  (char item in "Ruslan")
//{
//    Console.WriteLine(item);
//}


double a;
double b;
double c;
double D;
double x1, x2;

Console.WriteLine("Здравствуйте, введите кофицент A:");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Здравствуйте, введите коэффицент B:");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Здравствуйте, введите коэффицент C:");
c = Convert.ToDouble(Console.ReadLine());

D = b * b - 4 * a * c;

if (D > 0)
{
    x1=(-b+Math.Sqrt(D))/2*a;
    x2 = (-b - Math.Sqrt(D)) / 2 * a;
    Console.WriteLine("x1 "+x1);
    Console.WriteLine("x2 "+x2);
}
else if (D == 0)
{
    x1 = -b / 2*a;
    Console.WriteLine(x1);
}
else
{
    Console.WriteLine("В данном уравнении нет корней");
}


