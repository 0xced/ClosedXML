namespace ClosedXML.Utils
{
    internal static class GraphicsUtils
    {
        internal static Dpi Graphics = new Dpi();

        internal class Dpi
        {
            public float DpiX => 96;
            public float DpiY => 96;
        }
    }
}
