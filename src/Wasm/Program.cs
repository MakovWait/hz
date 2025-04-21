using System;
using System.Runtime.InteropServices.JavaScript;
using System.Threading.Tasks;

namespace Wasm;

public partial class Application
{
    public static async Task Main()
    {
        Console.WriteLine("Main");
        var app = new App();
        app.Start();
        Console.WriteLine("Main2");
    }

    [JSExport]
    public static void UpdateFrame()
    {
        Console.WriteLine("UpdateFrame");
    }
}