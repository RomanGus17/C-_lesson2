//пример поиска индекса по значению без методов и с константами
// int [] array = {1,12,31,18,4,15,16,17,18};

// int n = array.Length;
// int find = 18;

// int index = 0;

// while(index < n)
// {
//     if(array[index] == find)
//     {
//         Console.WriteLine(index);
//         break;
//     }
//     //index = index + 1;
//     index++;
// }


// пример с использованием массива с методами и без констант
void FillArray(int[] collection)

{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index<count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int [] array = new int[10]; //создай новый массив с 10 числами - будут заполнены нулями

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);