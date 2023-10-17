int FindThirdNumber(int number)
//--------------------  ФУНКЦИЯ ПО ОБРАБОТКЕ ЧИСЛА И НАХОЖДЕНИЯ ТРЕТЬЕЙ ЦИФРЫ ЧИСЛА ----------------------------------------------
//                    Данная функция возвращет либо -1, либо нашу третью цифру числа
{
    int result = 0;

    if (number < 100)
    {
        result = -1;    // Данный возврат будет только в том случае, если число не трехзначное
    }
    else if (number > 1000)
    {
        
        while(number > 999)
        {
            number /= 10; 
        }

        result = number % 10;
    }
    else
    {
        result  = number % 10;
    }

    return result;         
}


Console.Write("Введите число - ");
int num = Convert.ToInt32(Console.ReadLine());

int third_number = FindThirdNumber(num);  // Вызываем функцию, которая обработает наше число

//---------- ПРОВЕРЯЕМ ЧТО НАМ ВЕРНУЛА НАША ФУНКЦИЯ------------------------------
if (third_number == -1)
{
    Console.WriteLine("Третьей цифры нет.");
}
else
{
    Console.WriteLine("Третья цифра числа - " + third_number);
}

