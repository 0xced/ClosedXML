using System.Linq;
using ClosedXML.Excel;
using NUnit.Framework;
using SixLabors.Fonts;

namespace ClosedXML.Tests
{
    [SetUpFixture]
    public class TestInitializer
    {
        [OneTimeSetUp]
        public void Setup()
        {
            var assembly = typeof(TestInitializer).Assembly;
            var fontNames = assembly.GetManifestResourceNames().Where(e => e.EndsWith(".ttf"));
            var fontCollection = new FontCollection();
            foreach (var fontName in fontNames)
            {
                using var fontStream = assembly.GetManifestResourceStream(fontName)!;
                fontCollection.Add(fontStream);
            }
            FontConfiguration.FontCollection = fontCollection;
        }
    }
}
