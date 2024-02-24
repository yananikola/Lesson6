void PrintArrayReversed(int[] array,int index)
{
if (index >= 0)
    {
        Console.Write(array[index] + " ");
        PrintArrayReversed(array, index - 1);
    }
}
int[] array = { 1, 2, 5, 0, 10, 34 };
PrintArrayReversed(array, array.Length - 1);