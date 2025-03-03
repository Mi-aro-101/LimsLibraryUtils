using System;
using System.Globalization;

namespace LimsUtils.Utility;

public class ViewUtils
{
    public static string RenderDateAsFrenchFormat(DateTime date)
    {
        string result = "";
        result = string.Format(new CultureInfo("fr-FR"), "{0:dd MMMM yyyy}", date);
        return result;
    }

    public static string RenderDateAsFrenchFormat(DateOnly date)
    {
        string result = "";
        result = string.Format(new CultureInfo("fr-FR"), "{0:dd MMMM yyyy}", date);
        return result;
    }

    public static string RenderMoney(decimal money)
    {
        string result = "";
        result = string.Format(CultureInfo.InvariantCulture, "{0:#,##0.00}", money).Replace(",", " ");
        return result;
    }
}