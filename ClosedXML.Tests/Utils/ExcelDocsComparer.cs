using System;
using System.IO;
using System.IO.Packaging;

namespace ClosedXML.Tests
{
    internal static class ExcelDocsComparer
    {
        public static bool Compare(string left, string right, out string message)
        {
            using (FileStream leftStream = File.OpenRead(left))
            using (FileStream rightStream = File.OpenRead(right))
            {
                return Compare(leftStream, rightStream, right, out message);
            }
        }

        public static bool Compare(Stream left, Stream right, string resource, out string message)
        {
            using (Package leftPackage = Package.Open(left, FileMode.Open, FileAccess.Read))
            using (Package rightPackage = Package.Open(right, FileMode.Open, FileAccess.Read))
            {
                return PackageHelper.Compare(leftPackage, rightPackage, Path.GetFileNameWithoutExtension(resource), false, ExcludeMethod, out message);
            }
        }

        private static bool ExcludeMethod(Uri uri)
        {
            //Exclude service data
            if (uri.OriginalString.EndsWith(".rels") ||
                uri.OriginalString.EndsWith(".psmdcp"))
            {
                return true;
            }
            return false;
        }
    }
}
