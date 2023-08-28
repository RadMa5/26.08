void NewString(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(99, 1000);
    }
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) { count++; }
    }
    Console.WriteLine($"Random string - {string.Join(" ", array)}");
    Console.WriteLine($"Amount of even numbers - {count}");
}

NewString(5);
NewString(5);