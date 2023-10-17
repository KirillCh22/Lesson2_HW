Console.Write("Введите цифру дня недели - ");
string? number = Console.ReadLine();

switch(number)
{
    case "1":
        Console.WriteLine("Данный день не является выходным, это - Понедельник.");
        break;
    case "2":
        Console.WriteLine("Данный день не является выходным, это - Вторник.");
        break;
    case "3":
        Console.WriteLine("Данный день не является выходным, это - Среда.");
        break;
    case "4":
        Console.WriteLine("Данный день не является выходным, это - Четверг.");
        break;
    case "5":
        Console.WriteLine("Данный день не является выходным, это - Пятница.");
        break;
    case "6":
        Console.WriteLine("Данный день является выходным, это - Суббота.");
        break;
    case "7":
        Console.WriteLine("Данный день является выходным, это - Воскресенье.");
        break;
    default:
        Console.WriteLine("Такого дня недели не существует, попробуйте еще раз.");
        break;
}
