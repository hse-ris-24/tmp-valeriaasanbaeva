using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_9
{
    public class Pockemon
    {
        private int attack; //значение аттаки покемона
        private int defense; //значение защиты покемона
        private int stamina; //значение выносливости покемона
        static int minAttack = 17; //минимальное значение атаки
        static int maxAttack = 414; //максимальное значение атаки
        static int minDefense = 32; //минимальное значение защиты
        static int maxDefense = 396; //максимальное значение защиты
        static int minStamina = 1; //максимальное значение выносливости
        static int maxStamina = 496; //минимальное значение выносливости

        static int count = 0; //счетчик объектов класса

        //1 часть

        public int Attack //свойство атрибута attack
        {
            get => attack;
            set
            {
                if (value < minAttack || value > maxAttack)
                {
                    throw new Exception("Ошибка! Выход за пределы диапазона возможных значений параметра attack");
                }
                else attack = value;
            }
        }
        public int Defense //свойство атрибута defense
        {
            get => defense;
            set
            {
                if (value < minDefense || value > maxDefense)
                {
                    throw new Exception("Ошибка! Выход за пределы диапазона возможных значений параметра defense");
                }
                else defense = value;
            }
        }
        public int Stamina //свойство атрибута stamina
        {
            get => stamina;
            set
            {
                if (value < minStamina || value > maxStamina)
                {
                    throw new Exception("Ошибка! Выход за пределы диапазона возможных значений параметра stamina");
                }
                else stamina = value;
            }
        }
        public Pockemon() //конструктор без параметров (задаются минимальные значения для атрибутов)
        {
            Attack = 17;
            Defense = 32;
            Stamina = 1;
            count++; //увеличиваем счетчик объектов
        }
        public Pockemon(int setAttack, int setDefense, int setStamina) //конструктор с параметрами (задаются переданные значения для атрибутов)
        {
            Attack = setAttack;
            Defense = setDefense;
            Stamina = setStamina;
            count++; //увеличиваем счетчик объектов
        }
        public Pockemon AddParametrs(int addAttack, int addDefense, int addStamina) //метод класса для добавления к текущим х-кам покемона переданные в функции значения
        {
            if (this.attack + addAttack <= maxAttack && this.Defense + addDefense <= maxDefense && this.Stamina + addStamina <= maxStamina)
            {
                this.Attack += addAttack;
                this.Defense += addDefense;
                this.Stamina += addStamina;
                return this; //возврат измененного покемона
            }

            else throw new Exception("Ошибка! Выход за пределы диапазона возможных значений параметров");
        }
        public static Pockemon StaticAddParametrs(Pockemon pockemon, int addAttack, int addDefense, int addStamina) //статическая функция для добавления к текущим х-кам покемона переданные в функции значения
        {
            if (pockemon.attack + addAttack <= maxAttack && pockemon.Defense + addDefense <= maxDefense && pockemon.Stamina + addStamina <= maxStamina)
            {
                pockemon.Attack += addAttack;
                pockemon.Defense += addDefense;
                pockemon.Stamina += addStamina;
                return pockemon; //возврат измененного покемона
            }

            else throw new Exception("Ошибка! Выход за пределы диапазона возможных значений параметров");
        }

        //2 часть

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj is not Pockemon) return false;
            Pockemon other = (Pockemon)obj;
            return this.Attack == other.Attack && this.Defense == other.Defense && this.Stamina == other.Stamina;
        }

        //унарные операции
        public static double operator ~(Pockemon pockemon) //подсчет боевой мощи покемона
        {
            double attack = pockemon.Attack;
            double defense = pockemon.Defense;
            double stamina = pockemon.Stamina;
            double combatPower = (Math.Round(Math.Sqrt(stamina), 2) * Math.Round(attack, 2) * Math.Round(Math.Sqrt(defense), 2)) / 10;
            combatPower = Math.Round(combatPower, 2);
            return combatPower;
        }
        public static Pockemon operator --(Pockemon pockemon) //уменьшение выносливости покемона на 1
        {
            if (pockemon.Stamina != minStamina)
            {
                pockemon.Stamina--;
                return pockemon;
            }
            else throw new Exception("Ошибка! Выход за пределы диапазона возможных значений параметров");
        }

        //операции приведения типа
        public static explicit operator int(Pockemon pockemon) //перегрузка оператора типа int (явное преобразование)->возврат суммы х-к покемона
        {
            return pockemon.Attack + pockemon.Defense + pockemon.Stamina;
        }
        public static implicit operator double(Pockemon pockemon) //перегрузка оператора типа double (неявное преобразование)->возврат ср.значения х-к покемона
        {
            double meanValue = (pockemon.Attack + pockemon.Defense + pockemon.Stamina) / 3;
            return Math.Round(meanValue, 2);
        }

        //бинарные операции
        public static Pockemon operator >>(Pockemon pockemon, int addStamina) //добавление указанного кол-ва единиц к выносливости
        {
            if (pockemon.Stamina + addStamina <= maxStamina)
            {
                pockemon.Stamina += addStamina;
                return pockemon;
            }
            else throw new Exception("Ошибка! Выход за пределы диапазона возможных значений параметров");
        }
        public static Pockemon operator <<(Pockemon pockemon, int deleteStamina) //удаление указанного кол-ва единиц от выносливости
        {
            if (pockemon.Stamina - deleteStamina >= minStamina)
            {
                pockemon.Stamina -= deleteStamina;
                return pockemon;
            }
            else throw new Exception("Ошибка! Выход за пределы диапазона возможных значений параметров");
        }

        public static Pockemon operator >(Pockemon pockemon, int addDefense) //добавление указанного кол-ва единиц к защите
        {
            if (pockemon.Defense + addDefense <= maxDefense)
            {
                pockemon.Defense += addDefense;
                return pockemon;
            }
            else throw new Exception("Ошибка! Выход за пределы диапазона возможных значений параметров");
        }
        public static Pockemon operator <(Pockemon pockemon, int addAttack) //добавление указанного кол-ва единиц к атаке
        {
            if (pockemon.Attack + addAttack <= maxAttack)
            {
                pockemon.Attack += addAttack;
                return pockemon;
            }
            else throw new Exception("Ошибка! Выход за пределы диапазона возможных значений параметров");
        }
        public static int GetCount //счетчик объектов класса
        {
            get => count;
        }
    }
}
