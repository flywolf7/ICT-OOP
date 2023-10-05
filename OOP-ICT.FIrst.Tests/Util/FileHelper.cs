namespace OOP_ICT.First.Tests.Util;

public static class FileHelper
{
    private static readonly string _root = "/Users/leha/Documents/Studies/programming/ICT-OOP/OOP-ICT.FIrst.Tests";

    public static string ReadTextFile(string path)
    {
        return File.ReadAllText(_root + path);
    }
}