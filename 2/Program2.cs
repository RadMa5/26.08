void NewArray(int size, int minv, int maxv)
{
    int[] array = new int[size];
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minv, maxv);
    }
    for (int j = 1; j < size; j = j + 2)
    {
        count += array[j];
    }
    Console.WriteLine($"Array - {string.Join(" ", array)}");
    Console.WriteLine($"Sum of odd numbered integers - {count}");
}
NewArray(5, -100, 100);
NewArray(5, -100, 100);