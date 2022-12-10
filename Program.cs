/* Задача. Создать массив сотрок, организовать проверку массива. 
 Все строки длинной менее 3 симводов скопировать в новый массив строк.*/
Console.WriteLine("Исходный массив слов:");
string[] strArray = new string[] { "alfa", "min", "betta", "gamma", "max", "delta", "sigma", "lda", "ert", "ql", "col" };

PrintArray(strArray);
string str = Vibor(strArray);
Console.WriteLine(str);

string Vibor(string[] array)
{
    string stroka = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            stroka = stroka + " "+array[i];
        }
    }
    return stroka;
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