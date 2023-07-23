using System.Windows.Forms;

namespace DataGridViewExport.Classes;

public static class Extensions
{
    public static int AsInteger(this NumericUpDown sender)
    {
        return (int)sender.Value;
    }
}