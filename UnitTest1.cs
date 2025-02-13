using Laba_9;
using System;
using System.Collections;

namespace Laba_9.Tests;

[TestClass]
public class UnitTest1
{
    //КЛАСС Pockemon

    //Часть I
    [TestMethod] //конструктор без параметров
    public void ConstructorDefault()
    {
        //Arrange
        Pockemon pockemon = new Pockemon(17, 32, 1);

        //Act
        Pockemon testPockemon = new Pockemon();

        //Assert
        Assert.AreEqual(testPockemon, pockemon);
    }

    [TestMethod] //конструктор с параметрами
    public void ConstructorWithParametrs()
    {
        //Arrange
        Pockemon testPockemon = new Pockemon(55, 100, 82);

        //Act
        Pockemon pockemon = new Pockemon(55, 100, 82);

        //Assert
        Assert.AreEqual(testPockemon, pockemon);
    }

    [TestMethod] //превышение допустимого значения атаки
    [ExpectedException(typeof(Exception))]
    public void MaximumAttackError()
    {
        Pockemon pockemon = new Pockemon(1000, 50, 82);
    }

    [TestMethod] //слишком маленькое значение для атаки
    [ExpectedException(typeof(Exception))]
    public void MinimumAttackError()
    {
        Pockemon pockemon = new Pockemon(-5, 50, 82);
    }

    [TestMethod] //слишком большое значение для защиты
    [ExpectedException(typeof(Exception))]
    public void MaximumDefenseError()


    {
        Pockemon pockemon = new Pockemon(25, 3000, 18);
    }

    [TestMethod] //слишком маленькое значение для защиты
    [ExpectedException(typeof(Exception))]
    public void MinimumDefenseError()
    {
        Pockemon pockemon = new Pockemon(25, 0, 18);
    }

    [TestMethod] //слишком большое значение для выносливости
    [ExpectedException(typeof(Exception))]
    public void MaximumStaminaError()
    {
        Pockemon pockemon = new Pockemon(25, 52, 500);
    }

    [TestMethod] //слишком маленькое значение для выносливости
    [ExpectedException(typeof(Exception))]
    public void MinimumStaminaError()
    {
        Pockemon pockemon = new Pockemon(25, 52, -7);
    }

    [TestMethod]
    public void CorrectAddParametrs() //корректное добавление параметров (метод класса)
    {
        //Arrange
        Pockemon pockemon = new Pockemon(100, 50, 80);

        //Act
        pockemon.AddParametrs(15, 20, 25);

        //Assert
        Assert.AreEqual(pockemon.Attack, 115);
        Assert.AreEqual(pockemon.Defense, 70);
        Assert.AreEqual(pockemon.Stamina, 105);
    }

    [TestMethod]
    [ExpectedException(typeof(Exception))]
    public void ErrorAddParametrs() //ошибочное добавление параметров (метод класса)
    {
        //Arrange
        Pockemon pockemon = new Pockemon(100, 50, 80);

        //Act
        pockemon.AddParametrs(1500, 2000, 2500);
    }

    [TestMethod]
    public void CorrectStaticAddParametrs() //корректное добавление параметров (статическая функция)
    {
        //Arrange
        Pockemon pockemon = new Pockemon(100, 50, 80);

        //Act
        Pockemon.StaticAddParametrs(pockemon, 15, 20, 25);

        //Assert
        Assert.AreEqual(pockemon.Attack, 115);
        Assert.AreEqual(pockemon.Defense, 70);
        Assert.AreEqual(pockemon.Stamina, 105);
    }

    [TestMethod]
    [ExpectedException(typeof(Exception))]
    public void ErrorStaticAddParametrs() //ошибочное добавление параметров (статическая функция)
    {
        //Arrange
        Pockemon pockemon = new Pockemon(100, 50, 80);

        //Act
        Pockemon.StaticAddParametrs(pockemon, 1500, 2000, 2500);
    }

    //Часть II
    [TestMethod]
    public void CalculatePower() //подсчет боевой мощи
    {
        //Arrange
        Pockemon pockemon = new Pockemon(60, 80, 120);

        //Act
        double combatPower = ~pockemon;

        //Assert
        Assert.AreEqual(587.88, combatPower, 2); // проверяем с точностью до 2 знаков
    }

    [TestMethod]
    public void DecreasedStamina() //корректное уменьшение выносливости
    {
        //Arrange
        Pockemon pockemon = new Pockemon(70, 130, 150);

        //Act
        pockemon--;

        //Assert
        Assert.AreEqual(149, pockemon.Stamina); // Проверяем с точностью до 2 знаков
    }

    [TestMethod]
    [ExpectedException(typeof(Exception))]
    public void ErrorDecreasedStamina() //ошибочное уменьшение выносливости
    {
        //Arrange
        Pockemon pockemon = new Pockemon(55, 77, 1);

        //Act
        pockemon--;
    }

