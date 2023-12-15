// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите размер массива");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[num];

CreateArray();
System.Console.WriteLine(", количество четных чисел " + FindNumber());


int[] CreateArray()
{
for(int i = 0; i<array.Length; i++)
{
    array[i]= new Random().Next(100,1000); 
    Console.Write(array[i]+ " ");
}
return array;
}

int FindNumber()
{
int countNumber = 0;
for(int i = 0; i<array.Length; i++)
{
    if(array[i]%2 ==0)
    {
        countNumber = countNumber+1;
    }
}
return countNumber;
}