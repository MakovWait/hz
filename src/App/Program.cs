using System.Runtime.InteropServices;

public partial class App
{
    [LibraryImport("libnative")]
    private static partial int add_numbers(int number1, int number2);

    public void Start()
    {
        var addedNumbers = add_numbers(10, 5);
        Console.WriteLine(addedNumbers);
    }
}