namespace Laba_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 ЧАСТЬ

            /*Доступные диапазоны характеристик покемона:
              attack [17;414]
              defense [32;396]
              stamina [1;496]*/
            Console.WriteLine("I ЧАСТЬ");
            //неручной ввод х-к
            try
            {
                Console.WriteLine("Первый покемон (базовый)");
                Pockemon firstPockemon = new Pockemon(); //создание экземпляра класса с помощью конструктора без параметров
                InputOutput.ShowParametrs(firstPockemon);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("Второй покемон");
                Pockemon secondPockemon = new Pockemon(25, 50, 100); //создание экземпляра класса с помощью конструктора с параметрами
                InputOutput.ShowParametrs(secondPockemon);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("А что насчет ультрамега покемона с 1000 очками выносливости?");
                Pockemon errorPockemon = new Pockemon(25, 50, 1000); //создание экземпляра класса с некорректными параметрами
                InputOutput.ShowParametrs(errorPockemon);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //ручной ввод х-к
            try
            {
                int attack = InputOutput.InputAttack();
                int defense = InputOutput.InputDefense();
                int stamina = InputOutput.InputStamina();
                Pockemon thirdPockemon = new Pockemon(attack, defense, stamina); //создаем покемона с введенными х-ками

                //просмотр параметров покемонов
                InputOutput.ShowParametrs(thirdPockemon);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //увеличиваем параметры покемона
            //увеличиваем корректно (метод класса)
            try
            {
                Console.WriteLine("\nУвеличиваем х-ки БАЗОВОГО покемона (метод класса) на 20, 5 и 30 очков соотв.");
                Pockemon basePockemon = new Pockemon();
                basePockemon.AddParametrs(20, 5, 30);
                InputOutput.ShowParametrs(basePockemon);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //увеличиваем корректно (статическая функция)
            try
            {
                Console.WriteLine("\nУвеличиваем х-ки БАЗОВОГО покемона (статическая функция) также на 20, 5, и 30 очков соотв.");
                Pockemon basePockemon = new Pockemon();
                Pockemon.StaticAddParametrs(basePockemon, 20, 5, 30);
                InputOutput.ShowParametrs(basePockemon);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //увеличиваем некорректно (метод класса)
            try
            {
                Console.WriteLine("\nСлишком сильно увеличиваем х-ки БАЗОВОГО покемона (на 2000, 5000 и 3000 соотв.)");
                Pockemon basePockemon = new Pockemon();
                basePockemon.AddParametrs(2000, 5000, 3000);
                InputOutput.ShowParametrs(basePockemon);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //2 ЧАСТЬ
            Console.WriteLine("\nII ЧАСТЬ");

            //подсчет боевой мощи покемона
            Console.WriteLine("--БОЕВАЯ МОЩЬ ПОКЕМОНА");
            try
            {
                Pockemon pockemon = new Pockemon(52, 125, 100); //(√(125)*52*√(100))/10 = 581,378
                InputOutput.ShowParametrs(pockemon);
                double combatPower = ~pockemon;
                Console.WriteLine($"Боевая мощь покемона равна {combatPower}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //уменьшение выносливости покемона на 1 (корректно)
            Console.WriteLine("\n--УМЕНЬШЕНИЕ ВЫНОСЛИВОСТИ НА 1");
            try
            {
                Pockemon pockemon = new Pockemon(25, 52, 100); //выносливость должна быть равна 99
                InputOutput.ShowParametrs(pockemon);
                Pockemon modifiedPockemon = --pockemon;
                Console.WriteLine($"Уменьшим на 1 выносливость покемона. Результат: ВЫНОСЛИВОСТЬ = {modifiedPockemon.Stamina}");
                Console.WriteLine("Обновленные характеристики");
                InputOutput.ShowParametrs(modifiedPockemon);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //уменьшение выносливости покемона на 1 (некорректно)
            Console.WriteLine("\nУменьшим выносливость покемона, у которого она и так минимальная, на 1");
            try
            {
                Pockemon pockemon = new Pockemon(25, 52, 1); //выход за допустимый диапазон значений х-к (min выносливость = 1)
                InputOutput.ShowParametrs(pockemon);
                Pockemon modifiedPockemon = --pockemon;
                Console.WriteLine($"Уменьшим на 1 выносливость покемона. Результат: ВЫНОСЛИВОСТЬ = {modifiedPockemon.Stamina}");
                Console.WriteLine("Обновленные характеристики");
                InputOutput.ShowParametrs(modifiedPockemon);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //сумма х-к покемона
            Console.WriteLine("\n--СУММА ХАРАКТЕРИСТИК ПОКЕМОНА");
            try
            {
                Pockemon pockemon = new Pockemon(25, 52, 100); //сумма равна 25+52+100=177
                int sum = (int)pockemon; //явное преобразование
                InputOutput.ShowParametrs(pockemon);
                Console.WriteLine($"Сумма характеристик покемона равна {sum}>");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //среднее значениe х-к покемона
            Console.WriteLine("\n--СРЕДНЕЕ ЗНАЧЕНИЕ Х-К ПОКЕМОНА");
            try
            {
                Pockemon pockemon = new Pockemon(25, 52, 100); //ср. значение равно 59
                double meanValue = pockemon; //неявное преобразование
                InputOutput.ShowParametrs(pockemon);
                Console.WriteLine($"Среднее значение характеристик покемона равна {meanValue}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //добавление указанного кол-ва единиц к выносливости (корректно)
            Console.WriteLine("\n--ДОБАВЛЕНИЕ ОЧКОВ ВЫНОСЛИВОСТИ");
            try
            {
                Pockemon pockemon = new Pockemon(368, 105, 150);
                int addStamina = 50;
                InputOutput.ShowParametrs(pockemon);
                Console.WriteLine($"Добавим {addStamina} очков к выносливости покемона");
                Pockemon modifiedPockemon = pockemon >> addStamina;
                Console.WriteLine($"Теперь выносливость покемона равна {modifiedPockemon.Stamina}");
                Console.WriteLine("Обновленные характеристики");
                InputOutput.ShowParametrs(modifiedPockemon);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //добавление указанного кол-ва единиц к выносливости (некорректно)
            Console.WriteLine("\nДобавляем покемону слишком много очков выносливости");
            try
            {
                Pockemon pockemon = new Pockemon(368, 105, 150);
                int addStamina = 600;
                InputOutput.ShowParametrs(pockemon);
                Console.WriteLine($"Добавим {addStamina} очков к выносливости покемона");
                Pockemon modifiedPockemon = pockemon >> addStamina;
                Console.WriteLine($"Теперь выносливость покемона равна {modifiedPockemon.Stamina}");
                Console.WriteLine("Обновленные характеристики");
                InputOutput.ShowParametrs(modifiedPockemon);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //удаление указанного кол-ва единиц выносливости (корректно)
            Console.WriteLine("\n--УДАЛЕНИЕ ОЧКОВ ВЫНОСЛИВОСТИ");
            try
            {
                Pockemon pockemon = new Pockemon(368, 105, 150);
                int deleteStamina = 100;
                InputOutput.ShowParametrs(pockemon);
                Console.WriteLine($"Удалим {deleteStamina} очков выносливости покемона");
                Pockemon modifiedPockemon = pockemon << deleteStamina;
                Console.WriteLine($"Теперь выносливость покемона равна {modifiedPockemon.Stamina}");
                Console.WriteLine("Обновленные характеристики");
                InputOutput.ShowParametrs(modifiedPockemon);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //удаление указанного кол-ва единиц выносливости (некорректно)
            Console.WriteLine("\nУдаляем у покемона ВСЕ очки выносливости");
            try
            {
                Pockemon pockemon = new Pockemon(368, 105, 150);
                int deleteStamina = pockemon.Stamina;
                InputOutput.ShowParametrs(pockemon);
                Console.WriteLine($"Удалим у покемона {deleteStamina} очков выносливости (то есть все)");
                Pockemon modifiedPockemon = pockemon << deleteStamina;
                Console.WriteLine($"Теперь выносливость покемона равна {modifiedPockemon.Stamina}");
                Console.WriteLine("Обновленные характеристики");
                InputOutput.ShowParametrs(modifiedPockemon);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //добавление указанного кол-ва единиц к защите (корректно)
            Console.WriteLine("\n--ДОБАВЛЕНИЕ ОЧКОВ ЗАЩИТЫ");
            try
            {
                Pockemon pockemon = new Pockemon(160, 70, 200);
                int addDefense = 200;
                InputOutput.ShowParametrs(pockemon);
                Console.WriteLine($"Добавим покемону {addDefense} очков защиты");
                Pockemon modifiedPockemon = pockemon > addDefense;
                Console.WriteLine($"Теперь защита покемона равна {modifiedPockemon.Defense}");
                Console.WriteLine("Обновленные характеристики");
                InputOutput.ShowParametrs(modifiedPockemon);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //добавление указанного кол-ва единиц к защите (некорректно)
            Console.WriteLine("\nДобавляем покемону слишком много очков защиты");
            try
            {
                Pockemon pockemon = new Pockemon(160, 70, 200);
                int addDefense = 1000;
                InputOutput.ShowParametrs(pockemon);
                Console.WriteLine($"Добавим покемону {addDefense} очков защиты");
                Pockemon modifiedPockemon = pockemon > addDefense;
                Console.WriteLine($"Теперь защита покемона равна {modifiedPockemon.Defense}");
                Console.WriteLine("Обновленные характеристики");
                InputOutput.ShowParametrs(modifiedPockemon);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //добавление указанного кол-ва единиц к атаке (корректно)
            Console.WriteLine("\n--ДОБАВЛЕНИЕ ОЧКОВ АТАКИ");
            try
            {
                Pockemon pockemon = new Pockemon(100, 100, 100);
                int addAttack = 55;
                InputOutput.ShowParametrs(pockemon);
                Console.WriteLine($"Добавим покемону {addAttack} очков атаки");
                Pockemon modifiedPockemon = pockemon < addAttack;
                Console.WriteLine($"Теперь атака покемона равна {modifiedPockemon.Attack}");
                Console.WriteLine("Обновленные характеристики");
                InputOutput.ShowParametrs(modifiedPockemon);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //добавление указанного кол-ва единиц к атаке (некорректно)
            Console.WriteLine("\nДобавляем покемону слишком много очков атаки");
            try
            {
                Pockemon pockemon = new Pockemon(100, 100, 100);
                int addAttack = 550;
                InputOutput.ShowParametrs(pockemon);
                Console.WriteLine($"Добавим покемону {addAttack} очков атаки");
                Pockemon modifiedPockemon = pockemon < addAttack;
                Console.WriteLine($"Теперь атака покемона равна {modifiedPockemon.Attack}");
                Console.WriteLine("Обновленные характеристики");
                InputOutput.ShowParametrs(modifiedPockemon);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //3 ЧАСТЬ
            Console.WriteLine("\nIII ЧАСТЬ");

            //создание базовой коллекции (констурктор без параметров)
            Console.WriteLine("Создаем базовую коллекцию (конструктор без параметров)");
            PockemonArray firstPockemons = new PockemonArray();
            InputOutput.ShowPockemons(firstPockemons);

            //создание коллекции (констурктор с параметрами)
            Console.WriteLine("\nСоздаем новую коллекцию (конструктор с параметрами)");
            PockemonArray secondPockemons = new PockemonArray(8);
            InputOutput.ShowPockemons(secondPockemons);

            //создание коллекции (ввод с клавиатуры)
            try
            {
                Console.WriteLine("\nСоздаем коллекцию c помощью ввода с клавиатуры");
                int length; //вводимое значение выносливости
                bool isChecked = true; //проверка на соответствие типу Int
                string buffer;
                Console.WriteLine("Введите длину коллекции (неотрицательное число)");
                do
                {
                    buffer = Console.ReadLine();
                    isChecked = int.TryParse(buffer, out length);
                    if (length < 0)
                    {
                        isChecked = false;
                    }
                    if (!isChecked)
                    {
                        Console.WriteLine("Длина коллекции должна быть неотрицательной");
                    }
                } while (!isChecked);
                PockemonArray thirdPockemons = PockemonArray.CreateArray(length);
                InputOutput.ShowPockemons(thirdPockemons);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //глубокое копирование
            try
            {
                Console.WriteLine("\nСоздаем коллекцию, которую будем копировать");
                PockemonArray pockemons = new PockemonArray(5);
                InputOutput.ShowPockemons(pockemons);

                PockemonArray copiedPockemons = new PockemonArray(pockemons);
                Console.WriteLine("\nСкопированный набор покемонов:");
                InputOutput.ShowPockemons(copiedPockemons);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //демонстрация работы индексатора
            try
            {
                Console.WriteLine("\nОбратимся к покемону из набора, представленному ниже");
                InputOutput.ShowPockemons(secondPockemons); //secondPockemons - массив из 8 рандомных покемонов
                Console.WriteLine("\nЭлемент с индексом 5 (6 покемон):");
                InputOutput.ShowParametrs(secondPockemons[5]);

                Console.WriteLine("\nПопробуем записать элемент в этот набор");
                secondPockemons[5] = new Pockemon(50, 50, 50); //меняем покемона,к которому обращались
                Console.WriteLine("ИЗМЕНЕННЫЙ элемент с индексом 5 (6 покемон):");
                InputOutput.ShowParametrs(secondPockemons[5]);

                Console.WriteLine("\nОбратимся к НЕСУЩЕСТВУЮЩЕМУ покемону из набора");
                Console.WriteLine("Элемент с индексом 15 (16 покемон):");
                InputOutput.ShowParametrs(secondPockemons[15]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                Console.WriteLine("\nПопробуем записать элемент в этот набор на НЕСУЩЕСТВУЮЩУЮ позицию");
                secondPockemons[25] = new Pockemon(100, 100, 100); //меняем покемона, которого нет
                Console.WriteLine($"ИЗМЕНЕННЫЙ элемент с индексом 25 (26 покемон):");
                InputOutput.ShowParametrs(secondPockemons[25]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //определение моды выносливости
            try
            {
                Console.WriteLine("\nНайдем моду выносливости для набора покемонов (введем вручную)");
                Console.WriteLine("\nСоздаем коллекцию c помощью ввода с клавиатуры");
                int length; //вводимое значение выносливости
                bool isChecked = true; //проверка на соответствие типу Int
                string buffer;
                Console.WriteLine("Введите длину коллекции (неотрицательное число)");
                do
                {
                    buffer = Console.ReadLine();
                    isChecked = int.TryParse(buffer, out length);
                    if (length < 0)
                    {
                        isChecked = false;
                    }
                    if (!isChecked)
                    {
                        Console.WriteLine("Длина коллекции должна быть неотрицательной");
                    }
                } while (!isChecked);
                PockemonArray pockemons = PockemonArray.CreateArray(length);
                InputOutput.ShowPockemons(pockemons);
                int thisMode = pockemons.GetStaminaMode();
                Console.WriteLine($"\nМода выносливости для данного набора покемонов: {thisMode}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //вывод кол-ва созданных покемонов и созданных коллекций
            Console.WriteLine($"\nКол-во созданных покемонов: {Pockemon.GetCount}");
            Console.WriteLine($"\nКол-во созданных коллекций покемонов: {PockemonArray.GetCountArray}");
        }
    }
}
