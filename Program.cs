/* Задача. Создать массив сотрок, организовать проверку массива. 
 Все строки длинной менее 3 симводов скопировать в новый массив строк.*/

 string[] strArray = new string[] {"alfa","betta","gamma","delta","sigma","lda"};

PrintArray(strArray);
Console.WriteLine();

void PrintArray(string[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}