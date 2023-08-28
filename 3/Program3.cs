void mxmn(double[] array)
{
    double max = 0, min = 100;
    foreach (double num in array)
    {
        if (num > max) { max = num; }
        else if (min > num) { min = num; }
    }
    Console.WriteLine($"In {string.Join(", ", array)} difference between largest and smallest numbers is {max - min}");
}
double[] test = { 3.22, 4.2, 1.15, 77.15, 65.2 };
mxmn(test);