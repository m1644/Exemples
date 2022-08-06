// Имеется одномерный массив array из n элементов,
// требуется найти элемент массива, равный find...

int[] array = {1, 4, 8, 16, 24, 44, 18, 22, 44};
int n = array.Length;
int find = 44;
int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    // index = index + 1;
    index++;
}
