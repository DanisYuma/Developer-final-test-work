// Программа из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив вводим с клавиатуры.

string Prompt(string message)
{
    System.Console.Write(message);
    string result = Console.ReadLine();
    return result;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}  ");
    }
    System.Console.WriteLine();
}

string[] CreateArray()
{
    int count = 0;
    string value = "";
    string[] tempArray = new string[100];
    System.Console.WriteLine("To complete the entry, enter 'exit'");
    for (count = 0; value != "exit"; count++)
    {
        value = Prompt($"Enter {count + 1} element value>");
        if (value != "exit")
        {
            tempArray[count] = value;
        }
    }
    string[] array = new string[count - 1];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = tempArray[i];
    }
    return array;
}

string[] ThreeSymbolArray(string[] array)
{
    int count = 0;
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    string[] newArray = new string[count];
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= 3)
        {
            newArray[index] = array[j];
            index++;
        }
    }
    return newArray;
}

string[] array = CreateArray();
System.Console.Write("You entered > ");
PrintArray(array);
System.Console.Write("New array > ");
PrintArray(ThreeSymbolArray(array));