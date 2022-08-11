// Задача N1 Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] massive = new int[5];
int index = 0;
while(index < massive.Length)
{
    massive[index] = new Random().Next(100, 1000);
    index++;
}

index = 0;

while(index < massive.Length - 1)
{
    Console.Write(massive[index] + ", ");
    index++;
}
Console.WriteLine(massive[index]);

Console.Write("Количество четных в массиве: ");

index = 0;
int count = 0;

while(index < massive.Length)
{
    if(massive[index] % 2 == 0)
    {
        count ++;
        index++;
    }
    else
    {
        index++;
    }
}

Console.Write(count);

