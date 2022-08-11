// Задача N2 Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] massive = new int[10];
int index = 0;

while(index < massive.Length)
{
    massive[index] = new Random().Next(-9, 10);
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
int count = 0;

while(index < massive.Length)
{
    if(index % 2 == 1)
    {
        count += massive[index];
        index++;
    }
    else
    {
        index++;
    }
}

Console.WriteLine("Сумма чисел на нечетных позициях массива равна " + count);