namespace TestConsole
{
    using System.Globalization;

    public class TestConsole
    {
        public static void Main()
        {
            CultureInfo culture = CultureInfo.CurrentUICulture;
            Console.WriteLine("The current UI culture is {0} [{1}]",
                culture.NativeName, culture.Name);
        }
    }
}
