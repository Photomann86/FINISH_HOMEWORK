/* Написать программу, которая из имеющегося 
массива строк формирует массив из строк, длинна которых 
не более трёх символов. Первоначальный массив можно ввести с клавиатуры 
или задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами */
int CountOfStrings(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int size = CountOfStrings("введите количество строковых элементов: ");
string[] ArrayOfStrings = new string[size];
for (int i=0; i<size; i++)
{
    Console.WriteLine($"введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    ArrayOfStrings[i] = element;
}
string[] FinalArray = new string[size];
int length = 3;
int pos = 0;
for (int j=0; j<size; j++)
{
    if (ArrayOfStrings[j].Length<=length)
    {
        FinalArray[pos] = ArrayOfStrings[j];
        pos++;
    }
}
void PrintFinal(string[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write(array[i] + " ");
    
    }
    Console.WriteLine();
}
Console.WriteLine("массив элементов из трёх и менее символов");
PrintFinal(FinalArray);