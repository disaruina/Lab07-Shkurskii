//задание 1
// int[] marks = { 5, 4, 3, 5, 4 };
// Console.WriteLine(marks[0]);
// Console.WriteLine(marks[4]);
// marks[2] = 4;

// for (int i = 0; i < marks.Length; i++)
// {
//     Console.WriteLine($"marks[{i}] = {marks[1]}");
// }
// foreach (int mark in marks)
// {
//     Console.WriteLine(mark);
// }
// Здание 1.1
// string[] days = { "Пн", "Вт", "Ср", "Чт", "Пт","Сб","Вс"};
// for (int i = 6; i < days.Length; i--)
// {
//     Console.WriteLine($"{i}: {days[i]}");
// }
// Задание 1.2
// double[] temps = { 12.1, 5.0, -2.3, 5.1, 0.4, 4.2, 1.0 };
// foreach (double i in temps)
// {
//     Console.Write(i + " "); 
// }
// Задание 2
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int s = 0;
// int c = 0;

// foreach (int i in prices)
// {
//     s = s + i;

//     if (i<100)
//     {
//         c++;
//     }
// }
// double sred = (double)s / prices.Length;
// Console.WriteLine(s);
// Console.WriteLine($"{sred:N2}");
// Console.WriteLine(c);
// Задание 3
// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int min = prices[0];
// int fff = 0;
// int vvv = prices[0];
// for (int i = 1; i < prices.Length; i++)
// {
//     if (prices[i] < min)
//     {
//         min = prices[i];
//     }
//     if (vvv < prices[i])
//     {
//         vvv = prices[i];
//         fff = i;
//     }
// }
// Console.WriteLine(min);
// Console.WriteLine(fff); 
// Задание 4
// int[] balance = { 100, -50, 20, -5, 0, 75 };
// for (int i = 0; i < balance.Length; i++)
// {
//     if (balance[i] < 0)
//     {
//         balance[i] = 0;
//     }
// }
// foreach (int i in balance)
// {
//     Console.Write(i + " ");
// }
// Задание 5
// int[] n = new int[5];
// int c = 0;
// for (int i = 0; i < n.Length; i++)
// {
//     n[i] = int.Parse(Console.ReadLine()); 
//     if (n[i]%2 == 0)
//     {
//         c++;
//     }
// }
// for (int i = n.Length-1; i >= 0; i--)
// {
//     Console.WriteLine(n[i]);
// }
// Console.WriteLine(c);

using System.Threading.Tasks.Dataflow;
// задание 6
string[] names = { "Анна", "Игорь",
"Мария", "Олег", "Ольга" };
String s = Console.ReadLine();
bool flag1 = true;
for (int i = 0; i < names.Length; i++)

{
    if (s == names[i])
    {
        Console.WriteLine(i);
        flag1 = false;
        break;
    }
}
if (flag1)
{
    Console.WriteLine("Не найдено");
}
