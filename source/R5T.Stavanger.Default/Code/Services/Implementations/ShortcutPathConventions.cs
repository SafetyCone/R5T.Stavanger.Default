using System;


namespace R5T.Stavanger.Default
{
    public class ShortcutPathConventions : IShortcutPathConventions
    {
        public const string LinkSuffixExtension = "lnk";
        public const string LinkSuffixExtensionSeparator = ".";


        public string GetLinkSuffixExtension()
        {
            return ShortcutPathConventions.LinkSuffixExtension;
        }

        public string GetLinkSuffixExtensionSeparator()
        {
            return ShortcutPathConventions.LinkSuffixExtensionSeparator;
        }
    }
}
