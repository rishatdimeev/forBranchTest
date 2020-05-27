using System;

namespace Prototype
{
    /*
        Назначение паттерна: Позволяет настроить виды создаваемых объектов - клонов, с помощью оригинала и создает новые объекты путем клонирования оригинала
        (Не применяется, если не перейти на прототипно ориентированное программирование, и в .Net данный паттерн нашел свое выражение в виде двух объектов,
        это интерфейс ICloneable и метод MemberwiseClone)
        
        Паттерн уровня объектов (описывает как происходит порождение объектов)
    */
    class Program
    {
        static void Main(string[] args)
        {
            Prototype prototype;
            Prototype original;

            prototype = new ConcretePrototype1(1);
            original = prototype.Clone();

            prototype = new ConcretePrototype2(2);
            original = prototype.Clone();
        }
    }
}
