namespace Csharp_Playground;

class Program
{
    static void Main(string[] args)
    {
        string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

        foreach (var item in orderIDs)
        {
            if (item.StartsWith("B"))
            {
                Console.WriteLine(item);
            }
        }





    }
}
