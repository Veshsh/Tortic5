using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace Tortic5
{
    internal class menui
    {
        string[,] men = new string[6, 3] { { "круг -500", "квадрат -300", "треугольник -700" }, { "большой -500", "средний -300", "маленький -200" }, { "шоколадный -400", "клубничный -500", "ванильный -300" }, { "1 -100", "2 -200", "3 -300" }, { "шоколадная -200", "белая -200", "карамельная -200" }, { "шоколадная крошка -100", "фрукты -100", "кокосовая стружка -100" } };
        public menui(int a)
        {
            
        }
        public void Menu()
        {
            List<string> m = new List<string>() { "форма", "размер", "вкус", "количество коржей", "глазурь", "декор" };

            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Главное меню");
            Console.WriteLine("--------------");
            for (int i = 0; i < m.Count; i++)
            {
                Console.SetCursorPosition(2, 2 + i);
                Console.WriteLine(m[i]);
            }
        }
        public void Menu1()
        {
            List<string> m = new List<string>() { men[0,0], men[0, 1], men[0, 2] };

            Console.SetCursorPosition(0, 0);
            Console.WriteLine("меню формы");
            Console.WriteLine("--------------");
            for (int i = 0; i < m.Count; i++)
            {
                Console.SetCursorPosition(2, 2 + i);
                Console.WriteLine(m[i]);
            }
        }
        public void Menu2()
        {
            List<string> m = new List<string>() { men[1, 0], men[1, 1], men[1, 2] };

            Console.SetCursorPosition(0, 0);
            Console.WriteLine("меню формы");
            Console.WriteLine("--------------");
            for (int i = 0; i < m.Count; i++)
            {
                Console.SetCursorPosition(2, 2 + i);
                Console.WriteLine(m[i]);
            }
        }
        public void Menu3()
        {
            List<string> m = new List<string>() { men[2, 0], men[2, 1], men[2, 2] };

            Console.SetCursorPosition(0, 0);
            Console.WriteLine("меню вкуса");
            Console.WriteLine("--------------");
            for (int i = 0; i < m.Count; i++)
            {
                Console.SetCursorPosition(2, 2 + i);
                Console.WriteLine(m[i]);
            }
        }
        public void Menu4()
        {
            List<string> m = new List<string>() { men[3, 0], men[3, 1], men[3, 2] };

            Console.SetCursorPosition(0, 0);
            Console.WriteLine("меню вкуса");
            Console.WriteLine("--------------");
            for (int i = 0; i < m.Count; i++)
            {
                Console.SetCursorPosition(2, 2 + i);
                Console.WriteLine(m[i]);
            }
        }
        public void Menu5()
        {
            List<string> m = new List<string>() { men[4, 0], men[4, 1], men[4, 2] };

            Console.SetCursorPosition(0, 0);
            Console.WriteLine("меню вкуса");
            Console.WriteLine("--------------");
            for (int i = 0; i < m.Count; i++)
            {
                Console.SetCursorPosition(2, 2 + i);
                Console.WriteLine(m[i]);
            }
        }
        public void Menu6()
        {
            List<string> m = new List<string>() { men[5, 0], men[5, 1], men[5, 2] };

            Console.SetCursorPosition(0, 0);
            Console.WriteLine("меню вкуса");
            Console.WriteLine("--------------");
            for (int i = 0; i < m.Count; i++)
            {
                Console.SetCursorPosition(2, 2 + i);
                Console.WriteLine(m[i]);
            }
        }
    }
}
