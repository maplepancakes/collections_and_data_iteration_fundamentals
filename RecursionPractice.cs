namespace collections_and_data_iteration_fundamentals;

public class RecursionPractice
{
    public void PrintNumbersFromOneToN(int n)
    {
        if (n <= 0) return;
        PrintNumbersFromOneToN(n - 1);
        Console.WriteLine($"PrintNumbersFromOneToN: {n}");
    }

    public void PrintNumbersFromNToOne(int n)
    {
        if (n <= 0) return;
        Console.WriteLine($"PrintNumbersFromNToOne: {n}");
        PrintNumbersFromNToOne(n - 1);
    }
}