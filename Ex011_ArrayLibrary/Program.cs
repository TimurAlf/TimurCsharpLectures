void FillArray(int[] collection) //метод который заполняет массив сл. числами
{
    int length = collection.Length; //получить длину массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // заполняем массив новым случайным числом из диапозона
        index++;
    }
}

void PrintArray(int[] col) //метод который распечатывает массив
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) //метод, возвращающий позицию
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // создай новый массив с 10 элементами

FillArray(array);
PrintArray(array);

int pos =IndexOf(array,4);
Console.WriteLine(pos);
