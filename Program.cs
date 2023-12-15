// Задача 1: Напишите программу, которая бесконечно запрашивает 
// целые числа с консоли. Программа завершается при вводе символа 
// ‘q’ или при вводе числа, сумма цифр которого чётная.

void StopSymbolOrNumber()
{
for(int i = 0; ; i++)
{
    Console.WriteLine("Введите число");
    string stop = Console.ReadLine();

    if(stop == "q")
    {
        break;
    }

int num = Convert.ToInt32(stop);
int result = num;
int sum = 0;

while(result > 0)
{
sum = sum + result%10;
result = result/10;
}
    if (sum%2 == 0)
    {
    break;
    }
}
}

StopSymbolOrNumber();