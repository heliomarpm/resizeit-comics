using System;

namespace ResizeImages
{
    public static class Extensions
    {
        public static string IsNull(this string pValue, string pDefault)
        {
            if (!String.IsNullOrWhiteSpace(pValue))
                return pValue;
            else
                return pDefault;
        }
    }
}
