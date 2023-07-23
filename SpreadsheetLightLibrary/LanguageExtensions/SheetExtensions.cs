﻿using SpreadsheetLight;

namespace SpreadsheetLightLibrary.LanguageExtensions;

/// <summary>
/// Common extensions 
/// </summary>
public static class SheetExtensions
{

    /// <summary>
    /// Same as in SheetHelpers while in this case it's an extension method
    /// </summary>
    /// <param name="document"></param>
    /// <param name="sheetName"></param>
    /// <returns></returns>
    public static bool SheetExists(this SLDocument document, string sheetName) =>
        document.GetSheetNames(false).Any((name) =>
            string.Equals(name, sheetName, StringComparison.CurrentCultureIgnoreCase));

}