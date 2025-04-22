using System.Runtime.InteropServices;

public partial class App
{
    const string LibraryName = "libnative";
    
    [LibraryImport(LibraryName)]
    // [WasmImportLinkage]
    private static partial int add_numbers(int number1, int number2);

    public void Start()
    {
        var addedNumbers = add_numbers(10, 5);
        Console.WriteLine(addedNumbers);
    }
}