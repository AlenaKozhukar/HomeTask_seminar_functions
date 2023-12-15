// Задача 3: Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)

Console.WriteLine("Введите размер массива"); 
int num = Convert.ToInt32(Console.ReadLine()); 
                                            
int[] array = new int[num]; 

CreateArray();
int[] CreateArray()
{
for(int i = 0; i<array.Length; i++) 
{
    array[i]= new Random().Next(0,20);  
    Console.Write(array[i]+ " ");
}
return array;
}

Console.WriteLine(); 

ReverseArray();

int[] ReverseArray()
{
int temp;                                
for (int i = 0; i < array.Length; i++) 
{
    temp = array[i];                       
    array[i] = array[array.Length-i-1];                             
    array[array.Length-i-1] = temp;
    Console.Write(array[i] + " ");                 
}
return array;
}

