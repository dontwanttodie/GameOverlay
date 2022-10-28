namespace TestConsole
{
    using System.Resources;
    using System.Reflection;
    using System.Globalization;

    public class Program
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            CultureInfo culture = CultureInfo.CurrentUICulture;
            Console.WriteLine("The current UI culture is {0} [{1}]", culture.NativeName, culture.Name);


            ResourceManager rm = new ResourceManager("Locales.Strings", typeof(Locales.Strings).Assembly);
            
            var myName = rm.GetString("MyName");
            Console.WriteLine("My name is: {0}", myName);

            Console.WriteLine("Your name is: {0}", Locales.Strings.MyName);

        }
    }
}
