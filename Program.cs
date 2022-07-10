using MoonSharp.Interpreter;

Script script = new Script();

while (true)
{
    string? source = Console.In.ReadLine();
    if (source == null || string.IsNullOrEmpty(source)) continue;
    // Custom Environment Here

    // Execute Script in Console
    try { script.DoString(source); } catch (Exception ex) { Console.WriteLine(ex.ToString()); }
}