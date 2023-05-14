/*
Используя Visual Studio, создайте проект по шаблону Console Application.
Создайте программу, в которой создайте анонимный метод, который принимает в качестве
аргумента массив делегатов и возвращает среднее арифметическое возвращаемых значений
методов сообщенных с делегатами в массиве. Методы, сообщенные с делегатами из массива,
возвращают случайное значение типа int.
*/
int RandomNum()
{
    Random random = new Random();
    return random.Next(0, 100);
}

Random random = new Random();

RandomNumDelegate[] randomNumDelegate = new RandomNumDelegate[random.Next(0,10)];

for (int i = 0; i < randomNumDelegate.Length; i++)
{
    randomNumDelegate[i] = RandomNum;
}

AverageNum averageNum = delegate(RandomNumDelegate[] delArray)
{
    int sum = 0;
    for (int i = 0; i < delArray.Length; i++)
    {
        sum += delArray[i].Invoke();
    }
    return sum / delArray.Length;
};

float result = (float)averageNum(randomNumDelegate);
Console.WriteLine("Среднее арифметическое всех значений: " + result);

public delegate int RandomNumDelegate();
public delegate int AverageNum(RandomNumDelegate[] delArray);
