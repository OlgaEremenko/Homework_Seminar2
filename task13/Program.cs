// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. Решить без использования строк.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// Целочисленное, остаток от деления и цикл

Console.Write("Введите число ");
int InputNumber = Convert.ToInt32 (Console.ReadLine ());

int findThirdDigit (int InputNumber)

{
    int CurrentNumber = InputNumber;
    
    while (CurrentNumber > 999) 
        {
            CurrentNumber = CurrentNumber / 10;
        }
        
    int result = CurrentNumber % 10;
    return result;
}

if (InputNumber < 100)
    {
    Console.WriteLine("Третьей цифры нет");
    }
else
    {
    Console.WriteLine($"Обработанное число {findThirdDigit(InputNumber)}");
    }
