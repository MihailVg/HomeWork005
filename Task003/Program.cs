// Задача N3 Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

int[] massive = new int[10];
int index = 0;

while(index < massive.Length)
{
    massive[index] = new Random().Next(-99, 100);
    index++;
}

index = 0;
while(index < massive.Length - 1)
{
    Console.Write(massive[index] + ", "); 
    index++;
}
Console.WriteLine(massive[index]);

index = 0;
int max = massive[0];
while(index < massive.Length)
{
    if(max < massive[index])
    {
        max = massive[index];
        index++;
    }
    else
    {
        index++;
    }
}
Console.WriteLine("Максимальным числом в массиве является " + max);

index = 0;
int min = massive[0];
while(index < massive.Length)
{
    if(min > massive[index])
    {
        min = massive[index];
        index++;
    }
    else
    {
        index++;
    }
}

Console.WriteLine("Минимальным числом в массиве является " + min);

int diff = max - min;

Console.WriteLine("Разница между минимальным и максимальным числом в массиве: " + diff);
