﻿Console.Write("Введите трехзначное число - ");
int num = Convert.ToInt32(Console.ReadLine());
int len_num = (int)Math.Log10(num);     // у 3-х значного числа десятичный логарифм будет в диапазоне от [2 до 3)

////////// ПРОВЕРКА ЧИСЛА НА ВВОД ТРЕХЗНАЧНОГО ЧИСЛА ///////////////
if (len_num >= 3)
{
    Console.WriteLine("Вы ввели не трехзначное число, попробуйте еще раз.");
}
else if (len_num >= 1 && len_num < 2)
{
    Console.WriteLine("Вы ввели двухзначное число, попробуйте еще раз");
}
else if(len_num < 1)
{
    Console.WriteLine("Вы ввели однозначное число, попробуйте еще раз");
}
else
{
    /////// АЛГОРИТМ НАХОЖДЕНИЯ ВТОРОЙ ЦИФРЫ ЧИСЛА //////////////////
    int num_change = num / 10;    // переводим число в десятки
    int result = num_change % 10;   // находим остаток от деления десятичного числа, это и будет нашим искомым числом 
    Console.WriteLine("Вторая цифра числа - " + result);
}


