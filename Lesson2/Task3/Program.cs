//int n = 10;
int[] array = { 2, 5, 4, 6, 8, 35, 1, 16, 8, 5 };
int i = 0;

while (i < array.Length)
{
    if (array[i] % 2 == 0)
    {
        System.Console.Write($"{array[i]} ");
    }
    i = i + 1;
}