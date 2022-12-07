//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
Console.Clear();

int i = 0;
int numberA = Convert.ToInt32(8);
int [] array = new int [numberA];
for (i = 0; i<numberA; i++)
{
    array[i] = new Random().Next(numberA + 1);
    Console.Write(array[i] + "; ");
}

 