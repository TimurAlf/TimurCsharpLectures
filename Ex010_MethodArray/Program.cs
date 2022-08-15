//Имеется одномерный массив array из n элементов требуется найти элемент массива равный find

int[] array = { 11, 2, 33, 4, 45, 6, 75, 18 ,9};

int n = array.Length;
int find = 18;
int index = 0;

while(index<n)
{
    if(array[index]== find)
    {
        Console.WriteLine(index);
        break;
    }
    //index=index+1
    index++;
}


