namespace TransformerApp
{
    public static class XmlUtilities
    {
        public static string OpenXmlTagRegex = @"<[^/?!][^<]+[^/]>";
        public static string ClosedXmlTagRegex = @"<\/.*>";
    }
}
