
using EmployeeApp.App.Implamentations;
using EmployeeApp.App.Interfaces;

EmployeService employeService = new EmployeService();

Console.WriteLine("0.Close");
Console.WriteLine("1.Create Employe");
Console.WriteLine("2.Update Employe");
Console.WriteLine("3.Delete Employe");
Console.WriteLine("4.ShowById");
Console.WriteLine("5.ShowAll");
Console.WriteLine("6.ShowByName");

string request = Console.ReadLine();

while (request != "0")
{
    switch (request)
    {
        case "1":
        employeService.Create();
            break;

        case "2":
            employeService.Update();
            break;
        case "3":
            employeService.Delete();
            break;
        case "4":
            employeService.ShowById();
            break;
        case "5":
            employeService.ShowAll();
            break;
        case "6":
            break;
            employeService.ShowByName();
        default:
            Console.WriteLine("Add valid option" );
            break;

    }
    Console.WriteLine("1.Create Employe");
    Console.WriteLine("2.Update Employe");
    Console.WriteLine("3.Delete Employe");
    Console.WriteLine("4.ShowById");
    Console.WriteLine("5.ShowAll");
    Console.WriteLine("6.ShowByName");

    request = Console.ReadLine();

}
