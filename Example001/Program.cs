/*
Задача 24: Напишите программу, 
которая принимает на вход число (А) и выдаёт 
сумму чисел от 1 до А.
*/

int GetSumFrom1ToN(int num)
{
    int result = 0;
    for (int i = 0; i <= num; i++)
    {
        result = result + i;
    }

    return result;
}

int userNum = GetSumFrom1ToN(10);
System.Console.WriteLine(userNum);