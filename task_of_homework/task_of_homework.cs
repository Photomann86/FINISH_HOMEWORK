/* Написать программу, которая из имеющегося 
массива строк формирует массив из строк, длинна которых 
не более трёх символов. Первоначальный массив можно ввести с клавиатуры 
или задать на старте выполнения алгоритма. 
При реешении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами */
string[] firstMassiv = new string[5] {"7890", "hello", "01", "Hi", "765"}; //создание массива строк
string[] secondMassiv = new string[firstMassiv.Length];
//метод выбора строк с количеством символов не более 3
void SecondArray(string[] firstMassiv, string[] secondMassiv)
{
    int count = 0;
    for (int i=0; i<firstMassiv.Length; i++)
    {
        if (firstMassiv[i].Length<=3)
        {
        secondMassiv[count] = firstMassiv[i];
        count++;
        }
    }
}
//метод вывода массива строк на экран
void PrintMassivOfStrings(string[] Massiv)
{
    for (int i=0; i < Massiv.Length; i++)
    {
    Console.Write($"{Massiv[i]} ");
    }
    Console.WriteLine();
}
SecondArray(firstMassiv, secondMassiv);
PrintMassivOfStrings(firstMassiv); //вывод исходного массива
PrintMassivOfStrings(secondMassiv); //вывод результата
