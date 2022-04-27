using System;using R5T.T0064;


namespace R5T.Stavanger.Default
{[ServiceImplementationMarker]
    public class ShortcutPathConventions : IShortcutPathConventions,IServiceImplementation
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
