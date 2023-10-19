using NorthWind2020Library.Classes;
using NorthWind2020Library.Models;
using System.ComponentModel;
using DataGridViewLibrary.Extensions;
using SpreadSheetLightImportDataTable.Classes;
// ReSharper disable LocalizableElement



namespace DataGridViewExport1;

public partial class Form1 : Form
{
    private List<CustomersForExcel> _customersForExcels;
    private readonly BindingSource _bindingSource = new();

    private readonly BindingList<CustomersForExcel> _bindingList;
    public Form1()
    {
        InitializeComponent();

        _customersForExcels = CustomerOperations.FromJson();
        
        // BLL is defined in the project file
        _bindingList = new BLL.SortableBindingList<CustomersForExcel>(_customersForExcels);
        
        _bindingSource.DataSource = _bindingList;
        dataGridView1.DataSource = _bindingSource;
        dataGridView1.Columns["id"]!.Visible = false;
        dataGridView1.ExpandColumns();

        BindingNavigator1.BindingSource = _bindingSource;

        toolStripExportButton.Click += ToolStripExportButton_Click;

    }

    private void ToolStripExportButton_Click(object sender, EventArgs e)
    {
        ExportToExcel();
    }

    private void ExportButton_Click(object sender, EventArgs e)
    {
        ExportToExcel();
    }

    private void ExportToExcel()
    {
        try
        {
            NorthWindOperations.CustomersToExcel(_bindingList.ToList(),
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Customers.xlsx"));
            MessageBox.Show("Done");
        }
        catch (Exception exception) when (exception.Message.Contains("The process cannot access the file"))
        {
            MessageBox.Show("Hey you have the spreadsheet open, can not save!!!");
        }
        catch (Exception exception)
        {
            MessageBox.Show($"Something went wrong '{exception.Message}'");
        }
    }
}
