// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// ["1234", "Admiral", "23", "+no", "data science", "y&i"]

// метод, задающий размер будующего массива:
int CountElementsArray(string[] arr, int size)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i].Length <= size) 
        {
            count++;
        }    
    return count;
}

// метод, создающий новый массив с элементами заданной длины:
string[] ArraySizeElements(string[] arr, int size, int count)
{
    string[] newArr = new string[count];
    for (int j = 0, i = 0; i < arr.Length; i++)
        if (arr[i].Length <= size)
        {
            newArr[j] = arr[i];
            j++;
        }
    return newArr;
}

// метод, печатающий массив:
void PrintArray(string[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
                else Console.Write($"{arr[i]}");
            }
            Console.Write("]");
        }

string[] array = new string[] {"1234", "Admiral", "23", "+no", "data science", "y&i"}; 
int sizeElement = 3; 
int lengthNewArray = CountElementsArray(array, sizeElement);
string[] newArray = ArraySizeElements(array, sizeElement, lengthNewArray);
PrintArray(array);
Console.WriteLine();
Console.Write("Новый массив из строк, длина которых меньше либо равна 3 символам: ");
PrintArray(newArray);    
