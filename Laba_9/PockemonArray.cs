using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_9
{
    //3 часть
    public class PockemonArray //создание класса для создания массивов с покемонами
    {
        static int minAttack = 17; //минимальное значение атаки
        static int maxAttack = 414; //максимальное значение атаки
        static int minDefense = 32; //минимальное значение защиты
        static int maxDefense = 396; //максимальное значение защиты
        static int minStamina = 1; //максимальное значение выносливости
        static int maxStamina = 496; //минимальное значение выносливости

        static int countArray = 0; //счетчик объектов класса

        private int otherAttack, otherDefense, otherStamina; //параметры копируемого покемона

        static Random rnd = new Random(); //создание генератора случайных чисел
        Pockemon[] pockemons; //создаем пустой список "pockemons"
        public int Length //свойство класса для получения длины массива
        {
            get => pockemons.Length;
        }

        //конструктор без параметров (задаются минимальные значения х-к для покемонов)
        public PockemonArray()
        {
            pockemons = new Pockemon[6]; //создаем массив для 6 базовых покемонов
            for (int i = 0; i < 6; i++)
            {
                pockemons[i] = new Pockemon();
            }
            countArray++;
        }

        //конструктор с параметрами (задаются рандомные значения х-к для покемонов)
        public PockemonArray(int length)
        {
            if (length >=0)
            {
                pockemons = new Pockemon[length]; //создаем массив для указанной длины
                for (int i = 0; i < length; i++)
                {
                    pockemons[i] = new Pockemon(rnd.Next(minAttack, maxAttack + 1), rnd.Next(minDefense, maxDefense + 1), rnd.Next(minStamina, maxStamina + 1));
                }
                countArray++;
            }

            else throw new Exception("Ошибка! Некорректное значение длины массива");
        }

        //создаем массив вручную
        public static PockemonArray CreateArray(int length)
        {
            PockemonArray pockemons = new PockemonArray(length);
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"Создайте {i + 1} покемона");
                int attack = InputOutput.InputAttack();
                int defense = InputOutput.InputDefense();
                int stamina = InputOutput.InputStamina();
                pockemons[i] = new Pockemon(attack, defense, stamina);
            }
            countArray++;
            return pockemons;
        }

        //индексатор
        public Pockemon this[int index]
        {
            get
            {
                if (index >= 0 && index < pockemons.Length)
                    return pockemons[index];

                else throw new Exception("Ошибка! Выход за пределы массива"); //исключение
            }
            set
            {
                if (index >= 0 && index < pockemons.Length)
                    pockemons[index] = value;
                else throw new Exception("Ошибка! Выход за пределы массива"); //исключение
            }
        }

        //конструктор копирования
        public PockemonArray(PockemonArray otherPockemons)
        {
            if (otherPockemons.Length != 0)
            {
                pockemons = new Pockemon[otherPockemons.Length];
                for (int i = 0; i < otherPockemons.Length; i++)
                {
                    otherAttack = otherPockemons[i].Attack;
                    otherDefense = otherPockemons[i].Defense;
                    otherStamina = otherPockemons[i].Stamina;
                    pockemons[i] = new Pockemon(otherAttack, otherDefense, otherStamina);
                }
                countArray++;
            }
            else throw new Exception("Набор покемонов пуст, копию создать не получится :("); //исключение
        }

        //определение моды выносливости
        public int GetStaminaMode()
        {
            if (pockemons.Length != 0)
            {
                int maximum = 1;
                int countThisStamina;
                int mode = pockemons[0].Stamina;
                int thisStamina;
                for (int i = 0; i < pockemons.Length; i++)
                {
                    countThisStamina = 0;
                    thisStamina = pockemons[i].Stamina;
                    for (int k = 0; k < pockemons.Length; k++)
                    {
                        if (pockemons[k].Stamina == thisStamina)
                        {
                            countThisStamina++;
                        }
                    }
                    if (countThisStamina > maximum)
                    {
                        maximum = countThisStamina;
                        mode = thisStamina;
                    }
                }
                return mode;
            }
            else throw new Exception("Набор покемонов пуст, моду найти не получится :("); //исключение
        }

        public static int GetCountArray //счетчик объектов класса
        {
            get => countArray;
        }
    }
}
