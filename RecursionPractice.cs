namespace collections_and_data_iteration_fundamentals;

/*
 * Things to remember: -
 * - Any code placed before recursion will occur before recursion (e.g. PrintNumbersFromNToOne), and any code placed after recursion will only occur after the last recursion point has been reached (e.g. PrintNumbersFromOneToN)
 */
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