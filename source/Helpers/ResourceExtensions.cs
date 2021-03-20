using System;
using System.Runtime.InteropServices;

using Windows.ApplicationModel.Resources;

namespace Developer_Coder_All_in_One_App___UWP.Helpers
{
    internal static class ResourceExtensions
    {
        private static ResourceLoader _resLoader = new ResourceLoader();

        public static string GetLocalized(this string resourceKey)
        {
            return _resLoader.GetString(resourceKey);
        }
    }
}