    [TestMethod]
    public void SumOfParametrs() //неявное преобразование типа
    {
        //Arrange
        Pockemon pockemon = new Pockemon(50, 50, 50);

        //Act
        int sum = (int)pockemon;

        //Assert
        Assert.AreEqual(150, sum);
    }

    [TestMethod]
    public void MeanValueOfParameters() //среднее значение х-к
    {
        //Arrange
        Pockemon pockemon = new Pockemon(60, 120, 30);

        //Act
        double meanValue = pockemon;

        //Assert
        Assert.AreEqual(70, meanValue);
    }

    [TestMethod]
    public void CorrectAddStamina() //корректное добавление очков выносливости
    {
        //Arrange
        Pockemon pockemon = new Pockemon(320, 100, 160);
        int addStamina = 20;

        //Act
        Pockemon modifiedPockemon = pockemon >> addStamina;

        //Assert
        Assert.AreEqual(180, modifiedPockemon.Stamina);
    }

    [TestMethod]
    [ExpectedException(typeof(Exception))]
    public void ErrorAddStamina() //ошибочное добавление очков выносливости
    {
        //Arrange
        Pockemon pockemon = new Pockemon(320, 100, 160);
        int addStamina = 800;

        //Act
        Pockemon modifiedPockemon = pockemon >> addStamina;
    }

    [TestMethod]
    public void CorrectDeleteStamina() //корректное удаление очков выносливости
    {
        //Arrange
        Pockemon pockemon = new Pockemon(250, 60, 160);
        int deleteStamina = 60;

        //Act
        Pockemon modifiedPockemon = pockemon << deleteStamina;

        //Assert
        Assert.AreEqual(100, modifiedPockemon.Stamina);
    }

    [TestMethod]
    [ExpectedException(typeof(Exception))]
    public void ErrorDeleteStamina() //ошибочное удаление очков выносливости
    {
        //Arrange
        Pockemon pockemon = new Pockemon(250, 60, 160);
        int deleteStamina = 200;

        //Act
        Pockemon modifiedPockemon = pockemon << deleteStamina;
    }

    [TestMethod]
    public void CorrectAddDefense() //корректное добавление очков защиты
    {
        //Arrange
        Pockemon pockemon = new Pockemon(400, 200, 300);
        int addDefense = 70;

        //Act
        Pockemon modifiedPockemon = pockemon > addDefense;

        //Assert
        Assert.AreEqual(270, modifiedPockemon.Defense);
    }

    [TestMethod]
    [ExpectedException(typeof(Exception))]
    public void ErrorAddDefense() //ошибочное добавление очков защиты
    {
        //Arrange
        Pockemon pockemon = new Pockemon(400, 200, 300);
        int addDefense = 200;

        //Act
        Pockemon modifiedPockemon = pockemon > addDefense;
    }

    [TestMethod]
    public void CorrectAddAttack() //корректное добавление очков атаки
    {
        //Arrange
        Pockemon pockemon = new Pockemon(150, 180, 210);
        int addAttack = 264;

        //Act
        Pockemon modifiedPockemon = pockemon < addAttack;

        //Assert
        Assert.AreEqual(414, modifiedPockemon.Attack); //значение х-ки "Атака" достигнет максимума, это допустимо
    }

    [TestMethod]
    [ExpectedException(typeof(Exception))]
    public void ErrorAddAttack() //ошибочное добавление очков атаки
    {
        //Arrange
        Pockemon pockemon = new Pockemon(150, 180, 210);
        int addAttack = 265;

        //Act
        Pockemon modifiedPockemon = pockemon < addAttack; //значение х-ки "Атака" превысит максимум, это НЕ допустимо
     }

    [TestMethod] //проверка счетчика покемонов
    public void GetCounter()
    {
        //Arrange
        int count = Pockemon.GetCount;

        //Act
        Pockemon firstPockemon = new Pockemon();
        Pockemon secondPockemon = new Pockemon(200, 250, 300);

        //Assert
        Assert.AreEqual(count + 2, Pockemon.GetCount);
    }

    //КЛАСС PockemonArray

    //Часть III
    [TestMethod] //конструктор без параметров (проверяем длину)
    public void ArrayConstructorDefault()
    {
        //Arrange + Act
        PockemonArray pockemons = new PockemonArray();

        //Assert
        Assert.AreEqual(6, pockemons.Length);
    }

    [TestMethod] //конструктор с параметрами (проверяем длину)
    public void ArrayConstructorWithParametrs()
    {
        //Arrange + Act
        PockemonArray pockemons = new PockemonArray(8);

        //Assert
        Assert.AreEqual(8, pockemons.Length);
    }

