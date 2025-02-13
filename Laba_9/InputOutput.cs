using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_9
{
    public class InputOutput
    {
        static int minAttack = 17; //минимальное значение атаки
        static int maxAttack = 414; //максимальное значение атаки
        static int minDefense = 32; //минимальное значение защиты
        static int maxDefense = 396; //максимальное значение защиты
        static int minStamina = 1; //максимальное значение выносливости
        static int maxStamina = 496; //минимальное значение выносливости

        public static int InputAttack() //метод для ввода атаки
        {
            int inputAttack; //вводимое значение атаки
            bool isChecked = true; //проверка на соответствие типу Int
            string buffer;
            Console.WriteLine("Введите значение параметра АТАКА (целое число от 17 до 414 вкл.)");
            do
            {
                buffer = Console.ReadLine();
                isChecked = int.TryParse(buffer, out inputAttack);
                if (inputAttack < minAttack || inputAttack > maxAttack)
                {
                    isChecked = false;
                }
                if (!isChecked)
                {
                    Console.WriteLine("Возникла ошибка при вводе значения параметра 'АТАКА'. Попробуйте еще раз");
                }
            } while (!isChecked);
            return inputAttack;
        }

        public static int InputDefense() //метод для ввода защиты
        {
            int inputDefense; //вводимое значение защиты
            bool isChecked = true; //проверка на соответствие типу Int
            string buffer;
            Console.WriteLine("Введите значение параметра ЗАЩИТА (целое число от 32 до 396 вкл.)");
            do
            {
                buffer = Console.ReadLine();
                isChecked = int.TryParse(buffer, out inputDefense);
                if (inputDefense < minDefense || inputDefense > maxDefense)
                {
                    isChecked = false;
                }
                if (!isChecked)
                {
                    Console.WriteLine("Возникла ошибка при вводе значения параметра 'ЗАЩИТА'. Попробуйте еще раз");
                }
            } while (!isChecked);
            return inputDefense;
        }

        public static int InputStamina() //метод для ввода выносливости
        {
            int inputStamina; //вводимое значение выносливости
            bool isChecked = true; //проверка на соответствие типу Int
            string buffer;
            Console.WriteLine("Введите значение параметра ВЫНОСЛИВОСТЬ (целое число от 1 до 496 вкл.)");
            do
            {
                buffer = Console.ReadLine();
                isChecked = int.TryParse(buffer, out inputStamina);
                if (inputStamina < minStamina || inputStamina > maxStamina)
                {
                    isChecked = false;
                }
                if (!isChecked)
                {
                    Console.WriteLine("Возникла ошибка при вводе значения параметра 'ВЫНОСЛИВОСТЬ'. Попробуйте еще раз");
                }
            } while (!isChecked);
            return inputStamina;
        }

        public static void ShowParametrs(Pockemon pockemon) //функция для вывода значений характеристик покемона
        {
            Console.WriteLine($"Характеристики покемона: атака: {pockemon.Attack}, защита: {pockemon.Defense}, выносливость: {pockemon.Stamina}");
        }

        public static void ShowPockemons(PockemonArray pockemons) //функция для отображения набора покемонов
        {
            if (pockemons.Length != 0)
            {
                Console.WriteLine("Ваш набор покемонов:");
                for (int i = 0; i < pockemons.Length; i++)
                {
                    Console.WriteLine($"Покемон номер {i + 1}");
                    ShowParametrs(pockemons[i]);
                }
            }
            else Console.WriteLine("Набор покемонов пуст :(");
        }
    }
}
