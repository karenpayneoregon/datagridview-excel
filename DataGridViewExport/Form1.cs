using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;
using BindingListLibrary;
using DataGridViewExport.Classes;
using DataGridViewExport.Models;
using DataGridViewLibrary.Extensions;
using static DataGridViewExport.Classes.FunStuff;

namespace DataGridViewExport;

public partial class Form1 : Form
{
    /// <summary>
    /// We don't need this for the code sample but one should always consider using one
    /// </summary>
    private readonly BindingSource _bindingSource = new();

    private readonly BindingList<Contact> _bindingList;
    public Form1()
    {
        InitializeComponent();

        dataGridView1.AutoGenerateColumns = false;

        _bindingList = new SortableBindingList<Contact>(CreateOperations.Contacts(500));

        _bindingSource.DataSource = _bindingList;
        dataGridView1.DataSource = _bindingSource;

        dataGridView1.ExpandColumns();

        IdLabel.DataBindings.Add("Text", _bindingSource, nameof(Contact.Id));

        coreBindingNavigator1.BindingSource = _bindingSource;

        coreBindingNavigator1.DisableAddNewItems();
        coreBindingNavigator1.DisableRemoveItems();

        aboutToolStripButton.Click += AboutToolStripButton_Click;
        
    }

    private void AboutToolStripButton_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Inserted toolstrip button");
    }

    private void ExportButton_Click(object sender, EventArgs e)
    {
        dataGridView1.ExportRowsRaw("contacts.csv");
        File.WriteAllText("contacts.json",dataGridView1.SerializeToJson());

        var options = new JsonSerializerOptions
        {
            IncludeFields = true
        };

        List<ItemRecord> data = JsonSerializer.Deserialize<List<ItemRecord>>(dataGridView1.SerializeToJson(), options);

        var smallList = data.Take(3);
        foreach (var itemRecord in smallList)
        {
            Debug.WriteLine($"{itemRecord.Row}");
        }


        Shake(this);
    }

    /// <summary>
    /// Shows how to update FirstName property of the current DataGridView row
    /// </summary>
    private void UpdateFirstNameTextBox_Click(object sender, EventArgs e)
    {
        if (_bindingSource.Current is not null)
        {
            Contact contact = _bindingList[_bindingSource.Position];
        }


        _bindingList[_bindingSource.Position].FirstName = FirstNameTextBox.Text;
    }

    /// <summary>
    /// Shows how to find a row by FirstName property and update
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void FindAndUpdateButton_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(FindByFirstNameTextBox.Text))
        {
            Contact contact = _bindingSource
                .List
                .OfType<Contact>()
                .ToList()
                .Find(x => x.FirstName == FindByFirstNameTextBox.Text);


            _bindingSource.Position = _bindingSource.IndexOf(contact);
        }

    }

    private void FindByIdButton_Click(object sender, EventArgs e)
    {
        var test = NumericUpDownIdentifier.AsInteger();
        Contact contact = _bindingSource
            .List
            .OfType<Contact>()
            .ToList()
            .Find(x => x.Id == NumericUpDownIdentifier.AsInteger());


        _bindingSource.Position = _bindingSource.IndexOf(contact);
    }


}