//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
string poli (string num)
{
    if (num.Length != 5) return "введите пятизначное число!";
    if (num[0] == num[4] && num[1] == num[3]) return "является полиндромом";
    else return "не является полиндромом";    
}
Console.WriteLine("Input number:");
string num = Convert.ToString(Console.ReadLine());
Console.WriteLine($"{num} -> {poli (num)}");


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double dis(int x1, int y1, int z1, int x2, int y2, int z2)
{
int deltaX = x2 - x1;
int deltaY = y2 - y1;
int deltaZ = z2 - z1;
return Math.Sqrt(deltaX*deltaX+deltaY*deltaY+deltaZ*deltaZ);
}
 Console.WriteLine("Координаты X от A");
int x1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Координаты Y от A");
int y1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Координаты Z от A");
int z1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Координаты X от B");
int x2 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Координаты Y от B");
int y2 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Координаты Z от B");
int z2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"Растояние между точками A и B равно {dis(x1, y1, z1, x2, y2, z2):F2}");

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
int triple (int num)
{
    int k = 0;
    for (int i=1;i<=num;i++)
    {
        if (i == num) return i*i*i;
        k = i*i*i;
        Console.Write($"{k},");
    }
    return 1;
}
Console.WriteLine("Input number:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{triple(num)} <- таблица всех кубов");


