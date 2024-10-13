using System.Security.Cryptography.X509Certificates;
using NorthWind2020Library.Data;
using NorthWind2020Library.Models;
#pragma warning disable CS8767 // Nullability of reference types in type of parameter doesn't match implicitly implemented member (possibly because of nullability attributes).

namespace NorthWind2020Library.Classes;

public class EmployeeOperations
{
    /// <summary>
    /// Example for self-referencing table where the property <see cref="Employees.ReportsTo"/> is null
    /// this indicates the <see cref="Employees"/> is a manager.
    ///
    /// <see cref="Employees.WorkersNavigation"/> for a manager will contain their employees.
    /// </summary>
    public static void EmployeeReportsTo()
    {
        using var context = new Context();

        List<Employees> allEmployeesList = context.Employees.ToList();

        List<Employees> managers = allEmployeesList
            .Where(employee => !employee.ReportsTo.HasValue)
            .ToList();

        Console.WriteLine("Managers/workers");
        foreach (Employees manager in managers)
        {
            Console.WriteLine($"{manager.FullName} - {manager.WorkersNavigation.Count}");
        }

        Console.WriteLine();

        Console.WriteLine("Workers");
        var workers = allEmployeesList.Where(x => x.ReportsTo.HasValue).ToList();

        foreach (var worker in workers)
        {
            Console.WriteLine($"{worker.FullName} {worker.ReportsToNavigation.FullName}");
        }

    }



}

public class EmployeesLastNameComparer : IComparer<Employees>
{

    public int Compare(Employees x, Employees y) 
        => string.Compare(x.LastName, y.LastName, StringComparison.Ordinal);
}