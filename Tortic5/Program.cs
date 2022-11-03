using System;
using System.Runtime.InteropServices;
using Tortic5;
int a = 0;
int b = 0;
int c;
int mn = 0;
int st=0;   
int tt=0;   
int[,] cast = new int[6, 3] { { 500, 300, 700}, { 500, 300, 200 }, { 400, 500, 300 }, { 100, 200, 300 }, { 200, 200, 200 }, { 100, 100, 100 } };
int[] cost = new int[7];
string[,] men = new string[6, 3] { { "круг -500", "квадрат -300", "треугольник -700" }, { "большой -500", "средний -300", "маленький -200" }, { "шоколадный -400", "клубничный -500", "ванильный -300" }, { "1 -100", "2 -200", "3 -300" }, { "шоколадная -200", "белая -200", "карамельная -200" }, { "шоколадная крошка -100", "фрукты -100", "кокосовая стружка -100" } };
ConsoleKeyInfo key;
do
{ 
do
{
    menui cs = new menui(1);
    keyy();
    c = 5;
    Meni();
    cs.Menu();
    costt();
    if (key.Key == ConsoleKey.Enter)
    {

        Console.Clear();
        c = 2;
        if (a == 0)
            mn = 1;
        if (a == 1)
            mn = 2;
        if (a == 2)
            mn = 3;
        if (a == 3)
            mn = 4;
        if (a == 4)
            mn = 5;
        if (a == 5)
            mn = 6;
        a = 0;
        while (key.Key != ConsoleKey.Escape)
        {
            keyy();
            Meni();
            if (mn == 1)
            {
                cs.Menu1();
                if (key.Key == ConsoleKey.Enter)
                    cst();
            }
            else if (mn == 2)
            {
                cs.Menu2();
                if (key.Key == ConsoleKey.Enter)
                    cst();
            }
            else if (mn == 3)
            {
                cs.Menu3();
                if (key.Key == ConsoleKey.Enter)
                    cst();
            }
            else if (mn == 4)
            {
                cs.Menu4();
                if (key.Key == ConsoleKey.Enter)
                    cst();
            }
            else if (mn == 5)
            {
                cs.Menu5();
                if (key.Key == ConsoleKey.Enter)
                    cst();
            }
            else if (mn == 6)
            {
                cs.Menu6();
                if (key.Key == ConsoleKey.Enter)
                    cst();
            }
        }
    }
}
while (key.Key != ConsoleKey.Tab);
Console.WriteLine("Заказ окончен");
    tt += 1;
file();
}
while (true);
void keyy()
{
    key = Console.ReadKey();
    if (key.Key == ConsoleKey.UpArrow)
    {
        a--;
    }
    else if (key.Key == ConsoleKey.DownArrow)
    {
        a++;
    }
    if (key.Key == ConsoleKey.LeftArrow)
    {
        b--;
    }
    else if (key.Key == ConsoleKey.RightArrow)
    {
        b++;
    }
}
void Meni()
{
    if (a < 0)
    { a += 1; }
    if (a > c)
    { a -= 1; }
    Console.Clear();
    Console.SetCursorPosition(0, a + 2);
    Console.WriteLine("->");
}
void cst()
{
        if (a == 0)
            cost[mn - 1] = 0;
        else if (a == 1)
            cost[mn - 1] = 1;
        else if (a == 2)
            cost[mn - 1] = 2;
}
void costt()
{
    st = 0;
    Console.Write("Торт  ");
    for (int i = 0; i < 6; i++)
    {
        st = st + cast[i, cost[i]];
        Console.Write(men[i,cost[i]]);
        Console.Write(" ");
    }
    Console.WriteLine();
    Console.Write("Стоимость заказа ");
    Console.WriteLine(st);

}
void file()
{
    File.AppendAllText("C:\\Users\\vanaj\\файлы\\заказы.txt", "---------\n");
    for (int i = 0; i < 6; i++)
    {
        File.AppendAllText("C:\\Users\\vanaj\\файлы\\заказы.txt", men[i, cost[i]]);
        File.AppendAllText("C:\\Users\\vanaj\\файлы\\заказы.txt", " ");
    }
    File.AppendAllText("C:\\Users\\vanaj\\файлы\\заказы.txt", "\nЦена ");
    File.AppendAllText("C:\\Users\\vanaj\\файлы\\заказы.txt", Convert.ToString(st));
    File.AppendAllText("C:\\Users\\vanaj\\файлы\\заказы.txt", "\n");
}
