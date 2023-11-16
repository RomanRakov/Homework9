using System;
namespace lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная 10 главы\nУпражнение 10.1\n");
            var cipher = new ACipher(); string originalString = "RSTDtrw";
            string encryptedString = cipher.Encode(originalString); string decryptedString = cipher.Decode(encryptedString);
            Console.WriteLine($"Начальная строка: {originalString}\nЗашифрованная строка: {encryptedString}\nРасшифрованная строка: {decryptedString}\n");
            var newcipher = new BCipher(); string neworiginalString = "RSTDtrw";
            string newencryptedString = newcipher.Encode(neworiginalString); string newdecryptedString = newcipher.Decode(newencryptedString);
            Console.WriteLine($"Начальная строка: {neworiginalString}\nЗашифрованная строка: {newencryptedString}\nРасшифрованная строка: String: {newdecryptedString}\n"); 

            Console.WriteLine("Домашнее задание 10.1\n");
            var point = new Point("Red", true);
            point.MoveHorizontal(5);
            point.MoveVertical(3);
            point.ChangeColor("Blue");
            point.DisplayState();
            Console.WriteLine(); 
            var circle = new Circle("Green", true, 5);
            circle.MoveHorizontal(-2);
            circle.MoveVertical(4);
            circle.ChangeColor("Yellow");
            circle.DisplayState();
            Console.WriteLine($"Площадь окружности: {circle.CalculateArea()}\n");
            var rectangle = new Rectangle("Orange", true, 4, 6);
            rectangle.MoveHorizontal(3);
            rectangle.MoveVertical(-2);
            rectangle.ChangeColor("Purple");
            rectangle.DisplayState();
            Console.WriteLine($"Площадь прямоугольника: {rectangle.CalculateArea()}");
            Console.ReadKey();
        }
    }
}
