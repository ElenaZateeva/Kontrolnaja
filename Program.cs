/* Задача. Создать массив сотрок, организовать проверку массива. 
 Все строки длинной менее 3 симводов скопировать в новый массив строк.*/
Console.WriteLine("Исходный массив слов:");
string[] strArray = new string[] { "alfa", "min", "betta", "gamma", "max", "delta", "sigma", "lda", "ert", "ql", "col" };

PrintArray(strArray);
string[] strArray2 = Vibor(strArray);
PrintArray(strArray2);

string[] Vibor(string[] array)
{
    string[] array2 = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            array2[j] = array[i];
            j++;
        }
    }
    return array2;
}


void PrintArray(string[] array)
{
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}