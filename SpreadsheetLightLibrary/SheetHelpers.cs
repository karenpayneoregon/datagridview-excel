using DocumentFormat.OpenXml.Spreadsheet;
using SpreadsheetLight;

#pragma warning disable CS8618

namespace SpreadsheetLightLibrary;

public class SheetHelpers
{
    public delegate void OnErrorDelegate(Exception exception);
    public static event OnErrorDelegate OnErrorEvent;

    /// <summary>
    /// Does a worksheet exists in an Excel file
    /// </summary>
    /// <param name="document">Instance of a <see cref="SLDocument"/></param>
    /// <param name="sheetName">Sheet name to determine if it exists in <see cref="document"/></param>
    /// <returns></returns>
    public static bool SheetExists(SLDocument document, string sheetName) 
        => document.GetSheetNames(false).Any((name) 
            => string.Equals(name, sheetName, StringComparison.CurrentCultureIgnoreCase));

    /// <summary>
    /// Get all sheet names in an Excel file
    /// </summary>
    /// <param name="fileName">Existing Excel file without a password</param>
    /// <returns>Sheet names in ordinal order</returns>
    /// <remarks>
    /// Both OleDb and automation return sheet names in A-Z order
    /// </remarks>
    public static List<string> SheetNames(string fileName)
    {
        using var document = new SLDocument(fileName);
        return document.GetSheetNames(false);
    }

    /// <summary>
    /// Remove <see cref="sheetName"/> if exists and is not the sole sheet in <see cref="fileName"/>
    /// </summary>
    /// <param name="fileName">Excel file</param>
    /// <param name="sheetName">Sheet name</param>
    /// <returns>success</returns>
    public static bool RemoveWorkSheet(string fileName, string sheetName)
    {
        using var document = new SLDocument(fileName);
        var workSheets = document.GetSheetNames(false);

        if (workSheets.Any((name) => string.Equals(name, sheetName, StringComparison.CurrentCultureIgnoreCase)))
        {

            if (workSheets.Count > 1)
            {
                document.SelectWorksheet(document.GetSheetNames().FirstOrDefault((name) => !string.Equals(name, sheetName, StringComparison.CurrentCultureIgnoreCase)));
            }
            else if (workSheets.Count == 1)
            {
                OnErrorEvent?.Invoke(new Exception("Can not delete the sole worksheet"));
            }

            document.DeleteWorksheet(sheetName);
            document.Save();

            return true;

        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Add new sheet to <see cref="fileName"/> if <see cref="sheetName"/> is not present
    /// </summary>
    /// <param name="fileName">Excel file</param>
    /// <param name="sheetName">sheet name</param>
    /// <returns></returns>
    public static bool AddNewSheet(string fileName, string sheetName)
    {
            
        using var document = new SLDocument(fileName);

        if (!(SheetExists(document, sheetName)))
        {

            document.AddWorksheet(sheetName);
            document.Save();

            return true;

        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Add multiple sheets to an Excel file bypassing any existing sheets with the same name
    /// </summary>
    /// <param name="fileName">Excel file</param>
    /// <param name="nameList">list of sheet names</param>
    public static void AddSheets(string fileName, List<string> nameList)
    {
        int counter = 0;

        using var document = new SLDocument(fileName);

        foreach (var name in nameList.Where(name => !SheetExists(document, name)))
        {
            document.AddWorksheet(name);
            counter += 1;

        }

        if (counter > 0)
        {
            document.Save();
        }

    }
    /// <summary>
    /// Create a new Excel file, rename the default sheet from
    /// Sheet1 to the value in pSheetName
    /// </summary>
    /// <param name="fileName">File to create</param>
    /// <param name="sheetName">New name for Sheet1</param>
    /// <returns></returns>
    public bool CreateNewFile(string fileName, string sheetName)
    {
        using var document = new SLDocument();
        document.RenameWorksheet("Sheet1", sheetName);
        document.SaveAs(fileName);
        return true;
    }

    /// <summary>
    /// Get last row in <see cref="pFileName"/> for <see cref="pSheetName"/>
    /// </summary>
    /// <param name="fileName">Existing file name</param>
    /// <param name="sheetName">Existing sheet</param>
    /// <returns>Last row or zero</returns>
    /// <remarks>
    /// if unsure if sheet exists use <see cref="SheetExists"/> first
    /// </remarks>
    public int GetWorkSheetLastRow(string fileName, string sheetName)
    {
        
        using var document = new SLDocument(fileName, sheetName);

        /*
         * get statistics, in this case we want the last used row so we
         * simply index into EndRowIndex yet there are more properties.
         */

        return document.GetWorksheetStatistics().EndRowIndex;

    }
}