void RangeOfDigit(int m, int n)
{
    if (m <= n)
    {
        Console.Write(m);
        if (m < n)
        {
            Console.Write(", ");
        }
        RangeOfDigit(m + 1, n);
        return;
    }
}
int m = 1;
int n = 5;
RangeOfDigit(m, n);
