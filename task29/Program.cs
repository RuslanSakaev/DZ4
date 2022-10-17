// Задача 29: 
// Напишите программу, которая задаёт массив из 8 элементов, 
// заполненный псевдослучайными числами
// и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Write("Введите размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] arrayGlobal = new int[num];

FillArrayRandom(arrayGlobal);
PrintArray(arrayGlobal);

void FillArrayRandom(int[] array)
{
    var rnd = new Random();
    for (int i = 0; i <= array.Length - 1; i++) array[i] = rnd.Next(); 
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i <= array.Length - 1; i++) Console.Write($"{array[i]}, ");
    Console.Write($"{array[array.Length - 1]}]");
}
