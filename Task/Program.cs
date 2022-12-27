//Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых равна меньше
//либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
//выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойти исключительно массивами.

string[] array1 = new string[4] {"5", "hello", "1", "700"};
string [] array2 = new string[array1.Length];
ReformArray(array1, array2);
PrintArrray(array2);

void ReformArray(string[] array1, string[] array2)
{
int counter = 0;
for (int  i = 0; i < array1.Length; i++)
{
    if (array1[i].Length <= 3)
    {
      array2[counter] = array1[i];
        counter++;
    }
}
}

void PrintArrray(string[]array)
{
    for (int i = 0; i <  array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}