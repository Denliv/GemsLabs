using System.Reflection;
using Task3.Enums;
using Task3.Exceptions;
using Task3.Interfaces;
using Task3.Models;

namespace Task3.Generators;

public abstract class VenicleGenerator
{
    public static AVenicle GenerateVenicle()
    {
        VenicleColor color = (VenicleColor)new Random().Next(Enum.GetNames(typeof(VenicleColor)).Length);
        int licensePlateNumber = new Random().Next(100, 1000);
        bool hasPassenger = new Random().Next(0, 2) != 0;
        VenicleBodyType bodyType = (VenicleBodyType)new Random().Next(Enum.GetNames(typeof(VenicleBodyType)).Length);
        int speed = SpeedGenerator.GenerateSpeed(bodyType);
        //Получаем тип интерфейса
        var interfaceType = typeof(IGeneratable);
        //Создаём список классов
        var listOfClasses = new List<Type>();
        //Получаем массив всех классов в текущем проекте
        var allClasses = Assembly.LoadFrom(Assembly.GetEntryAssembly()!.Location).GetTypes();
        //Ищем такие классы, которые являются реализацией интерфейса IGeneratable, но не являются IGeneratable
        foreach (var i in allClasses)
        {
            if (i != interfaceType && interfaceType.IsAssignableFrom(i))
            {
                listOfClasses.Add(i);
            }
        }
        //Если таких классов нет, то ошибка
        if (listOfClasses.Count == 0)
            throw new VenicleGeneratorException("Error: There are no classes that can be generated\n");
        Type type = listOfClasses[new Random().Next(0, listOfClasses.Count)];
        return (Activator.CreateInstance(type, color, licensePlateNumber, hasPassenger, speed) as
            AVenicle)!;
    }
}