using System.Reflection;

namespace Alura.LeilaoOnline.Selenium.Helpers
{
    public class TestHelpers
    {
        public static string PastaDoExecutavel => Path.GetDirectoryName
            (Assembly.GetExecutingAssembly().Location);
    }
}