    [TestMethod] //ошибочный конструктор с параметрами (некорректная длина)
    [ExpectedException(typeof(Exception))]
    public void ErrorArrayConstructorWithParametrs()
    {
        //Arrange + Act
        PockemonArray pockemons = new PockemonArray(-5);
    }

    [TestMethod] //индексатор, обращение к элементу (корректно)
    public void CorrectGetIndexer()
    {
        //Arrange
        PockemonArray pockemons = new PockemonArray(10);

        //Act
        Pockemon testPockemon = pockemons[5];

        //Assert
        Assert.AreEqual(testPockemon, pockemons[5]);
    }

    [TestMethod] //ошибочный индексатор, обращение к элементу (индекс превышает длину)
    [ExpectedException(typeof(Exception))]
    public void ErrorGetIndexer()
    {
        //Arrange
        PockemonArray pockemons = new PockemonArray(7);

        //Act
        Pockemon testPockemon = pockemons[10];
    }

    [TestMethod] //индексатор, установка значения (корректно)
    public void CorrectSetIndexer()
    {
        //Arrange
        PockemonArray pockemons = new PockemonArray(10);
        Pockemon updatePockemon = new Pockemon(70, 80, 120);

        //Act
        pockemons[6] = updatePockemon;

        //Assert
        Assert.AreEqual(pockemons[6], updatePockemon);
    }

    [TestMethod] //ошибочный индексатор, установка значения (индекс превышает длину)
    [ExpectedException(typeof(Exception))]
    public void ErrorSetIndexer()
    {
        //Arrange
        PockemonArray pockemons = new PockemonArray(7);
        Pockemon updatePockemon = new Pockemon(60, 80, 100);

        //Act
        pockemons[10] = updatePockemon;
    }

    [TestMethod] //ошибочный индексатор, установка значения (индекс отрицательный)
    [ExpectedException(typeof(Exception))]
    public void NegativeSetIndexErrorIndexer()
    {
        //Arrange
        PockemonArray pockemons = new PockemonArray(7);
        Pockemon updatePockemon = new Pockemon(60, 80, 100);

        //Act
        pockemons[-3] = updatePockemon;
    }

    [TestMethod] //глубокое копирование
    public void DeepCopying()
    {
        //Arrange
        PockemonArray pockemons = new PockemonArray(2);
        pockemons[0] = new Pockemon(100, 110, 160);
        pockemons[1] = new Pockemon(80, 90, 100);

        //Act
        PockemonArray copiedPockemons = new PockemonArray(pockemons);

        //Assert
        Assert.AreEqual(copiedPockemons.Length, pockemons.Length); //сравниваем длины
        Assert.AreNotSame(copiedPockemons[0], pockemons[0]); //проверяем, что это разные объекты
        Assert.AreEqual(copiedPockemons[0].Attack, pockemons[0].Attack);
        Assert.AreEqual(copiedPockemons[0].Defense, pockemons[0].Defense);
        Assert.AreEqual(copiedPockemons[0].Stamina, pockemons[0].Stamina);
    }

    [TestMethod] //глубокое копирование пустого массива
    [ExpectedException(typeof(Exception))]
    public void ErrorDeepCopying()
    {
        //Arrange
        PockemonArray pockemons = new PockemonArray(0);

        //Act
        PockemonArray copiedPockemons = new PockemonArray(pockemons);
    }

    [TestMethod] //получение моды выносливости среди покемонов из набора
    public void CorrectGetStaminaMode()
    {
        //Arrange
        PockemonArray pockemons = new PockemonArray(4);
        pockemons[0] = new Pockemon(100, 110, 170);
        pockemons[1] = new Pockemon(80, 90, 100);
        pockemons[2] = new Pockemon(50, 70, 170);
        pockemons[3] = new Pockemon(200, 250, 30);

        //Act
        int staminaMode = pockemons.GetStaminaMode();

        //Assert
        Assert.AreEqual(170, staminaMode);
    }

    [TestMethod] //глубокое копирование пустого массива
    [ExpectedException(typeof(Exception))]
    public void ErrorGetStaminaMode()
    {
        //Arrange
        PockemonArray pockemons = new PockemonArray(0);

        //Act
        int staminaMode = pockemons.GetStaminaMode();
    }

    [TestMethod] //проверка счетчика массивов покемонов
    public void GetCounterArray()
    {
        //Arrange
        int count = PockemonArray.GetCountArray;

        //Act
        PockemonArray firstPockemons = new PockemonArray();
        PockemonArray secondPockemons = new PockemonArray(10);
        PockemonArray thirdPockemons = new PockemonArray(5);

        //Assert
        Assert.AreEqual(count + 3, PockemonArray.GetCountArray);
    }
}